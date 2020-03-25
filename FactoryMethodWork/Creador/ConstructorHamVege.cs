using FactoryMethodWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodWork.Creador
{
    public class ConstrutorHamVege : Constructor
    {
        public ConstrutorHamVege()
        {
        }
        public override IComida ComerComida()
        {
            return new Hamb_Vege();
        }

    }
}
