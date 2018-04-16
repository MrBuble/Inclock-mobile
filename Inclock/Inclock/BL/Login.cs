
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
        public static async Task<FeedBack> Logar(string login, string senha)
        {
            FeedBack feed;
            Client cliente = new Client();
            var func = await cliente.LogarAsync(login, senha);
            if (func.Id == 0)
                feed = new FeedBack() { Status = false, Mensagem = "Login ou senha estão incorretos" };
            else
                feed = new FeedBack() { Status = true };

            return feed;
        }
        /// <summary>
        /// não terminado
        /// </summary>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        public static FeedBack Entrar(string login, string senha)
        {
            FeedBack feed = new FeedBack() { Status = false };
            try
            {
                var funcionario = DependencyService.Get<IAutenticador>().Logar(login, senha);
                if (funcionario.Id == 0)
                    feed.Mensagem = "Login ou senha estão incorretos";
                else
                    feed.Status = true;
            }
            catch (Exception ex)
            {
                feed.Mensagem = ex.Message;
            }
            return feed;
        }
    }
}
