using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1_del_parcial
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Pedir al usuario el precio de un producto y la forma de pagar(efectivo o tarjeta) si la forma de pago es mediante tarjeta, pedir el numero de tarjeta(12 digitos). Ojo, validar que el valor ingresado en el sea positivo.*/
            double precio, efec, tar, pag;

            Console.WriteLine("Digite el precio del producto a pagar");
            precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Diga que forma usted quiere pagar:");
            Console.WriteLine("Efectivo marque 1");
            Console.WriteLine("Tarjeta marque 2");
            pag = Convert.ToDouble(Console.ReadLine());

            if (pag == 1)
            {
                Console.WriteLine("Usted ha elegido el  pago en efectivo:");
                Console.WriteLine("Digite el monto");
                efec = Convert.ToDouble(Console.ReadLine());
                if (efec > 0)
                {
                    Console.WriteLine("El pago es positivo");
                }
                else { Console.WriteLine("El monto es negativo"); }
            }
            else if (pag == 2)
            {

                Console.WriteLine("Usted ha elegido el pago por tarjeta:");
                Console.WriteLine("Digite el numero de la tarjeta");
                tar = Convert.ToDouble(Console.ReadLine());


                if ((tar >= 100000000000) && (tar <= 199999999999))
                {
                    ;
                    Console.WriteLine("");


                }
                else
                {
                    Console.WriteLine("Faltan dígitos o digitó de más");
                }

            }
            else { Console.WriteLine("La opción que usted ingresó, no se encuentra disponible."); }

            Console.Read();
        }
    }
}
