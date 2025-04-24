using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSingleConnexion
{
    public class ImplementeConnexion : IConnexion
    {
        private ImplementeConnexion()
        {
        }

        private IDbConnection _conn = null;
        private static ImplementeConnexion _instance = null;

        public IDbConnection Conn
        {
            get
            {
                return _conn;
            }

            set
            {
                _conn = value;
            }
        }

        public static ImplementeConnexion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ImplementeConnexion();
                return _instance;
            }
        }

        public IDbConnection Initialise(Connexion connexion, ConnexionType connexionType)
        {
            switch (connexionType)
            {
                case ConnexionType.SQLServer:
                    _conn = new SqlConnection(string.Format("Data source={0};Initial catalog={1};User ID={2};Password={3}",
                        connexion.Serveur, connexion.Database, connexion.User, connexion.Password));
                    break;
                case ConnexionType.Oracle:
                    return null;
                case ConnexionType.Access:
                    return null;
            }
            return _conn;
        }
    }
}
