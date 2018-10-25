
using Inclock.VO;
using Newtonsoft.Json;
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
    public class Client : IDisposable
    {
        public bool Disposed { get; private set; } = false;
        private const string URI = "http://inclock.gearhostpreview.com/Service.svc/rest/";
        private string Integracao { get; set; }
        public Client()
        {

        }
        public async Task<FeedBack> CheckPoint(int funcionario, char type)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent argumento = new StringContent(string.Concat("{funcionario:", 0, ",type:", type, "}"));
                argumento.Headers.Add("integracao", Integracao);
                HttpResponseMessage response = await client.PostAsync(URI + "CheckPoint", argumento);
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<FeedBack>(json);
            }
        }


        public List<Expediente> GetExpediente(string semana, string funcionario_Id)
        {
            throw new NotImplementedException();
        }

        public string GetLogin(string Email)
        {
            throw new NotImplementedException();
        }

        public string GetPassword(string Login)
        {
            throw new NotImplementedException();
        }


        public async Task<Funcionario> LogarAsync(string login, string senha)
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync(URI + "logar/" + senha + "/" + senha);
            return JsonConvert.DeserializeObject<Funcionario>(json);
        }
        public async Task<List<Aviso>> GetAvisos(int qtde, int index)
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync(URI + "getavisos/" + qtde + "/" + index);
            return JsonConvert.DeserializeObject<List<Aviso>>(json);
        }
        public void CriarIntegracao(string dados)
        {
            Integracao = Rijndael.Criptografar(dados).ToBase64();
        }
        public void Dispose()
        {
            if (!Disposed)
            {
                GC.SuppressFinalize(this);
                Disposed = true;
            }
        }

    }
}
