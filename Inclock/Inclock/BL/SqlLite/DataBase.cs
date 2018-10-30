using SQLitePCL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Inclock.BL.SqlLite
{
    public class DataBase:IDisposable
    {

        private string _ConnectionString;
        public SQLite.SQLiteConnection connection { get; set; }
        public DataBase(string connectionString)
        {           
            _ConnectionString = Path.Combine(connectionString, "mwd.db");
            connection = new SQLite.SQLiteConnection(_ConnectionString);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
