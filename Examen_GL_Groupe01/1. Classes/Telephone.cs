using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen_GL_Groupe01._4._Connexion;

namespace Examen_GL_Groupe01._1._Classes
{
    internal class Telephone
    {
        public string Id { get; set; }
        public string IdPersonne { get; set; }
        public string Noms { get; set; }
        public string Initial { get; set; }
        public string Numero { get; set; }

        DataAccess data = new DataAccess();

        public int Enregistrer(Telephone telephone)
        {
            int resultat = 0;
            string strQuery = "sp_AjouterTelephone";

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", telephone.Id);
                cmd.Parameters.AddWithValue("@id_personne", telephone.IdPersonne);
                cmd.Parameters.AddWithValue("@initial", telephone.Initial);
                cmd.Parameters.AddWithValue("@numero", telephone.Numero);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }

            return resultat;
        }

        public int Modifier(Telephone telephone)
        {
            int resultat = 0;
            string strQuery = "sp_ModifierTelephone";

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", telephone.Id);
                cmd.Parameters.AddWithValue("@id_personne", telephone.IdPersonne);
                cmd.Parameters.AddWithValue("@initial", telephone.Initial);
                cmd.Parameters.AddWithValue("@numero", telephone.Numero);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }
            return resultat;
        }

        public int Supprimer(Telephone telephone)
        {
            int resultat = 0;
            string strQuery = "sp_SupprimerTelephone";

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", telephone.Id);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }
            return resultat;
        }

        public List<Telephone> GetTelephone()
        {
            List<Telephone> list = new List<Telephone>();
            string strQuery = "exec sp_AfficherTelephone";
            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Telephone telephone = new Telephone();
                    telephone.Id = rd["id"].ToString();
                    telephone.IdPersonne = rd["id_personne"].ToString();
                    telephone.Noms = rd["noms"].ToString();
                    telephone.Initial = rd["initial"].ToString();
                    telephone.Numero = rd["numero"].ToString();
                    list.Add(telephone);
                }
                rd.Close();
                cmd.Dispose();
                data.CloseConnection();
            }
            return list;
        }
    }
}
