using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodWork.Models
{
    public interface IComida
    {
        string PonerIngredientes();
        string PonerCatsup();
        string PonerSalsa();
    }
}
