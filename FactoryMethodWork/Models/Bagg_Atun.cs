using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodWork.Models
{
    public class Bagg_Atun : IComida
    {
        private string Carne = "Atun";
        private string Catsup = "Catsup Azul";
        private string Salsa = "Sala Roma";

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
