using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace ConsoleApp20260407
{
    internal class SQLiteTest
    {
        static string connStr = "Data Source=test.db";


        static void Main(string[] args)
        {
            //using SqliteConnection sqliteConomy = new SqliteConnection(connStr);
            //sqliteConomy.Open();

            //using SqliteCommand sqliteoCommand = sqliteConomy.CreateCommand();
            ////sqliteoCommand.CommandText = "SELECT name FROM sqlite_master WHERE type = 'table';";
            //sqliteoCommand.CommandText = "SELECT * from dept";

            //using SqliteDataReader reader = sqliteoCommand.ExecuteReader();

            //for (int i = 0; i < reader.FieldCount; i++)
            //{
            //    Console.Write($"{reader.GetName(i)}\t");
            //}
            //Console.WriteLine();

            //while (reader.Read())
            //{
            //    for (int i = 0; i < reader.FieldCount; i++)
            //    {
            //        object value = reader.IsDBNull(i) ? "NULL" : reader.GetValue(i);
            //        Console.Write($"{value}\t");
            //    }

            //    Console.WriteLine();
            //}




            QueryDeptInfo();
        }

        static void QueryDeptInfo()
        {
            using SqliteConnection conn = new SqliteConnection(connStr);
            conn.Open();

            SqliteCommand sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = "select * from dept";

            SqliteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();

            while (sqliteDataReader.Read())
            {
                Console.WriteLine($"{sqliteDataReader["deptno"]}");
            }
        }



        static void DeleteDeptInfo()
        {
            using SqliteConnection conn = new SqliteConnection(connStr);
            conn.Open();

            SqliteCommand sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = "delete from dept where deptno = @deptno";
            sqliteCommand.Parameters.AddWithValue("@deptno", 30);

            sqliteCommand.ExecuteNonQuery();

        }

        static void InsertDeptInfo()
        {
            using SqliteConnection conn = new SqliteConnection(connStr);
            conn.Open();

            SqliteCommand sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = "insert into dept(deptno, loc) values(@deptno, @loc)";
            sqliteCommand.Parameters.AddWithValue("@deptno", 40);
            sqliteCommand.Parameters.AddWithValue("@loc", "大连");

            sqliteCommand.ExecuteNonQuery();
        }


        static void UpdateDeptInfo()
        {
            using SqliteConnection conn = new SqliteConnection(connStr);
            conn.Open();

            SqliteCommand sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = "update dept set loc = @loc where deptno = @deptno";
            sqliteCommand.Parameters.AddWithValue("@deptno", 20);
            sqliteCommand.Parameters.AddWithValue("@loc", "shenyang");

            sqliteCommand.ExecuteNonQuery();

        }
    }
}
