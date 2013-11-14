using System;
using System.Data.SQLite;

namespace SqlLiteTest.HelloWorld
{
    public static class BasicCrud
    {
        static SQLiteConnection m_dbConnection;

        public static void Run()
        {
            // http://blog.tigrangasparian.com/2012/02/09/getting-started-with-sqlite-in-c-part-one/
            // 
            // ### Create the database
            // SQLiteConnection.CreateFile("MyDatabase.sqlite");

            // ### Connect to the database
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();

            // ### Create a table
            // string sql = "CREATE TABLE highscores (name VARCHAR(20), score INT)";
            // SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            // command.ExecuteNonQuery();

            // ### Add some data to the table
            // string sql = "insert into highscores (name, score) values ('Me', 3000)";
            // SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            // command.ExecuteNonQuery();
            // sql = "insert into highscores (name, score) values ('Myself', 6000)";
            // command = new SQLiteCommand(sql, m_dbConnection);
            // command.ExecuteNonQuery();
            // sql = "insert into highscores (name, score) values ('And I', 9001)";
            // command = new SQLiteCommand(sql, m_dbConnection);
            // command.ExecuteNonQuery();

            // ### select the data
            string sql = "select * from highscores order by score desc";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["score"]);

            Console.ReadKey();
        }
    }
}
