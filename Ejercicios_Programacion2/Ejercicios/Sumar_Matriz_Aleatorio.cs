using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion2
{
    class Sumar_Matriz_Aleatorio
    {
        //Sumar una matriz de numeros aleatorios
        public void Sumarmatriz()
        {
            int[,] numeros = new int[10, 8]; //Esta Matriz tiene 10 filas 8 columnas
            Random r = new Random(); //Funcion que imprime numeros random

            for (int i = 0; i < 10; i++) //Primer bucle termina cuando la fila sea menor a 10
            {
                for (int j = 0; j < 8; j++) //Segundo bucle termina cuando la columna sea menor a 8
                {
                    numeros[i, j] = r.Next(0, 10); //Limite de que los numeros sean de 0 a 10
                    Console.Write(numeros[i, j] + "  "); //Imprime en consola los datos de i y de j
                }
                Console.WriteLine();
            }

            //Realizar la suma de las filas
            int[] resultado = new int[10];
            for (int a = 0; a < 8; a++) //Primero el bucle para las calumnas
            {
                resultado[a] = 0;

                for (int b = 0; b < 10; b++) //Segundo el bucle para las filas
                {
                    resultado[a] += numeros[b, a];
                }
                Console.Write(resultado[a] + " ");
            }
            Console.ReadKey();
        }
    }
}
