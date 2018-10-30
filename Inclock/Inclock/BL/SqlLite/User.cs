using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Inclock.VO;
using SQLite;

namespace Inclock.BL.SqlLite
{
    [Table("User")]
    public class User
    {
        public User()
        {

        }

        public int ID { get; set; }

        public string Nome { get; set; }

        public string UserJson { get; set; }

        public string DataCriacao { get; set; }

        public static Funcionario ToUser(User user)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Funcionario>(user.UserJson);
        }
    }
}
