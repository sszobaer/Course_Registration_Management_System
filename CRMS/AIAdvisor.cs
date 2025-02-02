using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMS
{
    public partial class AIAdvisor : Form
    {
        private static readonly HttpClient client = new HttpClient();
        int studentId;
        public AIAdvisor(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private async void sendBtn_Click(object sender, EventArgs e)
        {
            string userMessage = txtUserInput.Text;

            if (string.IsNullOrWhiteSpace(userMessage))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            // Disable the send button temporarily
            sendBtn.Enabled = false;

            // Append user's message to the RichTextBox
            AppendToRichTextBox($"You: {userMessage}", Color.Black, FontStyle.Bold);

            // Fetch the response from the chatbot (including course suggestions if relevant)
            string botResponse = await GetChatbotResponse(userMessage);

            // Format the response
            string formattedResponse = FormatResponse(botResponse);

            // Append chatbot's response to the RichTextBox
            AppendToRichTextBox($"Bot:", Color.DarkGreen, FontStyle.Bold);
            AppendToRichTextBox(formattedResponse, Color.DarkBlue, FontStyle.Regular);

            // Clear input field
            txtUserInput.Clear();

            // Re-enable the send button
            sendBtn.Enabled = true;
        }

        private async Task<string> GetChatbotResponse(string message)
        {
            try
            {
                // Create request body with user message and student ID
                var requestBody = new { message = message, student_id = studentId };
                string json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send POST request to Flask API
                HttpResponseMessage response = await client.PostAsync("http://127.0.0.1:5000/chat", content);
                response.EnsureSuccessStatusCode();

                // Read and return response from API
                string responseBody = await response.Content.ReadAsStringAsync();

                // Debugging: Print out the raw response to check its structure
                Console.WriteLine("API Response: " + responseBody);

                // Assuming the response from Flask is in the format: { "response": "Bot's reply" }
                dynamic result = JsonConvert.DeserializeObject(responseBody);

                if (result?.response != null)
                {
                    return result.response.ToString();
                }
                else
                {
                    return "No response found in API response.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error communicating with the chatbot service: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error: Unable to get a response from the server.";
            }
        }

        private void AppendToRichTextBox(string text, Color color, FontStyle fontStyle)
        {
            rtbChat.SelectionStart = rtbChat.TextLength;
            rtbChat.SelectionLength = 0;

            rtbChat.SelectionColor = color;
            rtbChat.SelectionFont = new Font("Arial", 10, fontStyle);

            rtbChat.AppendText(text + Environment.NewLine);
            rtbChat.ScrollToCaret();  
        }

        private string FormatResponse(string response)
        {
            string formatted = response.Replace("\\n", Environment.NewLine);

            if (response.Contains("{") && response.Contains("}"))
            {
                formatted = $"Code Snippet:{Environment.NewLine}{formatted}{Environment.NewLine}";
            }

            formatted = $"--- ---{Environment.NewLine}{formatted}{Environment.NewLine}---  ---";

            return formatted;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (Home.stack.Count > 0)
            {
                Form previousForm = Home.stack.Pop();
                this.Hide();
                previousForm.Show();
            }
        }
    }
}
