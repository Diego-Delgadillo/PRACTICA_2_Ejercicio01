//Ejercicio 01
/*
 Programa que permita obtener el perímetro y el área de ciertas figuras geométricas:
cuadrado, rectángulo, triángulo (de cualquier tipo), círculo, rombo, trapecio, polígono
regular. el programa debe utilizar Programación Orientada a Objetos en donde cada una de
las figuras será una clase que contenga los atributos necesarios para lograr el cálculo tanto
del área como del perímetro

*/

using System;

public class Program()
{
    public static void Main()
    {
        //declaramos las variables de control
        int opcion = 0;

        Console.WriteLine("Este programa permite obtner el área y perimetro\n");
        Console.WriteLine("Seleccione la figura a calcular:\n 1.Cuadrado\n 2.Rectángulo\n 3.Triángulo\n 4.Círculo\n 5.Rombo\n 6.Trapecio\n 7.Polígono regular\n");
        opcion = Convert.ToInt32(Console.ReadLine());

        
            switch (opcion)
            {
                case 1: Console.WriteLine("\nCUADRADO"); break;

                case 2 : Console.WriteLine("\nRECTÁNGULO"); break;

                case 3: Console.WriteLine("\nTRIÁNGULO"); break;

                case 4: Console.WriteLine("\nCÍRCULO"); break;

                case 5: Console.WriteLine("\nROMBO"); break;

                case 6: Console.WriteLine("\nTRAPECIO"); break;

                case 7: Console.WriteLine("\nPOLÍGONO REGULAR"); break;

                default: Console.WriteLine("Ingrese  una opción válida!"); Console.Beep(); break;
            }




        Console.ReadKey(true);

    }
}































