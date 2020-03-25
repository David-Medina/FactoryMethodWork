using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodWork.Models
{
    public class Hamb_Vege : IComida
    {
        private string Carne = "Carne Vegetariana";
        private string Catsup = "Catsup Roja";
        private string Salsa = "Salsa verde";

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
