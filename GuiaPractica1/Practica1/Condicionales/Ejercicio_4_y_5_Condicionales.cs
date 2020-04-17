using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Condicionales
{
    class Ejercicio_4_y_5_Condicionales
    {
        public static void Ejecutar() {
            /*4) Si se tiene una variable entera a, realice una sentencia if
             *   para evaluar si la variable a es mayor a 10.
             *   Si es verdad, mostrar un mensaje indicando que el valor es mayor a 10. 
             */
            Console.WriteLine("4) Si se tiene una variable entera a, realice una sentencia if"+
             " para evaluar si la variable a es mayor a 10."+
             " Si es verdad, mostrar un mensaje indicando que el valor es mayor a 10. ");

            Console.WriteLine("5) Al ejercicio del punto 4), agregar la sentencia de else y,\n en ella, indicar un mensaje de error.");
            string input = "";
            int num = 0;
            do
            {
                Console.WriteLine("Ingrese un numero");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out num));

            if (num > 10)
            {
                Console.WriteLine("El valor es mayor a 10");

            }
            //5) Al ejercicio del punto 4), agregar la sentencia de else y, en ella, indicar un mensaje de error.
            else
            {
                Console.WriteLine("Error el numero no es mayor a 10");
            }
            Console.ReadKey();
        }
    }
}
