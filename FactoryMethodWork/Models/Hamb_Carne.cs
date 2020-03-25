using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodWork.Models 
{
    public class Hamb_Carne : IComida
    {
        private string Carne = "Carne Res";
        private string Catsup = "Catsup Roja";
        private string Salsa = "Salsa Verde";
       
        public string PonerCatsup()
        {
            return Catsup;
        }
        public string PonerIngredientes()
        {
            return Carne;
        }
        public string PonerSalsa()
        {
            return Salsa;
        }
    }
}
