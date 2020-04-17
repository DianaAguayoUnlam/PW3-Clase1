using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Condicionales
{
    class Ejercicio_6_y_7_Condicionales
    {
        public static void Ejecutar()
        {
            //6) ¿Cuál es la diferencia entre la sentencia for y foreach? Cuándo se debe utilizar cada una de ellas?
            /*Respuesta:
             * La diferencia entre un ciclo for y el foreach es que es que el foreach
              simplifica el ciclo, es mas cómodo en cuanto a sintaxis  y su lectura es sencilla y clara.
             Ademas nos permite agregar metodos de extencion
             El ciclo for en cambio, añade un poco mas de complejidad
             y hay más posibilidad de equivocarte en algún parámetro.
             El uso de for es más razonable para hacer un número dado de interaciones,
             mientras que forEach es para recorrer colleciones.La ventaja de for es que es bastante rápido
             en comparación al forEach(aunque este no es lento)
             */

            //7) Defina una variable a que en cada ciclo de una sentencia while incremente su valor en 5.
            //Cuando la variable a exceda el valor de 50, el ciclo while debe finalizar
            Console.WriteLine("7) Defina una variable a que en cada ciclo de una sentencia while incremente su valor en 5.Cuando la variable a exceda el valor de 50, el ciclo while debe finalizar");
            int a = 0;
            while (a <= 50)
            {
                Console.WriteLine(a);
                a += 5;

            }
            Console.ReadKey();


        }

    }
}
