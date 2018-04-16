
using Inclock.VO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Inclock.BL.Rest
{
    /// <summary>
    /// 
    /// </summary>
    public class Client : Metodos
    {

        private const string URI = "http://inclock.gearhostpreview.com/Service.svc/";

        public Client()
        {


        }

        public async Task<Funcionario> LogarAsync(string login, string senha)
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync(URI + "logar/" + senha + "/" + senha);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Funcionario>(json);
        }
    }
}
