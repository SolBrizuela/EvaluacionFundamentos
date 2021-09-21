using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int valorA = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            int valorB = Int32.Parse(Console.ReadLine());

            int valorSuma = valorA + valorB;
            int valorDivision = valorA / valorB;
            int valorResto = (valorA - (valorDivision * valorB));



            if (valorA == valorB)
            {
                Double valorElevado = Math.Pow(valorSuma, 2);
                Console.WriteLine(valorElevado);
            }
            else if (valorResto == 0)
            {
                Console.WriteLine(valorA - valorB);
            }
            else if (valorResto > 3)
            {
                
                Console.WriteLine("El resto es mayor que 3");
            }
            else
            {
                Console.WriteLine(valorResto);
            }



            Console.ReadKey();

        }
    }
}
