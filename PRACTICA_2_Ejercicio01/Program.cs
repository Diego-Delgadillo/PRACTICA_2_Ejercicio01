//Ejercicio 01
/*
 Programa que permita obtener el perímetro y el área de ciertas figuras geométricas:
cuadrado, rectángulo, triángulo (de cualquier tipo), círculo, rombo, trapecio, polígono
regular. el programa debe utilizar Programación Orientada a Objetos en donde cada una de
las figuras será una clase que contenga los atributos necesarios para lograr el cálculo tanto
del área como del perímetro

*/

using System;

public class cuadrado//declaramos la clase para el cuadrado
{
    //atributos de la clase
    public double lado; 

    public double ingresarDatos()
    {
        double lado; 
        Console.WriteLine("Ingrese el valor del lado: ");
        lado = Convert.ToDouble(Console.ReadLine()); 
        return lado;
    }
    //metodo para calcular el área y perímetro
    public void calcular(double lado)
    {
        double area = (lado*lado);
        double perimetro = (lado * 4);
        Console.WriteLine("\nEl área del cuadrado es: " + area + "\nEl perímetro del cuadrado es: " + perimetro+ "\n");
        Console.Beep();
    }
}

public class rectangulo //clase del rectangulo
{
    //atriubtos de la clase
    public double base_rect; public double altura_rect;

    //metodos de la clase
    public double ingresarBase() //para ingresar la base del rectangulo
    {
        Console.WriteLine("Ingrese el valor de la base: ");
        base_rect = Convert.ToDouble(Console.ReadLine());     
        return base_rect;
    }

    public double ingresarAltura() //para ingresar la altura del rectangulo
    {
        Console.WriteLine("Ingrese el valor de la altura: ");
        altura_rect = Convert.ToDouble(Console.ReadLine());
        return altura_rect;
    }

    //metodo para calcular area y perimetro
    public void calcular(double base_rect, double altura_rect)
    {
        double area; double perimetro;
        area = (base_rect * altura_rect);
        perimetro = (base_rect*2) + (altura_rect*2);
        Console.WriteLine("\nEl área del rectángulo es: {0:N2}", area);
        Console.WriteLine("El perimetro del rectángulo es: {0:N2}\n", perimetro);
        Console.Beep();
    }
}


public class triangulo //clase creada para el triangulo 
{
    //atributos de la clase
    public double lado1; public double lado2; public double lado3; public double base_tr; public double altura_tr;

    //metodos de la clase
    public double ingresarLado1()
    {
        double lado1;
        Console.WriteLine("Ingrese el valor del primer lado: ");
        lado1 = Convert.ToDouble(Console.ReadLine()); //convierte la cadea a un double
        return lado1;
    }

    public double ingresarLado2()
    {
        double lado2;
        Console.WriteLine("Ingrese el valor del segundo lado: ");
        lado2 = Convert.ToDouble(Console.ReadLine()); //convierte la cadea a un double
        return lado2;
    }

    public double ingresarLado3()
    {
        double lado3;
        Console.WriteLine("Ingrese el valor del tercer lado: ");
        lado3 = Convert.ToDouble(Console.ReadLine()); //convierte la cadea a un double
        return lado3;
    }

    public double ingresarBase_tr()
    {
        double base_tr;
        Console.WriteLine("Ingrese el valor de la base: ");
        base_tr = Convert.ToDouble(Console.ReadLine()); //convierte la cadea a un double
        return base_tr;
    }

    public double ingresarAltura_tr()
    {
        double altura_tr;
        Console.WriteLine("Ingrese el valor de la altura: ");
        altura_tr = Convert.ToDouble(Console.ReadLine()); //convierte la cadea a un double
        return altura_tr;
    }

    //metodo para calcular el area y perimetro con los atributos previamente capturados
    public void calcular(double lado1, double lado2, double lado3, double base_tr, double altura_tr)
    { //declaramos las variables a utilizar
        double area; double perimetro;
        area = (base_tr * altura_tr);
        perimetro = (lado1 + lado2 + lado3);
        Console.WriteLine("\nEl área del triángulo es: {0:N2}", area); //muestra el valor del area
        Console.WriteLine("El valor del perímetro es: {0:N2}\n", perimetro);
        Console.Beep();
    }
}


public class circulo //clase para la figura del circulo 
{//declaramos los atributos de la clase
    public double radio; 

    //metodos de la clase
    public double ingresarRadio()
    {
        double radio;
        Console.WriteLine("Ingrese el valor del radio: ");
        radio = Convert.ToDouble(Console.ReadLine());
        return radio;
    }

    public void calcular(double radio)
    {
        double area; double perimetro;
        area = (Math.PI * radio);
        perimetro = ((2*radio) * (Math.PI));
        Console.WriteLine("\nEl área del círculo es: {0:N2}", area);
        Console.WriteLine("El perímetro del círculo es; {0:N2}\n", perimetro);
        Console.Beep();
    }
}

public class rombo
{//declaramos los atributos de la clase 
    public double diagonalMayor;
    public double diagonalMenor;

    //creamos los metodos
    public double ingresarDiagonalMayor()
    {
        double diagonalMayor;
        Console.WriteLine("Ingrese el valor de la diagonal mayor: ");
        diagonalMayor = Convert.ToDouble(Console.ReadLine());
        return diagonalMayor;
    }

    public double ingresarDiagonalMenor()
    {
        double diagonalMenor;
        Console.WriteLine("Ingrese el valor de la diagonal menor: ");
        diagonalMenor = Convert.ToDouble(Console.ReadLine());
        return diagonalMenor;
    }

    public void calcular(double baseMayor, double baseMenor)
    {
        double area; double perimetro; double cateto;
        area = ((baseMayor * baseMenor) / 2);
        cateto = Math.Sqrt(Math.Pow((diagonalMayor / 2),2) + Math.Pow((diagonalMenor / 2),2));
        Console.WriteLine(cateto);
        perimetro = cateto * 4.0;
        Console.WriteLine("\nEl área del rombo es: {0:N2}", area);
        Console.WriteLine("El perimetro del rombo es : {0:N2}\n", perimetro);
        Console.Beep();
    }
}



public class Program
{
    public static void Main()
    {
        //declaramos las variables de control
        int opcion; //variable para la opcion del switch
        string cadena; //varaible que usa el metodo tryparse y compara si es string
        bool num; //variable para evaluar si la funcion de tryparse es falso o verdadero
        bool opcionMenu = true; //varaible para el menu del programa

        //funcion que sirve para indicar si continua o finaliza el programa
        bool continuar()
        {
            int n; // variable para que solo ingrese numero
            bool opcionMenu;

           // ciclo que evalúa si es un numero dentro del rango
         do
            {
                Console.WriteLine("Para continuar ingrese (1), para salir ingrese (0): ");
                n = Convert.ToInt32(Console.ReadLine()); //asigna el valor ya sea true or false
            } while ((n != 1) && (n != 0));


            opcionMenu = Convert.ToBoolean(n);
            return opcionMenu;
        }

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
                    cuadrado cuadradoUsuario = new cuadrado();
                    cuadradoUsuario.lado = cuadradoUsuario.ingresarDatos();
                    cuadradoUsuario.calcular(cuadradoUsuario.lado);
                    opcionMenu = continuar();
                    break;

                case 2: Console.WriteLine("\nRECTÁNGULO");
                    rectangulo rectanguloUsuario = new rectangulo();
                    rectanguloUsuario.base_rect = rectanguloUsuario.ingresarBase();
                    rectanguloUsuario.altura_rect = rectanguloUsuario.ingresarAltura();
                    rectanguloUsuario.calcular(rectanguloUsuario.base_rect, rectanguloUsuario.altura_rect);
                    opcionMenu = continuar();break;

                case 3: Console.WriteLine("\nTRIÁNGULO");
                    triangulo trianguloUsuario = new triangulo();
                    trianguloUsuario.lado1 = trianguloUsuario.ingresarLado1();
                    trianguloUsuario.lado2 = trianguloUsuario.ingresarLado2();
                    trianguloUsuario.lado3 = trianguloUsuario.ingresarLado3();
                    trianguloUsuario.base_tr = trianguloUsuario.ingresarBase_tr();
                    trianguloUsuario.altura_tr = trianguloUsuario.ingresarAltura_tr();
                    trianguloUsuario.calcular(trianguloUsuario.lado1, trianguloUsuario.lado2, trianguloUsuario.lado3, trianguloUsuario.base_tr, trianguloUsuario.altura_tr);
                    opcionMenu = continuar(); break;

                case 4: Console.WriteLine("\nCÍRCULO");
                    circulo circuloUsuario = new circulo();
                    circuloUsuario.radio = circuloUsuario.ingresarRadio();
                    circuloUsuario.calcular(circuloUsuario.radio);
                    opcionMenu = continuar(); break;

                case 5: Console.WriteLine("\nROMBO");
                    rombo romboUsuario = new rombo();
                    romboUsuario.diagonalMayor = romboUsuario.ingresarDiagonalMayor();
                    romboUsuario.diagonalMenor = romboUsuario.ingresarDiagonalMenor();
                    romboUsuario.calcular(romboUsuario.diagonalMayor, romboUsuario.diagonalMenor);
                    opcionMenu = continuar(); break;

                case 6: Console.WriteLine("\nTRAPECIO");
                    opcionMenu = continuar(); break;

                case 7: Console.WriteLine("\nPOLÍGONO REGULAR");
                    opcionMenu = continuar(); break;

                default: Console.WriteLine("Ingrese  una opción válida!"); Console.Beep(); break;
            }
        }
        Console.WriteLine("\n!Programa terminado!");
        Console.Beep();
        Console.ReadKey(true);
    }
}



