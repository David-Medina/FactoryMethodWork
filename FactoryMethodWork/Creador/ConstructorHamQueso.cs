using FactoryMethodWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodWork.Creador
{
    public class ConstrutorHamQueso : Constructor
    {
        public ConstrutorHamQueso()
        {
        }
        public override IComida ComerComida()
        {
            return new Hamb_Queso();
        }

    }
}
