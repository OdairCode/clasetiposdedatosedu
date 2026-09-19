using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasetiposdedatosedu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipos de datos en C# Eduardo López
            int? num1 = null;

            int num2;
            float flotante = 3.14f;
            string cadena = "Hola, mundo!";
            char caracter = 'A';
            Boolean booleano = true;
            bool boleano2 = true;

            var variable = "cadena"; // tipo de dato inferido

            dynamic dinamica = 30; // tipo de dato dinámico
            dinamica = "Hola mundo !";
            dinamica = 3.14;
            dinamica = true;

            string nombre = "Eduardo";
            Console.WriteLine("Yo me llamo: " + nombre);

            string apellido;
            Console.WriteLine("Ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine("Su nombre completo es: " + nombre + " " + apellido);
            Console.WriteLine($"Su nombre completo es: {nombre} {apellido}");

            Console.WriteLine("Su nombre completo es: {0} {1}", nombre, apellido);

            byte edad;
            Console.WriteLine("Ingrese su edad: ");
            edad = byte.Parse(Console.ReadLine());
            Console.WriteLine("Su nombre es: " + nombre + " " + apellido + " y su edad es: " + edad);

            float salario;
            Console.WriteLine("Ingrese su salario: ");
            salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Su salario es: " + salario);

            Console.WriteLine("Digite un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"El número mayor es: {num1}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"El número mayor es: {num2}");
            }
            else
            {
                Console.WriteLine($"El número {num1} es igual a {num2}");
            }

            // Operaciones aritméticas
            float resultado = (num1.Value + num2);
            Console.WriteLine("La suma es: {0}", resultado);

            resultado = (num1.Value - num2);
            Console.WriteLine("la resta es: {0}", num1 - num2);
            Console.WriteLine("multiplicacion: {0}", num1 * num2);
            Console.WriteLine("LA division es: {0}", (float)num1 / num2);
        }
    }
}
