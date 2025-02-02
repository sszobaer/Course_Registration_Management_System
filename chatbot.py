from flask import Flask, request, jsonify
import ollama
import pyodbc

# Initialize Flask app
app = Flask(__name__)


# Oracle Database Connection
def get_student_registered_courses(student_id):
    """Fetch courses the student is already registered for from the RegisteredCourse table."""
    try:
        conn = pyodbc.connect("DSN=OracleXE;UID=CRMS;PWD=1234")
        cursor = conn.cursor()

        # Join RegisteredCourse table with Course table to fetch course details including credits
        cursor.execute("""
            SELECT r.COURSEID, c.CREDITS
            FROM RegisteredCourse r
            JOIN Course c ON r.COURSEID = c.courseId
            WHERE r.STUDENTID = ?
        """, (student_id,))

        # Fetch registered courses along with credits
        registered_courses = cursor.fetchall()  # [(course_id, credits), ...]
        conn.close()
        return registered_courses
    except pyodbc.Error as e:
        print(f"Database Error: {str(e)}")
        return []


def get_class_schedule(course_id):
    """Fetch class schedule for a given course from the classSchedule table."""
    try:
        conn = pyodbc.connect("DSN=OracleXE;UID=CRMS;PWD=1234")
        cursor = conn.cursor()
        cursor.execute("SELECT classDay, classTime FROM classschedule WHERE courseId=?", (course_id,))
        schedule = cursor.fetchall()
        conn.close()
        return schedule
    except pyodbc.Error as e:
        print(f"Database Error: {str(e)}")
        return []


def get_prerequisite_courses(course_id):
    """Fetch prerequisite courses for a given course from the PreRequisiteCourse table."""
    try:
        conn = pyodbc.connect("DSN=OracleXE;UID=CRMS;PWD=1234")
        cursor = conn.cursor()
        cursor.execute("SELECT PreRequisiteCourseId FROM PreRequisite WHERE CourseId=?", (course_id,))
        prereq_courses = [row[0] for row in cursor.fetchall()]
        conn.close()
        return prereq_courses
    except pyodbc.Error as e:
        print(f"Database Error: {str(e)}")
        return []


def generate_student_schedule(student_id, credit_limit=None):
    """Generate a class schedule for a student, considering their registered courses and optionally a credit limit."""
    registered_courses = get_student_registered_courses(student_id)
    if not registered_courses:
        return "No courses found for the student."

    total_credits = sum(course[1] for course in registered_courses)  # Summing up the credits
    student_schedule = {}

    if credit_limit and total_credits > credit_limit:
        return f"Your total credits ({total_credits}) exceed the requested limit of {credit_limit}. Please adjust your course selection."

    # Loop through registered courses and fetch additional eligible courses based on prerequisites
    suggested_courses = []
    for course_id, _ in registered_courses:
        # Fetch the class schedule for each course
        class_schedule = get_class_schedule(course_id)

        for day, time in class_schedule:
            if day not in student_schedule:
                student_schedule[day] = []
            student_schedule[day].append((time, course_id))  # Add the course and its class time to the day

        # Get the prerequisite courses for the registered course
        prereq_courses = get_prerequisite_courses(course_id)
        for prereq_course in prereq_courses:
            # If the student is not already registered for the prerequisite course, suggest it
            if not any(prereq_course == registered[0] for registered in registered_courses):
                suggested_courses.append(prereq_course)

    # Sort the schedule for each day by time
    for day in student_schedule:
        student_schedule[day].sort(key=lambda x: x[0])  # Sort by class time

    # Format the schedule to return
    schedule_output = []
    for day, classes in student_schedule.items():
        day_schedule = f"{day}: " + ", ".join([f"Course {course_id} at {time}" for time, course_id in classes])
        schedule_output.append(day_schedule)

    # Suggest the additional courses
    suggested_courses_output = ""
    if suggested_courses:
        suggested_courses_output = "\nYou can consider the following additional courses based on prerequisites:\n" + "\n".join(
            [f"Course {course_id}" for course_id in suggested_courses])

    return "\n".join(
        schedule_output) + "\n" + suggested_courses_output if schedule_output else "No classes found for the student."


@app.route("/chat", methods=["POST"])
def chat():
    user_message = request.json.get("message", "")
    student_id = request.json.get("student_id", "")  # Assume student_id is passed in the request

    if not user_message or not student_id:
        return jsonify({"error": "Message and student_id are required"}), 400

    # If user asks for the student's schedule
    if any(keyword in user_message.lower() for keyword in
           ["suggest schedule", "my schedule", "class timings", "class schedule"]):

        # Check for credit limit in the message (e.g., "15 credits")
        credit_limit = None
        if "credits" in user_message.lower():
            credit_limit = int([word for word in user_message.split() if word.isdigit()][0])

        # Generate and return the schedule
        schedule = generate_student_schedule(student_id, credit_limit)
        return jsonify({"response": f"Here is your schedule:\n{schedule}"})

    # Otherwise, generate AI response
    response = ollama.generate(model="mistral", prompt=user_message)
    return jsonify({"response": response["response"]})


if __name__ == "__main__":
    app.run(host="0.0.0.0", port=5000, debug=True)
