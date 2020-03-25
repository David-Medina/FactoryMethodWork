using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodWork.Models
{
    public class Bagg_Jamon : IComida
    {
        private string Carne = "Jamon";
        private string Catsup = "Catsup Verde";
        private string Salsa = "Salsa Mango";

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
