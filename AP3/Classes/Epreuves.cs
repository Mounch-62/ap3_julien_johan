using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3.Classes
{
    public class Epreuve
    {
        private string nom_epreuve;
        private string statut_epreuve;
        private int coefficient;
        public Epreuve(string _nom_epreuve, string _statut_epreuve, int _coefficient)
        {
            nom_epreuve = _nom_epreuve;
            statut_epreuve = _statut_epreuve;
            coefficient = _coefficient;
        }

        public string getNomEpreuve()
        {
            return nom_epreuve;
        }

        public string getStatutEpreuve()
        {
            return statut_epreuve;
        }

        public int getCoefficient()
        {
            return coefficient;
        }

        public void setNomEpreuve(string _nom_epreuve)
        {
            nom_epreuve = _nom_epreuve;
        }

        public void setStatutEpreuve(string _statut_epreuve)
        {
            statut_epreuve = _statut_epreuve;
        }

        public void setCoefficient(int _coefficient)
        {
            coefficient = _coefficient;
        }

    }
}
