import pyodbc

try:
    conn = pyodbc.connect("DSN=OracleXE;UID=CRMS;PWD=1234")
    cursor = conn.cursor()

    cursor.execute("SELECT courseName FROM Course")
    for row in cursor.fetchall():
        print(row)

    conn.close()
    print("✅ Connected successfully!")

except Exception as e:
    print(f"❌ Error while connecting to Oracle: {e}")
