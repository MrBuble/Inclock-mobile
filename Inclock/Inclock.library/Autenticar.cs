using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclock.library
{
   public class Autenticar
    {
        public static string Logar()
        {
            Autenticador.AutenticadorClient client = new Autenticador.AutenticadorClient();
            return client.Logar("","");
        }
    }
}
