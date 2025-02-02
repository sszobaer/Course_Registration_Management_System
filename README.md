# Course Registration Management System

Welcome to the Course Registration Management System! This application is meticulously designed to streamline the registration process, providing efficient handling of course enrollment. Developed using C# (.NET) and seamlessly integrated with an Oracle database, it ensures smooth and reliable data storage and retrieval.

---

# Table of Contents

1. [Authors](#authors)
2. [Team Members](#team-members)
3. [Background of the Problem](#background-of-the-problem)
   1. [Main Problems Students Face](#main-problems-students-face)
   2. [The Biggest Problem](#the-biggest-problem)
4. [Proposed Solution: Virtual Advisor Chatbot Powered by AI](#proposed-solution-virtual-advisor-chatbot-powered-by-ai)
   1. [How the Virtual Advisor Chatbot Will Help](#how-the-virtual-advisor-chatbot-will-help)
5. [Benefits of This Solution](#benefits-of-this-solution)
6. [Prerequisites](#prerequisites)
   1. [Required Software](#required-software)
7. [Get Started](#get-started)
   1. [Python Dependencies](#python-dependencies)
   2. [NuGet Packages](#nuget-packages)
8. [Installation Procedure](#installation-procedure)
   1. [Step 1: Clone the Repository](#step-1-clone-the-repository)
   2. [Step 2: Set Up the Database](#step-2-set-up-the-database)
   3. [Step 3: Configure the Connection String](#step-3-configure-the-connection-string)
   4. [Step 4: Build and Run the Project](#step-4-build-and-run-the-project)
9. [Special Instruction](#special-instruction)
    1. [Configuring the Oracle Database Connection String](#configuring-the-oracle-database-connection-string)
    2. [Testing the Connection](#testing-the-connection)
    3. [Configuring the Oracle Database Connection in Python using PyODBC](#configuring-the-oracle-database-connection-in-python-using-pyodbc)
10. [Architecture/Technology Sections](#architecturetechnology-sections)
    1. [Entity Relationship Diagram](#entity-relationship-diagram)
    2. [Schema Diagram](#schema-diagram)
    3. [Activity Diagram](#activity-diagram)
    4. [Class Diagram](#class-diagram)
    5. [Key Pages from UI](#key-pages-from-ui)
       1. [Admin Dashboard](#admin-dashboard)
       2. [Student Dashboard](#student-dashboard)
       3. [Take Courses or Register for a Course](#take-courses-or-register-for-a-course)
       4. [Smart Advisor](#smart-advisor)
       5. [Add New Course](#add-new-course)
11. [Color Reference](#color-reference)  
12. [Lessons Learned](#lessons-learned)  
   - 13.1 [Importance of Database Design](#1-importance-of-database-design)  
   - 13.2 [AI-Powered Virtual Advisor Implementation](#2-ai-powered-virtual-advisor-implementation)  
   - 13.3 [Optimizing Queries for Performance](#3-optimizing-queries-for-performance)  
   - 13.4 [Oracle Database Connection Challenges](#4-oracle-database-connection-challenges)  
   - 13.5 [User Experience & Interface Design](#5-user-experience--interface-design)  
   - 13.6 [Role-Based Access Control (RBAC)](#6-role-based-access-control-rbac)  
   - 13.7 [Importance of Payment Integration](#7-importance-of-payment-integration)  
   - 13.8 [Deployment & Compatibility Considerations](#8-deployment--compatibility-considerations)  
13. [Feedback & Issues](#feedback--issues)  
   - 14.1 [How to Provide Feedback](#how-to-provide-feedback)  
   - 14.2 [Reporting Issues](#reporting-issues)  
   - 14.3 [Contributing to the Project](#contributing-to-the-project)  
   - 14.4 [Using the GitHub Issue Tracker](#using-the-github-issue-tracker)  
14. [Acknowledgements](#acknowledgements)  
15. [Contact](#contact)

---

## Authors

- [S S Zobaer Ahmed](https://www.github.com/sszobaer)
---

## **Team Members**

| Name                        | Roles and Responsibilities                                |
|-----------------------------|----------------------------------------------------------|
| **S S Zobaer Ahmed**         | Project Lead, Backend Construction, AI Development and Integration, README Writer, Documentation, Formatting, OOE|
| **Morshed Al-Jaber Bishal**  | Database Specialist, Design, Query Writing               |
| **SANVIRAJ AYNUL SIAM**      | Documentation, Design, Query Writing                     |
| **SHARUP PAUL**              | Query Writing, Relational Algebra                        |

---

## Background of the Problem

Course registration is a vital process for university students. It ensures they can enroll in the correct courses to complete their degree on time. However, many students encounter challenges during the registration process, which can lead to delays in graduation or missed opportunities.

### Main Problems Students Face:
- **Limited Seats in Courses**: Students may miss out on essential courses due to limited seats.
- **No Immediate Help**: Academic advisors are often too busy to assist every student during registration.
- **Confusion About Course Selection**: Many students, especially first-year students, struggle to choose the right courses.
- **Time Conflicts**: Students may face overlapping class schedules that prevent them from enrolling in multiple desired courses.
- **Slow Decision-Making**: Delays in decision-making can cause students to miss available spots in courses.
- **System Issues**: The registration website may crash or slow down during peak usage times.

### The Biggest Problem:
Some students fail to register for courses altogether, which negatively impacts their academic progress and causes unnecessary stress.

## Proposed Solution: Virtual Advisor Chatbot Powered by AI

To solve these challenges, we introduce the **Virtual Advisor Chatbot**—an AI-powered solution that will streamline the registration process. The chatbot uses **Natural Language Processing (NLP)** with the **OpenAI API** to guide students through their course registration smoothly and effectively.

### How the Virtual Advisor Chatbot Will Help:
- **Suggesting Courses**: The chatbot will recommend the best courses based on the student’s academic progress and available options.
- **Finding Alternatives**: If a course is full, it will suggest similar courses.
- **Checking Requirements**: It will ensure students meet the prerequisites for a course before they attempt to enroll.
- **Avoiding Time Conflicts**: The chatbot will help students select courses that do not have overlapping schedules.
- **Available Anytime**: Unlike human advisors, the chatbot will be accessible 24/7 to assist students.
- **Notifying About Seat Availability**: If a course is full, the chatbot will notify students when a seat becomes available.
- **Answering Questions**: The chatbot will provide answers to questions regarding course rules, credit limits, and registration deadlines.
- **Helping Universities Plan Better**: The AI will predict which courses will be in high demand, assisting universities in offering more seats for those courses.

## Benefits of This Solution:
- **More Students Get Registered**: The chatbot helps students quickly find available courses, ensuring they don’t miss out on opportunities.
- **Less Pressure on Human Advisors**: With the chatbot answering routine questions, advisors can focus on more complex student needs.
- **Faster Decision-Making**: Students won’t waste time searching for courses, enabling faster registration.
- **Better Student Experience**: A smoother, stress-free registration process will enhance student satisfaction.
- **Smarter Course Planning**: Universities will have insights into which courses require more seats, ensuring better resource management.

Integrating the AI-powered **Virtual Advisor Chatbot** into the course registration system will significantly improve the experience for both students and universities. By offering quick recommendations, solving scheduling conflicts, and ensuring fair access to courses, this solution will reduce stress, save time, and enhance the overall academic experience.

## Prerequisites  

Before starting, ensure you have the following installed:  

### **Required Software**  
1. **Visual Studio** – [Download the latest version](https://visualstudio.microsoft.com/) and install it.  
   - During installation, select the **.NET desktop development** workload.  

2. **.NET Framework** – Included with Visual Studio, but if needed, download from [Microsoft's official site](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks).  

3. **Oracle Database Express Edition** – [Download](https://www.oracle.com/database/technologies/xe-downloads.html) and install it.  
   - Follow Oracle’s setup instructions and create a test database.  

4. **Ollama** – [Download here](https://ollama.com/download) and install it.
5. **Python** – [Download the latest version](https://www.python.org/downloads/) and install it.  
   - Ensure you check the option **"Add Python to PATH"** during installation. Also download a IDE for python.
   
## Get Started
### **Python Dependencies**  
Make sure you have Python installed, then install the required packages using:  
```bash
pip install flask pyodbc
```  

### **NuGet Packages**  
In **Visual Studio**, install the following NuGet packages:  

#### **Method 1: Using NuGet Package Manager GUI**  
1. Open **Visual Studio**.  
2. Go to **Tools** > **NuGet Package Manager** > **Manage NuGet Packages for Solution**.  
3. Search for and install the following packages:  
   - `Oracle.ManagedDataAccess`  
   - `Newtonsoft.Json`  

#### **Method 2: Using Package Manager Console**  
Alternatively, you can install them via the **Package Manager Console** (View > Other Windows > Package Manager Console):  
```powershell
Install-Package Oracle.ManagedDataAccess  
Install-Package Newtonsoft.Json
```  

## Installation Procedure  

Follow these steps to set up the **Course Registration Management System**:  

### **Step 1: Clone the Repository**  
```bash
git clone https://github.com/your-repo/course-registration-system.git
cd course-registration-system
```  

### **Step 2: Set Up the Database**  
1. Open **Oracle SQL Developer** or your preferred database tool.  
2. Create a database and run the provided SQL script to create tables.  

### **Step 3: Configure the Connection String**  
- In **Visual Studio**, navigate to `app.config` or `appsettings.json`.  
- Update the connection string to match your Oracle database credentials. 

### **Step 4: Build and Run the Project**  
1. Open the solution in **Visual Studio**.  
2. Restore NuGet packages (if not restored automatically).  
3. Press **F5** or click **Start** to run the application.

# Special Instruction
### **Configuring the Oracle Database Connection String**  

To connect your **Course Registration Management System** to an Oracle database, you need to update the **connection string** properly.  

#### **Connection String Format:**  
```csharp
string conStr = @"Data Source = (DESCRIPTION = 
(ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))) 
(CONNECT_DATA = (SERVICE_NAME = xe))); 
User Id = CRMS; 
Password = 1234;";
```

#### **What You Need to Change:**  
1. **HOST** (`localhost`) – Replace with your **Oracle server IP address** if the database is hosted on another machine.  
2. **PORT** (`1521`) – Ensure this matches the port used by your Oracle database.  
3. **SERVICE_NAME** (`xe`) – If you have a different Oracle **service name**, update it accordingly.  
4. **User Id** (`CRMS`) – Change to the Oracle **username** you created for the database.  
5. **Password** (`1234`) – Set your actual **Oracle database password**.  

#### **Example for a Remote Server:**  
If your Oracle database is on another machine with IP **192.168.1.100** and a service name of **orcl**, modify the string as follows:  
```csharp
string conStr = @"Data Source = (DESCRIPTION = 
(ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.1.100)(PORT = 1521))) 
(CONNECT_DATA = (SERVICE_NAME = orcl))); 
User Id = CRMS; 
Password = mySecurePassword;";
```

### **Testing the Connection**  
You can test the connection using a simple **C# Console Application**:  
```csharp
using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

class Program
{
    static void Main()
    {
        string conStr = @"Data Source = (DESCRIPTION = 
        (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))) 
        (CONNECT_DATA = (SERVICE_NAME = xe))); 
        User Id = CRMS; 
        Password = 1234;";

        using (OracleConnection conn = new OracleConnection(conStr))
        {
            try
            {
                conn.Open();
                Console.WriteLine("Connection Successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
```
If the connection is successful, it will print **"Connection Successful!"**; otherwise, it will display an error message.  

---

This will ensure your **Course Registration Management System** connects properly to Oracle. 

### **Configuring the Oracle Database Connection in Python using PyODBC**  

To connect your **Course Registration Management System** to Oracle using **PyODBC**, you need to configure the **connection string** correctly.  

---

### **Connection String Format:**  
```python
import pyodbc

conn = pyodbc.connect("DSN=OracleXE;UID=CRMS;PWD=1234")
```

---

### **What You Need to Change:**  
1. **DSN (`OracleXE`)** –  
   - This refers to the **Data Source Name** configured in your ODBC settings.  
   - You must **set up an ODBC Data Source** before using this connection.  
   - Alternatively, you can use a **direct connection string** (see below).  

2. **UID (`CRMS`)** –  
   - Change this to the **Oracle username** for your database.  

3. **PWD (`1234`)** –  
   - Set your actual **Oracle database password**.  

---

### **Alternative: Direct Connection Without DSN**  
If you don't want to configure an **ODBC Data Source**, use a **direct connection string**:  
```python
conn = pyodbc.connect(
    "DRIVER={Oracle in OraDB12Home1};"
    "DBQ=localhost:1521/xe;"
    "UID=CRMS;"
    "PWD=1234"
)
```
#### **Modifications for Your Setup:**  
- **DRIVER (`Oracle in OraDB12Home1`)** – Change based on your Oracle driver version.  
  - Run the following command to check installed drivers:  
    ```python
    print(pyodbc.drivers())
    ```
- **DBQ (`localhost:1521/xe`)** –  
  - Replace `localhost` with your **Oracle server IP** if it's remote.  
  - Replace `xe` with your **actual service name**.  

---

### **Testing the Connection**  
You can test if the connection is working using this Python script:  
```python
import pyodbc

try:
    conn = pyodbc.connect("DSN=OracleXE;UID=CRMS;PWD=1234")
    cursor = conn.cursor()
    cursor.execute("SELECT * FROM dual")  # A test query for Oracle
    print("Connection Successful!")
    conn.close()
except Exception as e:
    print("Error:", e)
```

---

### **Setting Up ODBC Data Source (Windows Only)**
If you use **DSN=OracleXE**, you must first configure it in **ODBC Data Source Administrator**:  
1. Open **ODBC Data Source Administrator** (**Run `odbcad32.exe`**).  
2. Go to the **System DSN** tab and click **Add**.  
3. Select **Oracle ODBC Driver** and click **Finish**.  
4. Enter:  
   - **Data Source Name (DSN):** `OracleXE`  
   - **TNS Service Name:** `xe`  
   - **User ID:** `CRMS`  
5. Click **OK** and test the connection.  

---

This will ensure your **Course Registration Management System** connects properly to Oracle in Python! 🚀 

Your **Course Registration Management System** should now be up and running! 🚀  

# Architecture/Technology Sections
## Entity Relationship Diagram
![Untitled design (42)](https://github.com/user-attachments/assets/3645bc3e-77f1-41f8-a7a1-baaf5fafb85a)

## Schema Diagram
![Scema Diagram](https://github.com/user-attachments/assets/e5c8a7cb-afc8-40ae-bc05-36289e95246e)

## Activity Diagram
![Activity](https://github.com/user-attachments/assets/3e395e7a-ccd9-496f-9234-776ba69f4668)

## Class Diagram
![Class](https://github.com/user-attachments/assets/92a32d14-b787-4ff9-aee2-d637ae639d34) 

## Key pages from UI

### Admin dashboard
![Screenshot 2025-02-03 000057](https://github.com/user-attachments/assets/e5fc616e-d53d-4207-8e6f-75dd3e806ff9)

### Student dashboard
![Screenshot 2025-02-03 000643](https://github.com/user-attachments/assets/4ff86fee-b2a4-4b10-a228-7fc7f1908c7c)

### Take courses or register for a course
![Screenshot 2025-02-03 000710](https://github.com/user-attachments/assets/7dfcac58-aa67-4b20-8632-77b2411b3fcd)

### Smart Advisor
![Screenshot 2025-02-03 001602](https://github.com/user-attachments/assets/1bd09a69-4867-4747-b77c-6e060a84f6b1)

### Add new course
![Screenshot 2025-02-03 000120](https://github.com/user-attachments/assets/107d1d80-1a48-4b1a-b428-00c5f28b6c5a)



---
# **Color Reference**  

| Color       | Hex Code   | Preview |
|------------|------------|---------|
| **Black**      | `#0a192f` | ![#0a192f](https://via.placeholder.com/15/0a192f/000000?text=+) |
| **White**      | `#f8f8f8` | ![#f8f8f8](https://via.placeholder.com/15/f8f8f8/000000?text=+) |
| **Teal**       | `#008080` | ![#008080](https://via.placeholder.com/15/008080/000000?text=+) |
| **Smoke White** | `#f5f5f5` | ![#f5f5f5](https://via.placeholder.com/15/f5f5f5/000000?text=+) |
---

# **Lessons Learned**  

### **1. Importance of Database Design**  
- Structuring tables correctly, such as `classSchedule`, `REGISTEREDCOURSE`, and `PREREQUISITECOURSE`, is crucial for ensuring efficient data retrieval and integrity.  
- Implementing **relationships between tables** (e.g., **students, courses, and prerequisites**) improved query performance and data consistency.  

### **2. AI-Powered Virtual Advisor Implementation**  
- Integrating an **AI-based chatbot** for course advising added significant value, helping students register for courses efficiently.  
- Mapping **user queries to database interactions** required careful planning to ensure accurate responses.  

### **3. Optimizing Queries for Performance**  
- Writing **efficient SQL queries** helped reduce query execution time, especially when dealing with **large datasets** (e.g., retrieving schedules, prerequisites, and registered courses).  
- Indexing key columns improved **database performance**.  

### **4. Oracle Database Connection Challenges**  
- Configuring **Oracle.ManagedDataAccess** in C# and **PyODBC** in Python required proper **connection strings and ODBC setup**.  
- Understanding how to **secure database credentials** (e.g., avoiding hardcoded passwords) was critical for security.  

### **5. User Experience & Interface Design**  
- Designing a **user-friendly WinForms UI** was essential for smooth navigation.  
- Implementing **error handling** and clear feedback messages improved the overall experience.  

### **6. Role-Based Access Control (RBAC)**  
- Implementing **admin, student, and faculty roles** required well-defined **authentication and authorization mechanisms**.  
- Secure **login and password management** were critical for protecting user data.  

### **7. Importance of Payment Integration**  
- The **payment module** needed proper validation to ensure students successfully complete transactions.  
- Handling different **payment methods** (e.g., banking, mobile banking) required additional configurations.  

### **8. Deployment & Compatibility Considerations**  
- Ensuring the system runs smoothly on different **Windows environments** required testing on multiple setups.  
- Managing dependencies, such as **.NET Framework, Oracle drivers, and NuGet packages**, was essential for proper installation.  

---

# **Feedback & Issues**  

We value your feedback and contributions to improve the **Course Registration Management System**. Please follow the steps below for providing feedback or reporting issues:

### **How to Provide Feedback**  
- If you have any suggestions, questions, or need support, feel free to **open an issue** on our [GitHub repository](https://github.com/your-repository-link).
- Provide a **clear description** of your feedback or the issue you're facing.
- For suggestions, explain how the system could be improved or how it could better meet the user needs.
  
### **Reporting Issues**  
- If you encounter any bugs or unexpected behavior, please open a new issue on the repository with the following details:
  1. **Summary of the issue**: A concise description of the problem.
  2. **Steps to Reproduce**: Describe the steps taken to reproduce the issue, including any input or actions.
  3. **Expected Behavior**: What you expected to happen.
  4. **Actual Behavior**: What actually happened.
  5. **Screenshots or Logs** (optional): If applicable, include any relevant screenshots, logs, or error messages.
  
### **Contributing to the Project**  
- If you'd like to contribute to the project, we welcome pull requests. Please fork the repository, make your changes, and submit a pull request with a detailed description of what was changed.

### **Using the GitHub Issue Tracker**  
- Go to the **Issues** tab in our GitHub repository to view open issues or add new ones.
- Feel free to comment on any issue to provide additional context or ask for clarification.
  
---

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgements

Special thanks to:
- **Microsoft and Oracle** for their development tools and platform.
- **Stack Overflow** and **GitHub** communities for their valuable support and resources.
- And Also <br>
🎓 **Juena Ahmed Noshin**  <br>
🎓 Assistant Professor, Faculty, Department of Computer Science, AIUB <br>
Your guidance has been instrumental in the development of this project.

## Contact

For more information, reach out to:

- **Email:** [ahmedsszobaer@gmail.com](mailto:ahmedsszobaer@gmail.com)
- **GitHub:** [S. S. Zobaer Ahmed](https://www.github.com/sszobaer)
- **Linkedin:** [S. S. Zobaer Ahmed](https://www.linkedin.com/in/s-s-zobaer-ahmed-209bab296?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_medium=android_app)
- **YouTube Channel:** [Code Craft Zobaer](https://www.youtube.com/@CodeCraftZobaer)
