using System.Collections.Generic;

namespace Inclock.VO
{
    public class User
    {
        public string Nome { get; set; }

        private string login;
        /// <summary>
        /// Encapsulamento do login
        /// </summary>
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        private string senha;
        //Encapsulamento da senha 
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        private List<string> roles = new List<string>();
        public List<string> Roles
        {
            get
            {
                return roles;
            }
            set
            {
                roles = value;
            }
        }
    }
}
