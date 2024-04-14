//Ejercicio 01
/*
 Programa que permita obtener el perímetro y el área de ciertas figuras geométricas:
cuadrado, rectángulo, triángulo (de cualquier tipo), círculo, rombo, trapecio, polígono
regular. el programa debe utilizar Programación Orientada a Objetos en donde cada una de
las figuras será una clase que contenga los atributos necesarios para lograr el cálculo tanto
del área como del perímetro

*/

using System;

public class Program
{
    public static void Main()
    {
        //declaramos las variables de control
        int opcion; //variable para la opcion del switch
        string cadena; //varaible que usa el metodo tryparse y compara si es string
        bool num; 
        bool opcionMenu = true; //varaible para el menu del programa

       
        while (opcionMenu == true)
        {
            //inicia con un mensaje de lo que hace el programa
            Console.WriteLine("Este programa permite obtener el área y perímetro\n");


            //ciclo para almacenar solamente números 
            do
            {
                Console.WriteLine("Seleccione la figura a calcular:\n 1.Cuadrado\n 2.Rectángulo\n 3.Triángulo\n 4.Círculo\n 5.Rombo\n 6.Trapecio\n 7.Polígono regular\n");
                cadena = Console.ReadLine();
                num = int.TryParse(cadena, out opcion);
            }
            while (!num);


            opcion = Convert.ToInt32(cadena);

            switch (opcion)
            {
                case 1: Console.WriteLine("\nCUADRADO"); 
                    Console.WriteLine("Para continuar ingrese (1), para salir ingrese (0): ");
                    opcionMenu = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine())); //asigna el valor ya sea true or false
                    break;


                case 2: Console.WriteLine("\nRECTÁNGULO");
                    Console.WriteLine("Para continuar ingrese (1), para salir ingrese (0): ");
                    opcionMenu = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine())); //asigna el valor ya sea true or false
                    break;

                case 3: Console.WriteLine("\nTRIÁNGULO");
                    Console.WriteLine("Para continuar ingrese (1), para salir ingrese (0): ");
                    opcionMenu = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine())); //asigna el valor ya sea true or false
                    break;

                case 4: Console.WriteLine("\nCÍRCULO");
                    Console.WriteLine("Para continuar ingrese (1), para salir ingrese (0): ");
                    opcionMenu = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine())); //asigna el valor ya sea true or false
                    break;

                case 5: Console.WriteLine("\nROMBO");
                    Console.WriteLine("Para continuar ingrese (1), para salir ingrese (0): ");
                    opcionMenu = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine())); //asigna el valor ya sea true or false
                    break;

                case 6: Console.WriteLine("\nTRAPECIO");
                    Console.WriteLine("Para continuar ingrese (1), para salir ingrese (0): ");
                    opcionMenu = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine())); //asigna el valor ya sea true or false
                    break;

                case 7: Console.WriteLine("\nPOLÍGONO REGULAR");
                    Console.WriteLine("Para continuar ingrese (1), para salir ingrese (0): ");
                    opcionMenu = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine())); //asigna el valor ya sea true or false
                    break;

                default: Console.WriteLine("Ingrese  una opción válida!"); Console.Beep(); break;
            }
        }
        Console.WriteLine("\n!Programa terminado!");



       


        Console.ReadKey(true);

    }
}































