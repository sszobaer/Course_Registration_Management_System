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

        public AIAdvisor()
        {
            InitializeComponent();
        }

        private async void sendBtn_Click(object sender, EventArgs e)
        {
            string userMessage = txtUserInput.Text;

            if (string.IsNullOrWhiteSpace(userMessage))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

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
        }

        private async Task<string> GetChatbotResponse(string message)
        {
            try
            {
                var requestBody = new { message = message };
                string json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send POST request to Flask API
                HttpResponseMessage response = await client.PostAsync("http://127.0.0.1:5000/chat", content);
                response.EnsureSuccessStatusCode();

                // Read and return response from API
                string responseBody = await response.Content.ReadAsStringAsync();
                dynamic result = JsonConvert.DeserializeObject(responseBody);

                return result.response.ToString();
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        // Helper Method: Append Text to RichTextBox with Formatting
        private void AppendToRichTextBox(string text, Color color, FontStyle fontStyle)
        {
            rtbChat.SelectionStart = rtbChat.TextLength;
            rtbChat.SelectionLength = 0;

            rtbChat.SelectionColor = color;
            rtbChat.SelectionFont = new Font("Arial", 10, fontStyle);

            rtbChat.AppendText(text + Environment.NewLine);

            rtbChat.ScrollToCaret();
        }

        // Helper Method: Format the Response
        private string FormatResponse(string response)
        {
            // Replace escaped newlines with actual newlines
            string formatted = response.Replace("\\n", Environment.NewLine);

            // Optionally wrap code blocks with markers for better visual separation
            if (response.Contains("{") && response.Contains("}"))
            {
                formatted = $"Code Snippet:{Environment.NewLine}{formatted}{Environment.NewLine}";
            }

            return formatted;
        }
    }
}
