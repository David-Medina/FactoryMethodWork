using System;
using FactoryMethodWork.Creador;
using FactoryMethodWork.Models;

namespace FactoryMethodWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = Menu();
            if(resultado == -1)
            {
                Console.WriteLine("Opcion no valida ");
                return;
            }
            Constructor Comida = null;

            switch (resultado)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Escoge hamburguesa");
                    Console.WriteLine("1. Hamburguesa Carne ");
                    Console.WriteLine("2. Hamburguesa Queso");
                    Console.WriteLine("3. Hamburguesa Vegetariana");
                    var l = Console.ReadLine();
                    var num = int.Parse(l);
                    switch (num)
                    {
                        case 1:
                            Comida = new ConstructorHamCarne();
                            break;
                        case 2:
                            Comida = new ConstrutorHamQueso();
                            break;
                        case 3:
                            Comida = new ConstrutorHamVege();
                            break;
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Escoge Baggette");
                    Console.WriteLine("1. Baggette Atun ");
                    Console.WriteLine("2. Baggette Jamon");
                    Console.WriteLine("3. Baggette Pepperoni");
                    var b = Console.ReadLine();
                    var num2 = int.Parse(b);
                    switch (num2)
                    {
                        case 1:
                            Comida = new ConstructorBaggAtun();
                            break;
                        case 2:
                            Comida = new ConstructorBaggJamon();
                            break;
                        case 3:
                            Comida = new ConstructorBaggPeppe();
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Intentelo de nuevo");
                    break;
            }
            var ComidaHecha = Comida.ComerComida();
            Console.WriteLine($"Ingredientes: {ComidaHecha.PonerIngredientes()}");
            Console.WriteLine($"Catsup: {ComidaHecha.PonerCatsup()}");
            Console.WriteLine($"Salsa: {ComidaHecha.PonerSalsa()}");
            
        }
        public static int Menu()
        {
            Console.Clear();
            Console.WriteLine("Selecciona una Comida");
            Console.WriteLine("1. Hamburguesa");
            Console.WriteLine("2. Bagguete");

            var x = Console.ReadLine();

            try
            {
                var num = int.Parse(x);
                if(num >=1 && num <= 2)
                {
                    return num;
                }
                return -1;
            }
            catch
            {
                return -1;
            }
 
        }
    }

}
