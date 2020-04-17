using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Generalidades
{
    public class Funcion
    {
        public static void Ejecutar() {
            String input1, input2, opcion;
            int num1, num2, resultado;
            do
            {
                Console.WriteLine("\n* GENERALIDADES. \n Seleccione el ejercicio que desea probar (1,2,3)");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        do
                        {
                            Console.WriteLine("Ejercicio 1) Suma de dos numeros ");
                            Console.WriteLine("Ingrese el primer numero: ");
                            input1 = Console.ReadLine();
                        } while (!int.TryParse(input1, out num1));

                        do
                        {
                            Console.WriteLine("Ingrese el segundo numero: ");
                            input2 = Console.ReadLine();
                        } while (!int.TryParse(input2, out num2));
                        resultado = Funcion.Sumar(num1, num2);
                        Console.WriteLine("La suma es {0}", resultado);
                        break;

                    case "2":
                        Console.WriteLine("Ejercicio 2) Cadena de 8 caracteres cortada de izquierda a derecha en 4 caracteres");
                        String cadena;
                        do
                        {
                            Console.WriteLine("Ingrese una cadena de 8 caracteres");
                            cadena = Console.ReadLine();
                        } while (cadena.Length != 8);
                        Console.WriteLine("Los primeros 4 caracteres son: " + Funcion.mostrarPrimerosCuatroCaracteres(cadena));
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Ejercicio 3) Mostrar la fecha y hora actual");
                        Console.WriteLine(Funcion.mostrarFechaHoraActual());
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta");
                        Console.ReadKey();
                        break;
                }
                Console.WriteLine("Desea Continuar? s=si - n=no");
            } while (Console.ReadLine() != "n");
            
        }
        // 1)Crear una función que devuelva la suma de dos números recibidos por parámetros
        public static int Sumar(int num1, int num2)
        {
            int result = num1 + num2;
            return result;

        }

        //2)Crear una función que reciba una cadena de 8 caracteres y retorne en el mismo parámetro la cadena 
        public static String mostrarPrimerosCuatroCaracteres(String cadena)
        {
            cadena = cadena.Substring(0, 4);
            return cadena;
        }

        //3)Crear una función que devuelva la fecha y hora actual
        public static DateTime mostrarFechaHoraActual()
        {
            return DateTime.Now;
        }
        //4)Escribir un comentario con //

        /*5)Escribir un comentario con /*    */

    }
}
