using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodWork.Models
{
    public class Bagg_Peppe : IComida
    {
        private string Carne = "Pepperoni";
        private string Catsup = "Catsup Roja";
        private string Salsa = "Salsa chipotle";

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
