using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AP3.Classes
{
    class Eleves
    {
        private string prenom;
        private string nom;
        private string promo;
        public Eleves(string _prenom, string _nom, string _promo)
        {
            prenom = _prenom;
            nom = _nom;
            promo = _promo;
        }

        public string getPrenom()
        {
            return prenom;
        }
        public string getNom()
        {
            return nom;
        }

        public string getPromo()
        {
            return promo;
        }

        public void setPrenom(string _prenom)
        {
            prenom = _prenom;
        }
        public void setNom(string _nom)
        {
            nom = _nom;
        }

        public void setPromo(string _promo)
        {
            promo = _promo;
        }

    }

}
