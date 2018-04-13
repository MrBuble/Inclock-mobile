using System;
using System.Collections.Generic;
using System.Text;

namespace Inclock.BL.Rest
{
   public class Metodos
    {
        /// <summary>
        /// logar/{pwd}/{user}
        /// </summary>
        public const string LOGAR = "logar/{pwd}/{user}";
        public const string GETLOGIN = "GetLogin";
        /// <summary>
        /// GetPassword/{Login}
        /// </summary>
        public const string GETPASSWORD= "GetPassword/{Login}";
        public const string GETCHECKPOINTDATEINTERVAL= "GetCheckPointDateInterval";
        public const string GETCHECKPOINTBYDATE= "GetCheckPointByDate";
        public const string GETCHECKPOINTBYID= "GetCheckPointById";
        /// <summary>
        /// getuser/{id}
        /// </summary>
        public const string GETUSERBYID = "getuser/{id}";
        public const string CHECKPOINT = "CheckPoint";
        /// <summary>
        /// getexpediente/{semana}/{funcionario_Id
        /// </summary>
        public const string GETEXPEDIENTE = "getexpediente/{semana}/{funcionario_Id}"; 
    }
}
