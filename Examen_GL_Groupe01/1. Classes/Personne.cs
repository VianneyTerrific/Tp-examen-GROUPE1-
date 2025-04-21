using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_GL_Groupe01._1._Classes
{
    internal class Personne
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public char Sexe { get; set; }

        DataAccess data = new DataAccess();

        public int Enregistrer(Personne personne)
        {
            int resultat = 0;
            string strQuery = "sp_AjouterPersonne";

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", personne.Id);
                cmd.Parameters.AddWithValue("@nom", personne.Nom);
                cmd.Parameters.AddWithValue("@postnom", personne.Postnom);
                cmd.Parameters.AddWithValue("@prenom", personne.Prenom);
                cmd.Parameters.AddWithValue("@sexe", personne.Sexe);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }

            return resultat;
        }

        public int Modifier(Personne personne)
        {
            int resultat = 0;
            string strQuery = "sp_ModifierPersonne";

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", personne.Id);
                cmd.Parameters.AddWithValue("@nom", personne.Nom);
                cmd.Parameters.AddWithValue("@postnom", personne.Postnom);
                cmd.Parameters.AddWithValue("@prenom", personne.Prenom);
                cmd.Parameters.AddWithValue("@sexe", personne.Sexe);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }
            return resultat;
        }

        public int Supprimer(Personne personne)
        {
            int resultat = 0;
            string strQuery = "sp_SupprimerPersonne";

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", personne.Id);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }
            return resultat;
        }

        public int Supprimer2(Personne personne)
        {
            int resultat = 0;
            string strQuery = "delete from domicile where id_personne=@id_personne";

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                cmd.Parameters.AddWithValue("@id_personne", personne.Id);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }
            return resultat;
        }

        public int Supprimer3(Personne personne)
        {
            int resultat = 0;
            string strQuery = "delete from telephone where id_personne=@id_personne";

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                cmd.Parameters.AddWithValue("@id_personne", personne.Id);
                resultat = cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }
            return resultat;
        }

        public List<Personne> GetPersonne()
        {
            List<Personne> list = new List<Personne>();
            string strQuery = "sp_AfficherPersonne";
            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.connection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Personne personne = new Personne();
                    personne.Id = rd["id"].ToString();
                    personne.Nom = rd["nom"].ToString();
                    personne.Postnom = rd["postnom"].ToString();
                    personne.Prenom = rd["prenom"].ToString();
                    personne.Sexe = Convert.ToChar(rd["sexe"]);
                    list.Add(personne);
                }
                rd.Close();
                cmd.Dispose();
                data.CloseConnection();
            }
            return list;
        }
    }
}
