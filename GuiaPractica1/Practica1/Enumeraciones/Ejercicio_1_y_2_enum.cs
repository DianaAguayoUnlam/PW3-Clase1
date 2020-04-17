using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Enumeraciones
{
    public class Ejercicio_1_y_2_enum
    {
        public static void Ejecutar()
        {
            Console.WriteLine("\n* ENUMERACIONES \n");
            Console.WriteLine("1) Crear una enumeración con los días de la semana, comenzando por Domingo con valor 1");
            foreach (var valor in Enum.GetValues(typeof(Dias)))
            {
                Console.WriteLine("{0,5}    {1,5} ", (int)valor, ((Dias)valor));
            }

            Console.WriteLine("\n 2) Agregar a la enumeración la posibilidad de Imprimir un Texto por cada día de la semana");
            foreach (Dias dia in Enum.GetValues(typeof(Dias)))
            {
                Console.WriteLine("{0,5}    {1}     {2}", (int)dia, ((Dias)dia), (textos)(int)dia);
            }
            Console.ReadKey();
        }

        public enum Dias
        {

            Domingo = 1,
            Lunes = 2,
            Martes = 3,
            Miercoles = 4,
            Jueves = 5,
            Viernes = 6,
            Sabado = 7

        }

        public enum textos // para mostrar un texto en ingles por cada dia de la semana
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
        }
    }
}

