
using Inclock.VO;
using Inclock.BL.Rest;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Inclock.BL.SqlLite;
using Newtonsoft.Json;

namespace Inclock.BL
{
    public class Login
    {
        public static async Task<Funcionario> Logar(string login, string senha)
        {            
            Client cliente = new Client();
            return await cliente.LogarAsync(login, senha);
        }
        public static bool CreateSession(Funcionario func)
        {
            SqlLite.DataBase db = new DataBase(DependencyService.Get<IConfig>().StringConnection);
            db.Connection.DropTable<SqlLite.User>();
            db.Connection.CreateTable<SqlLite.User>();
            var ln = db.Connection.Insert(new SqlLite.User { ID = func.Id, Nome = func.Nome, UserJson = JsonConvert.SerializeObject(func), DataCriacao = DateTime.Now.ToString("dd/MM/yyyy") });
            return ln > 0;
        }
        public static void RemoveSession()
        {
            using (SqlLite.DataBase db = new DataBase(DependencyService.Get<IConfig>().StringConnection))
            {
                using (var ctx = new  Client())
                {
                    var user = GetCurrentUser();
                    ctx.EncerrarSessao(user.ID);              
                    db.Connection.DropTable<SqlLite.User>();
                };               
            }
        }
        public static bool Autenticar()
        {
            using (var db = new DataBase(DependencyService.Get<IConfig>().StringConnection))
            {
                if (db.Connection.GetTableInfo(nameof(SqlLite.User)).Count > 0)
                {
                    return db.Connection.Table<SqlLite.User>().Any();
                }
                return false;
            }
        }
        public static SqlLite.User GetCurrentUser()
        {
            using (var db = new DataBase(DependencyService.Get<IConfig>().StringConnection))
            {
                return db.Connection.Table<SqlLite.User>().FirstOrDefault();
            }
        }

        public static Funcionario GetFuncionario()
        {
            SqlLite.User user = GetCurrentUser();
            return JsonConvert.DeserializeObject<Funcionario>(user.UserJson);
        }
    }
}
