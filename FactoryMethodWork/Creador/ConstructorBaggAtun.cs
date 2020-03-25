using FactoryMethodWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodWork.Creador
{
    public class ConstructorBaggAtun : Constructor
    {
        public ConstructorBaggAtun()
        {
        }
        public override IComida ComerComida()
        {
            return new Bagg_Atun();
        }
    }
}
