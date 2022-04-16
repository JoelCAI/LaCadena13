using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCadena13
{
    public class Validador
    {
        public static void CompararLongitudString(string str1, string str2)
        {

            int longitudUno = str1.Length;

            int longitudDos = str2.Length;

            if (longitudUno == longitudDos)
            {
                Console.WriteLine("\n La cadena" + " *" + str1 + "*" + " SI tiene la misma longitud que la cadena " + "*" + str2 + "*");
            }
            else
            {

                Console.WriteLine("\n La cadena" + " *" + str1 + "*" + " NO tiene la misma longitud que la cadena " + "*" + str2 + "*");
            }


        }


        public static void MostrarString(string cadena)
        {

            Console.WriteLine("\n Usted escribio " + "*" + cadena + "*");

        }


        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }

        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
        }

        public static string ValidarString(string mensaje)
        {

            string opcion;
            do
            {

                Console.WriteLine(mensaje);
                opcion = Console.ReadLine();
                if (string.IsNullOrEmpty(opcion))
                {
                    Console.Clear();
                    Console.WriteLine(" \nEl valor ingresado no puede ser vacio.");
                    Console.WriteLine(" Por favor ingrese un valor.");
                }
            } while (string.IsNullOrEmpty(opcion));
            return opcion;

        }
    }
}