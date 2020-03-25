using FactoryMethodWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodWork.Creador
{
    public class ConstructorHamCarne : Constructor
    {
        public ConstructorHamCarne()
        {
        }

        public override IComida ComerComida()
        {
            return new Hamb_Carne();
        }

    }
}
