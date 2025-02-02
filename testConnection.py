import pyodbc

# Replace with your actual DSN, username, and password
dsn = 'OracleXE'  # The name of your DSN (Data Source Name)
username = 'CRMS'  # Your database username
password = '1234'  # Your database password

# Try connecting to the database
try:
    conn = pyodbc.connect(f'DSN={dsn};UID={username};PWD={password}')
    print("Connection successful!")
    conn.close()  # Close the connection
except Exception as e:
    print(f"Error: {e}")
