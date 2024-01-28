using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDepartement
{
    /// <summary>
    /// Classe Departement
    /// </summary>
    public class Departement
    {
        #region attributs
        private string numero;
        private string nom;
        private double superficie;  // en km2
        private double population;  // en milliers d'habitants
        private string region;
        #endregion

        #region constructeur
        /// <summary>
        /// Constructeur de la classe Departement
        /// </summary>
        /// <param name="unNumero">numéro du département</param>
        /// <param name="unNom">nom du département</param>
        /// <param name="uneSuperficie">superficie du département en km2</param>
        /// <param name="unePopulation">population du département en milliers d'habitants</param>
        /// <param name="uneRegion">région du département</param>
        public Departement(string unNumero, string unNom, double uneSuperficie, double unePopulation, string uneRegion)
        {
            this.numero = unNumero;
            this.nom = unNom;
            this.superficie = uneSuperficie;
            this.population = unePopulation;
            this.region = uneRegion;
        }
        #endregion
        
        #region méthodes
        /// <summary>
        /// Affiche le détail des informations du département
        /// </summary>
        public void Afficher()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", this.numero, this.nom, this.superficie, this.population, this.region);
        }

        /// <summary>
        /// Retourne la densité du département
        /// </summary>
        /// <returns>densité du département en nombre d'habitants / km2</returns>
        public double CalculerDensite()
        {
            double densite;
            densite = this.population * 1000 / this.superficie;
            return densite;
        }

        /// <summary>
        /// Retourne le numéro du département
        /// </summary>
        /// <returns>Numéro du département</returns>
        public string GetNumero()
        {
            return this.numero;
        }
        /// <summary>
        /// Retourne le nom du département
        /// </summary>
        /// <returns>Nom du département</returns>
        public string GetNom()
        {
            return this.nom;
        }
        /// <summary>
        /// Retourne le nom de la région du département
        /// </summary>
        /// <returns>Région du département</returns>
        public string GetRegion()
        {
            return this.region;
        }
        /// <summary>
        /// Retourne la superficie du département 
        /// </summary>
        /// <returns>Superficie du département en km2</returns>
        public double GetSuperficie()
        {
            return this.superficie;
        }
        /// <summary>
        /// Retourne la population du département 
        /// </summary>
        /// <returns>Population du département en milliers d'habitants </returns>
        public double GetPopulation()
        {
            return this.population;
        }

        /// <summary>
        /// Modifie le nom du département
        /// </summary>
        /// <param name="unNom">nom du département</param>
        public void SetNom(string unNom)
        {
            this.nom = unNom;
        }
        /// <summary>
        /// Modifie la région du département
        /// </summary>
        /// <param name="uneRegion">région du département</param>
        public void SetRegion(string uneRegion)
        {
            this.region = uneRegion;
        }
        /// <summary>
        /// Modifie la population du département
        /// </summary>
        /// <param name="unePopulation">population du département en milliers d'habitants</param>
        public void SetPopulation(double unePopulation)
        {
            this.population = unePopulation;
        } 
        #endregion

    }
}
