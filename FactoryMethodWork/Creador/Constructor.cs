using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodWork.Models;

namespace FactoryMethodWork.Creador
{
    public abstract class Constructor
    {
        public abstract IComida ComerComida();
    }
}
