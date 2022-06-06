using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion2
{
    class Numeros_Primos
    {
        //Mostrar numeros primos
        public void Numprimos()
        {
            //un número primo es un número natural mayor que 1 que tiene únicamente dos divisores positivos distintos: él mismo y el 1.​​
            int numero = 0, c = 0;
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0) //numero ingresado su residuo de 1 debe dar 0
                    {
                        c++;
                    }
                }
                if (c == 2)
                {
                    Console.WriteLine("El numero es primo");
                }
                else
                {
                    Console.WriteLine("El numero no es primo");
                }
            }
            Console.ReadKey();
        }
    }
}
