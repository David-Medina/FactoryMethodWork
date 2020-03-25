using FactoryMethodWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodWork.Creador
{
    public class ConstructorBaggJamon : Constructor
    {
        public ConstructorBaggJamon()
        {
        }
        public override IComida ComerComida()
        {
            return new Bagg_Jamon();
        }

    }
}