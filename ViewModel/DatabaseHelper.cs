using System;
using System.IO;
using SQLite;

namespace RandomFilesTest.ViewModel
{
    public class DatabaseHelper
    {
        private static string dbFile = Path.Combine(Environment.CurrentDirectory, "RandomFiles.db3");

        public static bool Insert<T>(T item)
        {
            bool result = false;
            
            using (var connection = new SQLiteConnection(dbFile))
            {
                connection.CreateTable<T>();
                int numberOfRows = connection.Insert(item);
                if (numberOfRows > 0)
                {
                    result = true;
                }
            }
            return result;
        }

        public static bool Update<T>(T item)
        {
            bool result = false;
            using (var connection = new SQLiteConnection(dbFile))
            {
                connection.CreateTable<T>();
                int numberOfRows = connection.Update(item);
                
                if (numberOfRows > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public static bool Delete<T>(T item)
        {
            bool result = false;
            using (var connection = new SQLiteConnection(dbFile))
            {
                connection.CreateTable<T>();
                int numberOfRows = connection.Delete<T>(item);
                if (numberOfRows > 0)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}