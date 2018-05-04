
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
    public class Client : Inteface.IAutenticador
    {

        private const string URI = "http://inclock.gearhostpreview.com/Service.svc/rest/";

        public Client()
        {


        }

        public async Task<FeedBack> CheckPoint(Ponto ponto)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent argumento = new StringContent(JsonConvert.SerializeObject(ponto));
                HttpResponseMessage response = await client.PostAsync(URI + "CheckPoint", argumento);
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<FeedBack>(json);
            }
        }

        public List<Ponto> GetCheckPointByDate(string InitialDate, string FinalDate, string id_funcionario)
        {
            throw new NotImplementedException();
        }

        public string GetCheckPointById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ponto> GetCheckPointDateInterval(string InitialDate, string FinalDate, string id_funcionario)
        {
            throw new NotImplementedException();
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

        public Funcionario GetUserById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Funcionario> LogarAsync(string login, string senha)
        {
            HttpClient client = new HttpClient();
            var json = await client.GetStringAsync(URI + "logar/" + senha + "/" + senha);
            return JsonConvert.DeserializeObject<Funcionario>(json);
        }
    }
}
