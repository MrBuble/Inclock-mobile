
using Inclock.VO;
using Inclock.BL.Rest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inclock.BL
{
    public class Login
    {
        public static async Task<FeedBack> Logar(string login, string senha)
        {
            FeedBack feed;
            Client cliente = new Client();
            try
            {

                var func = await cliente.LogarAsync(login, senha);
                if (func.Id == 0)
                    feed = new FeedBack() { Status = false, Mensagem = "Login ou senha estão incorretos" };
                else
                    feed = new FeedBack() { Status = true };
            }
            catch (Exception ex)
            {
                feed = new FeedBack() { Status = false, Mensagem = ex.Message };
            }
            return feed;
        }
    }
}
