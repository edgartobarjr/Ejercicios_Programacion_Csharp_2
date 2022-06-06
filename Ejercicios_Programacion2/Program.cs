using System;

namespace Ejercicios_Programacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu Programa
            Menu:
            Console.Clear();
            Console.WriteLine("Examen de Programacion\n" + "\nA continuacion se muestra un listado de los ejercicios, para comprobarlos escribe el numero correlativo de cada uno\n");
            Console.WriteLine("1er. Ingresar Alumnos y determinar si son aprobados o reprobados.");
            Console.WriteLine("2do. Determinar el departamento segun su codigo postal.");
            Console.WriteLine("3er. Determinar si un numero es primo");
            Console.WriteLine("4ta. Mostrar si una palabra es Polindromo.");
            Console.WriteLine("5ta. Hacer una suma con una matriz de numeros Aleatorios.");
            Console.WriteLine("6ta. Salir.");

            Console.WriteLine("\nDigite la Opcion del Ejercicio: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.Clear();
                    Alumnos_Aprob_Reprob apr = new Alumnos_Aprob_Reprob();
                    apr.Alumnos();
                    goto Menu;

                case 2:
                    Console.Clear();
                    Codigo_Postal cp = new Codigo_Postal();
                    cp.Codigopostal();
                    goto Menu;

                case 3:
                    Console.Clear();
                    Numeros_Primos np = new Numeros_Primos();
                    np.Numprimos();
                    goto Menu;

                case 4:
                    Console.Clear();
                    Polindromo p = new Polindromo();
                    p.polindromo();
                    goto Menu;

                case 5:
                    Console.Clear();
                    Sumar_Matriz_Aleatorio sma = new Sumar_Matriz_Aleatorio();
                    sma.Sumarmatriz();
                    goto Menu;

                case 6:
                    break;

                default:
                    goto Menu;
            }
        }
    }
}