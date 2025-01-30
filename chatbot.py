from flask import Flask, request, jsonify
import ollama
import pyodbc

# Initialize Flask app
app = Flask(__name__)


# Oracle Database Connection
def get_course_suggestions():
    try:
        conn = pyodbc.connect("DSN=OracleXE;UID=CRMS;PWD=1234")  # Use your DSN, User, and Password
        cursor = conn.cursor()
        cursor.execute("SELECT courseName FROM course")  # Modify table/column names as per your schema
        courses = [row[0] for row in cursor.fetchall()]
        conn.close()

        # Debugging: Print the fetched courses to check
        print("Courses fetched from DB:", courses)

        return ", ".join(courses) if courses else "No courses available."
    except Exception as e:
        print(f"Error fetching courses: {str(e)}")
        return f"Error fetching courses: {str(e)}"


# Function to get class schedule suggestions
def get_class_schedule_suggestions():
    try:
        conn = pyodbc.connect("DSN=OracleXE;UID=CRMS;PWD=1234")  # Use your DSN, User, and Password
        cursor = conn.cursor()
        cursor.execute(
            "SELECT courseId, classTime, classDay FROM classschedule")  # Modify table/column names as per your schema
        schedule = cursor.fetchall()
        conn.close()

        # Debugging: Print the fetched schedules to check
        print("Class Schedules fetched from DB:", schedule)

        if schedule:
            return "\n".join([f"{row[0]} at {row[1]}" for row in schedule])
        else:
            return "No class schedules available."
    except Exception as e:
        print(f"Error fetching class schedules: {str(e)}")
        return f"Error fetching class schedules: {str(e)}"


@app.route("/chat", methods=["POST"])
def chat():
    user_message = request.json.get("message", "")

    if not user_message:
        return jsonify({"error": "Message is required"}), 400

    # If user asks for course suggestions, fetch from Oracle
    if any(keyword in user_message.lower() for keyword in
           ["suggest courses", "available courses", "course list", "courses offered"]):
        courses = get_course_suggestions()
        return jsonify({"response": f"Here are some available courses: {courses}"})

    # If user asks for class schedule suggestions, fetch from Oracle
    if any(keyword in user_message.lower() for keyword in
           ["suggest schedule", "class schedule", "schedule list", "class timings"]):
        schedule = get_class_schedule_suggestions()
        return jsonify({"response": f"Here is the class schedule:\n{schedule}"})

    # Otherwise, generate AI response
    response = ollama.generate(model="mistral", prompt=user_message)

    return jsonify({"response": response["response"]})


if __name__ == "__main__":
    app.run(host="0.0.0.0", port=5000, debug=True)
