using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2_del_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crear un programa que pida el nombre de un dia de la semana e identifique si es fin de semana o no. En caso de error, indicarlo  */

            string diasm;
            Console.WriteLine("Escribe un dia de la semana");
            diasm = Console.ReadLine();

            switch (diasm)
            {

                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("No es fin de semana");
                    break;
                case "sabado":
                case "domingo":
                    Console.WriteLine("Es fin de semana");
                    break;

                default:
                    Console.WriteLine("No se encuentra el dia solicitado");
                    break;
            }


            Console.Read();
        }
    }
}
