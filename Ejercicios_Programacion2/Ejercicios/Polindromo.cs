using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion2
{
    class Polindromo
    {
        public void polindromo()
        {
            string palabra, inverso, caracter;
            int i;
            Console.WriteLine("Palabra que desea invertir");
            palabra = Convert.ToString(Console.ReadLine());
            palabra = palabra.ToLower(); //Las coloca en minusculas
            palabra = palabra.Replace(" ", ""); //Reemplazar los espacios
            i = palabra.Length;
            inverso = "";

            for (int x = i - 1; x >= 0; x--) //Lee la palabra al inverso
            {
                caracter = palabra.Substring(x, 1);
                inverso = inverso + caracter;
            }
            Console.WriteLine("Inverso de la palabra: " + inverso);

            if (palabra == inverso) //Si palabra es igual a inverso es polindromo
            {
                Console.WriteLine("Es polindromo");
            }
            else
            {
                Console.WriteLine("No es polindromo");
            }
            Console.ReadKey();
        }
    }
}
