using FactoryMethodWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodWork.Creador
{
    public class ConstructorBaggPeppe : Constructor
    {
        public ConstructorBaggPeppe()
        {
        }
        public override IComida ComerComida()
        {
            return new Bagg_Peppe();
        }

    }
}