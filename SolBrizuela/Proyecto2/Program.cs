using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] continente = new string[5]
            {
                "America",
                "Asia",
                "Europa",
                "Africa",
                "Oceania",
            };

            string[] MetodoPago = new string[6]
            {
                "Debito",
                "Credito",
                "Efectivo",
                "Mercado Pago",
                "Cheque",
                "Leliq",
            };

            

            Console.WriteLine("Ingrese a que continente le gustaría viajar");
            string ContinenteIngresado = Console.ReadLine();

            for (int i=0; i != continente.Length; ++i)
            {
                if (ContinenteIngresado == continente[i])
                {
                    Console.WriteLine("true");
                }
            };


            Console.WriteLine("Ingrese la cantidad de días");
            int dias = Int32.Parse (Console.ReadLine());
            int ValorOferta = dias * 100;
            
            
            Console.WriteLine("Ingrese el método de pago");
            string MetodoPIngresado = Console.ReadLine();

            for (int e = 0; e != MetodoPago.Length; ++e)
            {
                if (MetodoPIngresado == MetodoPago[e])
                {
                    Console.WriteLine("true");
                }
            };

            if (MetodoPIngresado == "Cheque")
            {
                double RecargoImp = (ValorOferta * 1.15);
                Console.WriteLine("Por su método de pago " + MetodoPIngresado + " tiene 15% de recargo de impuesto al cheque, el total es $" + RecargoImp);
            }
            else if ((ContinenteIngresado == "America") && (MetodoPIngresado == "Debito"))
            {
                double DescAmericaDeb = (ValorOferta - (ValorOferta * 0.25));
                Console.WriteLine("Por su destino a " + ContinenteIngresado + " tiene 15% de descuento y su método de pago " + MetodoPIngresado + " tiene 10% de descuento extra, el total es $" + DescAmericaDeb);
            }
            else if (ContinenteIngresado == "America")
            {
                double DescAmerica = (ValorOferta - (ValorOferta * 0.15));
                Console.WriteLine("Por su destino a " + ContinenteIngresado + " tiene 15% de descuento, el total es $" + DescAmerica);
            }
            else if (((ContinenteIngresado == "Africa") || (ContinenteIngresado == "Oceania")) && ((MetodoPIngresado == "Mercado Pago") || (MetodoPIngresado == "Efectivo")))
            {
                double DescAfrOceaPago = (ValorOferta - (ValorOferta * 0.45));
                Console.WriteLine("Por su destino a " + ContinenteIngresado + " tiene 30% de descuento y su método de pago " + MetodoPIngresado + " tiene 15% de descuento extra, el total es $" + DescAfrOceaPago);
            }
            else if ((ContinenteIngresado == "Africa") || (ContinenteIngresado == "Oceania"))
            {
                double DescAfrOcea = (ValorOferta - (ValorOferta * 0.30));
                Console.WriteLine("Por su destino a " + ContinenteIngresado + " tiene 30% de descuento, el total es $" + DescAfrOcea);
            }

            else if ((ContinenteIngresado == "Europa") && (MetodoPIngresado == "Mercado Pago"))
            {
                double DescEuroMP = (ValorOferta - (ValorOferta * 0.30));
                Console.WriteLine("Por su destino a " + ContinenteIngresado + " tiene 20% de descuento y su método de pago " + MetodoPIngresado + " tiene 10% de descuento extra, el total es $" + DescEuroMP);
            }
            else if ((ContinenteIngresado == "Europa") && (MetodoPIngresado == "Debito"))
            {
                double DescEuroDeb = (ValorOferta - (ValorOferta * 0.35));
                Console.WriteLine("Por su destino a " + ContinenteIngresado + " tiene 20% de descuento y su método de pago " + MetodoPIngresado + " tiene 15% de descuento extra, el total es $" + DescEuroDeb);
            }
            else if ((ContinenteIngresado == "Europa") && ((MetodoPIngresado != "Debito") || (MetodoPIngresado != "MercadoPago")))
            {
                double DescEuroOtro = (ValorOferta - (ValorOferta * 0.05));
                Console.WriteLine("Por su destino a " + ContinenteIngresado + " tiene 20% de descuento y su método de pago " + MetodoPIngresado + " tiene 5% de descuento extra, el total es $" + DescEuroOtro);
            }
            else if (ContinenteIngresado == "Asia")
            {
                double RecargoDest = (ValorOferta * 1.20);
                Console.WriteLine("Por su destino a " + ContinenteIngresado + " tiene 20% de recargo, el total es $" + RecargoDest);
            };


            Console.ReadKey();

        }
    }
}
