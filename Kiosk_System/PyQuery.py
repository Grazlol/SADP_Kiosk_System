import mysql.connector

mydb = mysql.connector.connect(
    host="localhost",
    user="root",
    password="",
    database="ksys"
)

ctr = 1;


while(ctr < 1000):
    ctr += 1; mycursor = mydb.cursor();
    sql = "Insert into table_user (uid) values (" + str(ctr) + ")"
    mycursor.execute(sql)
    mydb.commit()