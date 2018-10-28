using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Inclock.BL.SqlLite
{

    public class User
    {
        public User()
        {

        }

        public int ID { get; set; }

        public string Nome { get; set; }

        public string UserJson { get; set; }

        public string DataCriacao { get; set; }

    }
}
