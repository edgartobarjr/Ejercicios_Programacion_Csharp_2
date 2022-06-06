using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion2
{
    class Codigo_Postal
    {
        //Determinar el departamento segun su codigo postal
        public void Codigopostal()
        {
            string CodigoP;

            Console.WriteLine("Ingrese un codigo postal");
            CodigoP = Console.ReadLine();

            char c = CodigoP[0];

            if (CodigoP.Length != 5) //Si Codigo Postal es diferente a 5
            {
                Console.WriteLine("Codigo Postal debe tener 5 digitos"); //Envia el mensaje que debe tener 5 digitos
            }
            else
            {
                Console.WriteLine("Codigo Postal Valido");

                Console.WriteLine("Primer Digito es: " + c);

                switch (c)
                {
                    case '0':
                    case '1':

                        Console.WriteLine("Jutiapa");
                        break;

                    case '2':
                        Console.WriteLine("Peten");
                        break;

                    case '3':
                        Console.WriteLine("Zacapa");
                        break;

                    case '4':
                    case '5':
                        Console.WriteLine("Cuidad Guatemala");
                        break;

                    default:
                        Console.WriteLine("Izabal");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
