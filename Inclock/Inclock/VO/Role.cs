using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace Inclock.VO
{
    public class Role
    {
        public string Value { get; set; }
        public string Text { get; set; }

        /// <summary>
        /// Metodo que vai pegar as roles apartir de um Json
        /// </summary>
        /// <param name="PathRoles">Local de onde esta o arquvio</param>
        /// <returns></returns>
       /* public static List<Role> GetRoles(string PathRoles)
        {
            List<Role> RoleGroup = new List<Role>();
            try
            {               
                    RoleGroup = JsonConvert.DeserializeObject<List<Role>>(Common.UtilFile.FileStringReader(PathRoles));
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar o aquivo de roles",ex.InnerException);
            }
            return RoleGroup;
        }*/
    }


}
