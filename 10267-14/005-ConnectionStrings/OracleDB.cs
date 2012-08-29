using System;
using System.Web.Configuration;

namespace _005_ConnectionStrings
{
    public class OracleDB
    {
        public String CS
        {
            get
            {
                return WebConfigurationManager.ConnectionStrings[WebConfigurationManager.AppSettings["CS"]].ConnectionString;
            }
        }

        //outros métodos e propriedades aqui
    }
}