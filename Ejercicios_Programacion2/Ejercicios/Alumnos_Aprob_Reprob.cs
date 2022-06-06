using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_Programacion2
{
    class Alumnos_Aprob_Reprob
    {
        public void Alumnos()
        {
            //Preguntarle al usuario cuantos alumnos quiere ingresar, si el alumno tiene menos de 5 que diga reprobado 
            // y si es 5 a 10 aprobado

            int alumnos, nota;

            Console.WriteLine("Cuantos alumnos quiere ingresar?: ");
            alumnos = int.Parse(Console.ReadLine()); //Almacena el dato de alumnos que se desean ingresar

            for (int i = 1; i <= alumnos; i++) //El bucle se repetira dependiendo la cantidad de alumnos ingresados
            {
                do //Pedir que ingrese la nota
                {
                    Console.WriteLine("Ingrese la nota: ");
                    nota = int.Parse(Console.ReadLine());

                } while (nota < 0 || nota > 10); //Mientras nota este en un intervalo entre 0-10

                if (nota < 5) //Si nota es menor a 5
                {
                    Console.WriteLine("Alumno Reprobado\n"); //Alumno reprobado
                }
                else //lo contrario
                {
                    Console.WriteLine("Alumno Aprobado\n"); //Alunno aprobado
                }
            }
            Console.ReadKey();
        }
    }
}
