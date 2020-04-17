using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Condicionales
{
    public class Ejercicio_3_Condicionales
    {
        /*3) Escriba una sentencia switch utilizando una enumeración
        * con 3 colores (blanco, azul y negro) y para cada caso indicar
        * un mensaje de cual es el color informado.*/

        public enum Color
        {
            Blanco = 1,
            Azul = 2,
            Negro = 3
        }

        public static void Ejecutar()
        {
            Console.WriteLine(" \n * CONDICIONALES\n");
            Console.WriteLine("3) Escriba una sentencia switch utilizando una enumeración" +
         "con 3 colores(blanco, azul y negro) y para cada caso indicar"+
         "un mensaje de cual es el color informado.");

            int opcionNum;
            string input = "";
            do
            {
                Console.WriteLine("Ingrese un color (Blanco=1, Azul=2, Negro=3)");
                input = Console.ReadLine();
                int.TryParse(input, out opcionNum);

            } while (opcionNum < 1 | opcionNum > 3);

            Color color = (Color)opcionNum;
            switch (color)
            {
                case Color.Blanco:
                    Console.WriteLine($"Elegiste el color {color}");
                    break;
                case Color.Azul:
                    Console.WriteLine($"Elegiste el color {color}");
                    break;
                case Color.Negro:
                    Console.WriteLine($"Elegiste el color {color}");
                    break;
                default:
                    Console.WriteLine($"Opcion incorrecta");
                    break;
            }
            Console.ReadKey();
        }
    }
}

