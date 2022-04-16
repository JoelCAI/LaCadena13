using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCadena13
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            string cadenaUno;
            string cadenaDos;

            Validador.Bienvenida();

            cadenaUno = Validador.ValidarString("\n Ingrese la primera frase");

            Console.Clear();
            cadenaDos = Validador.ValidarString("\n Ingrese la segunda frase");

            Console.Clear();
            Validador.MostrarString(cadenaUno);
            Console.Write(" Como primera frase\n");

            Validador.MostrarString(cadenaDos);
            Console.Write(" Como segunda frase\n");

            Validador.CompararLongitudString(cadenaUno, cadenaDos);

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}