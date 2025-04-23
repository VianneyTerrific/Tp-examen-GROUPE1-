using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSingleConnexion
{
    public class Connexion
    {
        public Connexion()
        {

        }

        string _serveur = "serveur";
        string _database = "database";
        string _user = "user";
        string _password = "password";
        int _port = 0;

        public string Serveur
        {
            get
            {
                return _serveur;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidOperationException("Veuillez spécifier un serveur valide !!!");
                else
                    _serveur = value;
            }
        }

        public string Database
        {
            get
            {
                return _database;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidOperationException("Veuillez spécifier une base de données valide !!!");
                else
                    _database = value;
            }
        }

        public string User
        {
            get
            {
                return _user;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidOperationException("Veuillez spécifier un nom d'utilisateur valide !!!");
                else
                    _user = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidOperationException("Veuillez spécifier un mot de passe valide !!!");
                else
                    _password = value;
            }
        }

        public int Port
        {
            get
            {
                return _port;
            }

            set
            {
                if (value <= 0)
                    throw new InvalidOperationException("Veuillez spécifier un numéro de port valide !!!");
                else
                    _port = value;
            }
        }
    }
}
