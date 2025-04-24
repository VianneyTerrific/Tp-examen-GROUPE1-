using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_GL_Groupe01._4._Connexion
{
    internal class DataAccess
    {
        static public DataAccess instance
        {
            get => new DataAccess();
        }

        public SqlConnection connection = null;
        string connectionString = "Data Source=BAHADOOR;Initial Catalog=gestion_personne;User ID=sa;Password=Espace2027;Encrypt=false";
        public bool OpenConnection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }

        public String generateId
        {
            get
            {
                Random rnd = new Random();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 10; i++)
                {
                    char lettre = (char)rnd.Next('a', 'z' + 1);
                    sb.Append(lettre);

                }
                string result = sb.ToString();
                return result;
            }
        }
    }
}
