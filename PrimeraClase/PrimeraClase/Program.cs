using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace PrimeraClase
{
    class Program
    {
        static void Main(string[] args)
        {
            String input1;
            String input2;
            Console.WriteLine("Aprendemos a sumar");
            Console.WriteLine("Presione 's' para salir");
            do
            {

                Console.WriteLine("Ingrese el primer numero");
                input1 = Console.ReadLine();
                input1 = Calculadora.ValidarInput(input1);


                Console.WriteLine("Ingrese el segundo numero");
                input2 = Console.ReadLine();
                input2 = Calculadora.ValidarInput(input2);

                int resultado = Calculadora.Sumar(input1, input2);
                Console.WriteLine("La suma es: {0}", resultado);
                Console.WriteLine("Desea continuar? s=si , n=no");

                //OTRAS FORMAS DE CONCATENAR STRINGS
                //Console.WriteLine(string.Concat("string.Concat: ", resultado, " ", "param2", " ", "param3"));

                //string.Format("La suma da: primero {0} el segundo {1}, ambos {0}-{1}", "PRIMERO", "SEGUNDO");

                //Console.WriteLine("string.Format: imagen-{0}.png", DateTime.Now.ToString());

                //Console.WriteLine($"INTERPOLATION: la suma da {resultado}");


            } while (Console.ReadLine() != "n") ;

        }
           
    }
 }
