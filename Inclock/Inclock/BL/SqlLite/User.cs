using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;
namespace Inclock.BL.SqlLite
{
    [Table("user")]
    class User
    {
        private readonly DataBase Data = new DataBase();
        public User()
        {

        }
    }
}
