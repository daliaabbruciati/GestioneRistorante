using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRistorante
{
    public class Cibo
    {
        // Attributi della classe
        protected bool isSelect;
        private int idCibo;
        protected string nomeCibo;
        protected float prezzoCibo;
        protected string tipologiaCibo;
        protected int vegetariano;


        public enum EnumVegetariano
        {
            Si,
            No
        }


        // Costruttore della classe
        public Cibo()
        {
        }


        // Costruttore della classe
        public Cibo(bool isSelect, int idCibo, string nomeCibo, float prezzoCibo, string tipologiaCibo, int vegetariano)
        {
            this.IsSelect = false;
            this.IdCibo = idCibo;
            this.NomeCibo = nomeCibo;
            this.PrezzoCibo = prezzoCibo;
            this.TipologiaCibo = tipologiaCibo;
            this.Vegetariano = vegetariano;
        }


        // Incapsulamento
        public bool IsSelect { get => isSelect; set => isSelect = value; }
        public int IdCibo { get => idCibo; set => idCibo = value; }
        public string NomeCibo { get => nomeCibo; set => nomeCibo = value; }
        public float PrezzoCibo { get => prezzoCibo; set => prezzoCibo = value; }
        public string TipologiaCibo { get => tipologiaCibo; set => tipologiaCibo = value; }
        public int Vegetariano { get => vegetariano; set => vegetariano = value; }
        
        public string DisplayVegetariano { get => Enum.GetName(typeof(EnumVegetariano),Vegetariano); }


        // Per fare la copia del cibo selezionato nella classe Ordine
        public void CopyTo(Cibo target)
        {
            target.IsSelect = IsSelect;
            target.IdCibo = IdCibo;
            target.NomeCibo = NomeCibo;
            target.PrezzoCibo = PrezzoCibo;
            target.TipologiaCibo = TipologiaCibo;
            target.Vegetariano = Vegetariano;
        }
    }
}
