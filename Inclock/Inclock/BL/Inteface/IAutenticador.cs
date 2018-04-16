using Inclock.VO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inclock.BL.Inteface
{
    public interface IAutenticador
    {
        /// <summary>
        /// Metodo que vai fazer o login do usuario
        /// </summary>
        /// <param name="password"></param>
        /// <param name="login"></param>
        /// <returns></returns>
        Task<Funcionario> LogarAsync(string password, string login);
        string GetLogin(string Email);
        string GetPassword(string Login);
        List<Ponto> GetCheckPointDateInterval(string InitialDate, string FinalDate, string id_funcionario);
        List<Ponto> GetCheckPointByDate(string InitialDate, string FinalDate, string id_funcionario);
        string GetCheckPointById(int id);
        Funcionario GetUserById(string id);
        FeedBack CheckPoint(Ponto ponto);
        List<Expediente> GetExpediente(string semana, string funcionario_Id);
    }
}
