using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto5
{
    class Program
    {
        static void Main(string[] args)
        {

           
            string respuesta;


            do
            {
                Console.WriteLine("Ingrese el nombre del alumno");
                string alumno = Console.ReadLine();

                Console.WriteLine("Edad");
                int edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Sexo");
                string sexo = Console.ReadLine();

                Console.WriteLine("Nota final");
                double NotaFinal = double.Parse(Console.ReadLine());

                if ((edad > 3 && edad < 100) && (sexo == "f" || sexo == "m" || sexo == "x") && (NotaFinal == 0 || NotaFinal > 10))
                {
                    //Me trabe aca y no se como sacar la cantidad de esto. Estoy en duda si debería haber usado arrays
                    if (sexo == "m" && NotaFinal > 6)
                    {
                        Console.WriteLine("La cantidad de varones aprobados son:");

                    }
                }
                Console.WriteLine("Si desea agregar más alumnos, escriba Si");
                respuesta = Console.ReadLine();
            } while (respuesta == "Si");








                Console.ReadKey();

            }
        }
    }
