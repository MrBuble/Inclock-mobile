using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;
using SQLitePCL;
namespace Inclock.BL.SqlLite
{
    public class DataBase
    {
        public SQLiteConnection db { get; set; } = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "dbo.db3"));
        public  void  CreateTable<T>()
        {
            db.CreateTable<T>();            
        }      
    }
}
