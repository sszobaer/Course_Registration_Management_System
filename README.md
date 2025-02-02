# Course Registration Management System

## Authors

- [S S Zobaer Ahmed](https://www.github.com/sszobaer)


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

### Architecture/Technology Sections
### Entity Relationship Diagram
![Untitled design (42)](https://github.com/user-attachments/assets/3645bc3e-77f1-41f8-a7a1-baaf5fafb85a)

### Schema Diagram
![Scema Diagram](https://github.com/user-attachments/assets/e5c8a7cb-afc8-40ae-bc05-36289e95246e)

### Activity Diagram
![Activity](https://github.com/user-attachments/assets/3e395e7a-ccd9-496f-9234-776ba69f4668)

### Class Diagram
![Class](https://github.com/user-attachments/assets/92a32d14-b787-4ff9-aee2-d637ae639d34) 

---

## **Color Reference**  

| Color       | Hex                                                                |
|------------|--------------------------------------------------------------------|
| Black      | ![#0a192f](https://via.placeholder.com/10/0a192f?text=+) `#0a192f` |
| White      | ![#f8f8f8](https://via.placeholder.com/10/f8f8f8?text=+) `#f8f8f8` |
| Teal       | ![#008080](https://via.placeholder.com/10/008080?text=+) `#008080` |
| Smoke White | ![#f5f5f5](https://via.placeholder.com/10/f5f5f5?text=+) `#f5f5f5` |

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

## Conclusion

Integrating the AI-powered **Virtual Advisor Chatbot** into the course registration system will significantly improve the experience for both students and universities. By offering quick recommendations, solving scheduling conflicts, and ensuring fair access to courses, this solution will reduce stress, save time, and enhance the overall academic experience.


![Screenshot 2025-01-26 213949](https://github.com/user-attachments/assets/4c783367-d1ec-408e-b208-6af35fb638af)
![Screenshot 2025-01-26 214009](https://github.com/user-attachments/assets/291e9129-04cd-46b9-92b7-f9f46f9e54d2)
![Screenshot 2025-01-26 214021](https://github.com/user-attachments/assets/3b5914d6-0975-41b2-b5fe-e23741e68ced)
![Screenshot 2025-01-26 214039](https://github.com/user-attachments/assets/6c5e209a-7972-432a-b600-c8827ff7f605)
![Screenshot 2025-01-26 214047](https://github.com/user-attachments/assets/f1d450a7-2533-40eb-a0c7-fb4017c6c5d7)
![Screenshot 2025-01-26 214058](https://github.com/user-attachments/assets/913ab784-068a-495c-a500-1ed5ef4dad2a)
![Screenshot 2025-01-26 213937](https://github.com/user-attachments/assets/2db8cfc8-75f8-485e-a936-7a02e84e457a)
