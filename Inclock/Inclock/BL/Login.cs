
using Inclock.VO;
using Inclock.BL.Rest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Inclock.BL.Inteface;

namespace Inclock.BL
{
    public class Login
    {
        public static async Task<Funcionario> Logar(string login, string senha)
        {
            FeedBack feed;
            Client cliente = new Client();      
            return await cliente.LogarAsync(login, senha); 
        }
       
    }
}
