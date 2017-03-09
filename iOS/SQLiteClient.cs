using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using SQLite;
using System.IO;
using Xamarin.Forms;
using Lebenslauf.Ios;

[assembly: Dependency(typeof(SQLiteClient))]
namespace Lebenslauf.Ios
{
    public class SQLiteClient : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "DatabaseCV.db3";

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), sqliteFilename);
            // dbPath contains a valid file path for the database file to be stored

            var conn = new SQLite.SQLiteConnection(path);
            
             return conn;
        }
    }
}