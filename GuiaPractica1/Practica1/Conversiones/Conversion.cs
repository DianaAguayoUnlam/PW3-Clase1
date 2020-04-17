using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Conversiones
{
    class Conversion
    {
        public static void Ejecutar() {
            /* 1) Realizar la conversión de true, false, 1 y 0 utilizando los métodos
           * Convert., bool.Parse y bool.TryParse. Explique cómo responde en cada caso
           * cada uno de los métodos indicados. */
            Console.WriteLine("\n *CONVERSIONES: \n");

            Console.WriteLine(" Metodo *Convert*: \n" +
                  " -Permite convertir de tipo boolean a int y viceversa." +
                    "Teniendo en cuenta que true=1 y false=0 \n " +
                    "-No recibe parametros de tipo string");


            Console.WriteLine(Convert.ToInt32(true));
            Console.WriteLine(Convert.ToBoolean(1)); // Convierte el valor int en un valor booleano equivalente

            Console.WriteLine(Convert.ToInt32(false));
            Console.WriteLine(Convert.ToBoolean(0));

            Console.WriteLine("\n Metodo *Parse*\n" +
                " -Recibe como parametro solamente valores de tipo string. " +
                " \n - Convierte la cadena en su valor booleano equivalente." +
                " \n -Si no logra la conversion, lanza una excepcion");
            try
            {
                bool.Parse("1");  //Lanza una excepcion FormatException porque considera que es un int
            }
            catch (Exception e)
            {

                Console.WriteLine("Excepcion de tipo: {0}.  {1} ", e.GetType(), e.Message);
                //throw;
            }
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("false"));


            Console.WriteLine("\n Metodo *TryParse*" +
                "\n - Si la conversion se realizo, devuelve true, sino false" +
                "\n - El valor convertido se almacena en la variable declarada en el segundo parametro" +
                "\n - No lanza excepcion");
            bool result;
            Console.WriteLine(bool.TryParse("false", out result));
            Console.WriteLine(result);

            Console.WriteLine(bool.TryParse("true", out result));
            Console.WriteLine(result);

            Console.WriteLine(bool.TryParse("1", out result));
            Console.WriteLine(result);
            Console.ReadKey();

            //2) Explique que sucede en los siguientes intentos de casteos de datos.
            Console.WriteLine($" 2) Explique que sucede en los siguientes intentos de casteos de datos." +

                "\n a) int a = (int)344.4;" +

                "\n b) decimal a = 10;" +

                "\n c) int a=443444;" +

                "\n d) short b = (short)a;");


            int a = (int)344.4;
            decimal b = 10;
            int c = 443444;
            short d = (short)c;

            Console.WriteLine($"\n Respuestas: \n a) La variable \"a\" toma solamente la parte entera" +
                $" y no la parte decimal a={a}");

            Console.WriteLine($"\n b) El tipo decimal permite almacenar un numero entero" +
                $" ya que su parte decimal se encuentra de forma implicita a={b}");

            Console.WriteLine($"\n c) Se guarda el valor sin problema porque el tipo int soporta hasta 32 bits a={c} ");

            Console.WriteLine($"\n d) La variable tipo short no puede almacenar un dato mayor a 16 bits a={d} ");

            Console.ReadKey();
        }
    }
}
