using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases

{
    public class Calculadora
    {
        public static int Sumar(String input1, String input2) {
          int num1;
          int num2;
            int.TryParse(input1, out num1);
            int.TryParse(input2, out num2);
 
            return num1 + num2;
        }

        public static String ValidarInput(String input)
        {
              while (!int.TryParse(input, out int num))
              {
                  Console.WriteLine("El valor ingresado no es un numero, por favor ingrese un numero");
                  input = Console.ReadLine();
              }
           
            return input;
        }

        
    }
}
