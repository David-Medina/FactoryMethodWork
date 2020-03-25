using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodWork.Models
{
    public class Hamb_Queso : IComida
    {
        private string Carne = "Carne con Queso";
        private string Catsup = "Catsup Roja";
        private string Salsa = "Salsa de guacamole";
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
