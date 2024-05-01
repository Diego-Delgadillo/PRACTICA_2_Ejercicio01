//Ejercicio 01
/*
 Programa que permita obtener el perímetro y el área de ciertas figuras geométricas:
cuadrado, rectángulo, triángulo (de cualquier tipo), círculo, rombo, trapecio, polígono
regular. el programa debe utilizar Programación Orientada a Objetos en donde cada una de
las figuras será una clase que contenga los atributos necesarios para lograr el cálculo tanto
del área como del perímetro

*/

using System;
using System.Diagnostics.CodeAnalysis;

public class cuadrado//declaramos la clase para el cuadrado
{
    //atributos de la clase
    public double lado; 

    public double ingresarDatos()
    {
        double lado; string c; bool num;
        

        do
        {
            Console.WriteLine("Ingrese el valor del lado: ");
            c = Console.ReadLine();
            num = double.TryParse(c, out lado);
            
        } while (!num || lado < 0);
        
        lado = Convert.ToDouble(c);
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
        double base_rect; string c; bool num;
        do
        {
            Console.WriteLine("Ingrese el valor de la base: ");
            c = Console.ReadLine(); 
            num = double.TryParse(c, out base_rect);
        } while (!num || base_rect <= 0);
        base_rect = Convert.ToDouble(c);
         return base_rect;
    }

    public double ingresarAltura() //para ingresar la altura del rectangulo
    {
        double altura_rect; string c; bool num;
        do
        {
            Console.WriteLine("Ingrese el valor de la altura: ");
            c = Console.ReadLine();
            num = double.TryParse(c, out altura_rect);
        } while (!num || altura_rect <= 0);
        altura_rect = Convert.ToDouble(c);
        return altura_rect;
    }

    //metodo para calcular area y perimetro
    public void calcular(double base_rect, double altura_rect)
    {
        double area; double perimetro;
        area = (base_rect * altura_rect);
        perimetro = (base_rect*2) + (altura_rect*2);
        Console.WriteLine("\nEl área del rectángulo es: {0:N2}", area);
        Console.WriteLine("El perímetro del rectángulo es: {0:N2}\n", perimetro);
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
        double lado1; string c; bool num;
        do
        {
            Console.WriteLine("Ingrese el valor del primer lado (BASE): ");
            c = Console.ReadLine();
            num = double.TryParse(c, out lado1);
        } while (!num || lado1 <= 0);
        lado1 = Convert.ToDouble(c); //convierte la cadea a un double
        return lado1;
    }

    public double ingresarLado2()
    {
        double lado2; string c; bool num;
        do
        {
            Console.WriteLine("Ingrese el valor del segundo lado: ");
            c = Console.ReadLine();
            num = double.TryParse(c, out lado2);
        } while (!num || lado2 <= 0);
        lado2 = Convert.ToDouble(c); //convierte la cadea a un double
        return lado2;
    }

    public double ingresarLado3()
    {
        double lado3; string c; bool num;
        do
        {
            Console.WriteLine("Ingrese el valor del tercer lado: ");
            c = Console.ReadLine();
            num = double.TryParse(c, out lado3);
        } while (!num || lado3 <= 0);
        lado3 = Convert.ToDouble(c); //convierte la cadea a un double
        return lado3;
    }

    public double ingresarAltura_tr()
    {
        double altura_tr; string c; bool num;
        do
        {
            Console.WriteLine("Ingrese el valor de la altura: ");
            c = Console.ReadLine();
            num = double.TryParse(c, out altura_tr);
        } while (!num || altura_tr <= 0);
        altura_tr = Convert.ToDouble(c);
        return altura_tr;
    }

    //metodo para calcular el area y perimetro con los atributos previamente capturados
    public void calcular(double lado1, double lado2, double lado3, double base_tr, double altura_tr)
    { //declaramos las variables a utilizar
        double area; double perimetro;
        area = ((lado1 * altura_tr) / 2);
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
        double radio; string c; bool num;
        do
        {
            Console.WriteLine("Ingrese el valor del radio: ");
            c = Console.ReadLine();
            num = double.TryParse(c, out radio);
        } while (!num || radio <= 0);
        
        radio = Convert.ToDouble(c);
        return radio;
    }

    public void calcular(double radio)
    {
        double area; double perimetro;
        area = (Math.PI * radio);
        perimetro = ((2*radio) * (Math.PI));
        Console.WriteLine("\nEl área del círculo es: {0:N2}", area);
        Console.WriteLine("El perímetro del círculo es: {0:N2}\n", perimetro);
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
        double diagonalMayor; string c; bool num;
        do
        {
            Console.WriteLine("Ingrese el valor de la diagonal mayor: ");
            c = Console.ReadLine();
            num = double.TryParse(c, out diagonalMayor);
        } while (!num || diagonalMayor <= 0);
        
        diagonalMayor = Convert.ToDouble(c);
        return diagonalMayor;
    }

    public double ingresarDiagonalMenor()
    {
        double diagonalMenor; string c; bool num;
        do
        {
            Console.WriteLine("Ingrese el valor de la diagonal menor: ");
            c = Console.ReadLine(); 
            num = double.TryParse(c, out diagonalMenor);
        } while (!num || diagonalMenor <= 0);
        
        diagonalMenor = Convert.ToDouble(c);
        return diagonalMenor;
    }

    public void calcular(double baseMayor, double baseMenor)
    {
        double area; double perimetro; double cateto;
        area = ((baseMayor * baseMenor) / 2);
        cateto = Math.Sqrt(Math.Pow((diagonalMayor / 2),2) + Math.Pow((diagonalMenor / 2),2));
        perimetro = cateto * 4.0;
        Console.WriteLine("\nEl área del rombo es: {0:N2}", area);
        Console.WriteLine("El perimetro del rombo es : {0:N2}\n", perimetro);
        Console.Beep();
    }
}

public class trapecio
{//declaramos los atributos de la clase
    public double baseMayor; public double baseMenor; public double altura;
    
    //metodos de la clase
    public double ingresarBaseMayor()
    {
        double baseMayor; string c; bool num;
        do
        {
            Console.WriteLine("Ingrese el valor de la base mayor: ");
            c = Console.ReadLine();
            num = double.TryParse(c, out baseMayor);
        } while (!num || baseMayor <= 0);
        baseMayor = Convert.ToDouble(c);
        return baseMayor;
    }

    public double ingresarBaseMenor()
    {
        double baseMenor; string c; bool num;
        do
        {
            Console.WriteLine("Ingrese el valor de la base menor: ");
            c = Console.ReadLine();
            num = double.TryParse(c, out baseMenor);
        } while (!num || baseMenor <= 0);
        baseMenor = Convert.ToDouble(c);
        return baseMenor;
    }

    public double ingresarAltura()
    {
        double altura; string c; bool num;
        do
        {
            Console.WriteLine("Ingrese el valor de la altura: ");
            c = Console.ReadLine();
            num = double.TryParse(c, out altura);
        } while (!num || altura <= 0);
        
         altura = Convert.ToDouble(c);
        return altura;
    }

    public void calcular(double baseMayor, double baseMenor, double altura)
    {
        double area; double perimetro;
        area = (((baseMayor + baseMenor)/2)*altura);
        perimetro = (baseMayor + baseMenor + (2*Math.Sqrt(Math.Pow(baseMayor, 2) + Math.Pow(baseMenor, 2))));
        Console.WriteLine("\nEl área del trapecio es: {0:N2}", area);
        Console.WriteLine("El perimetro del trapecio es: {0:N2}\n", perimetro);
        Console.Beep();
    }
}

public class poligonoRegular
{//declaramos los atributos de la clase
    public double lado; public int nlados;

    //creamos los metodos para ingresar datos y calcular área y perímetro
    public double ingresarLado()
    {
        double lado; string c; bool num;
        do
        {
            Console.WriteLine("Ingrese el valor de la longitud del lado: ");
            c = Console.ReadLine();
            num = double.TryParse(c, out lado);
        } while (!num || lado <= 0);
        lado = Convert.ToDouble(c);
        return lado;
    }

    public int ingresarNLados()
    {
        int nlados; string c; bool num;
        do // este ciclo es para que solo acepte numeros mayores o iguales a 3
        {
            Console.WriteLine("Ingrese el número de lados del poligono: ");
            c = Console.ReadLine();
            num = int.TryParse(c, out nlados);
            
        } while (!num || nlados <= 3);
        nlados = Convert.ToInt32(c);
        return nlados;
    }

    public void calcular(double lado, int nlados)
    {
        double area; double perimetro; double angulo; double apotema;
        angulo = (360/(2.0*nlados));
        angulo = ((angulo * Math.PI)/180);
        apotema = lado/(2.0 * Math.Tan(angulo)); // este resultado es en radianes por lo que lo pasamos a grados
        perimetro = (lado * nlados);
        area = perimetro * apotema;
        Console.WriteLine("\nEl área del polígono regular de {0} lados es: {1:N2}", nlados, area);
        Console.WriteLine("El perímetro del polígono regular de {0} lados es: {1:N2}\n", nlados,perimetro);
        Console.Beep();
    }
}


//clase principal del programa
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
            uint n; // variable para que solo ingrese numero
            bool opcionMenu; string c; bool num;

           // ciclo que evalúa si es un numero dentro del rango
         do
            {   
                Console.WriteLine("Para continuar ingrese (1), para salir ingrese (0): ");
                c =Console.ReadLine();
                num = uint.TryParse(c, out n);
            } while ((n > 1) || (n < 0) || !num);

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
                    cuadrado cuadrado1 = new cuadrado(); //creamos obejto
                    cuadrado1.lado = cuadrado1.ingresarDatos();
                    cuadrado1.calcular




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
                    trapecio trapecioUsuario = new trapecio();
                    trapecioUsuario.baseMayor = trapecioUsuario.ingresarBaseMayor();
                    trapecioUsuario.baseMenor = trapecioUsuario.ingresarBaseMenor();
                    trapecioUsuario.altura = trapecioUsuario.ingresarAltura();
                    trapecioUsuario.calcular(trapecioUsuario.baseMayor, trapecioUsuario.baseMenor, trapecioUsuario.altura);
                    opcionMenu = continuar(); break;

                case 7: Console.WriteLine("\nPOLÍGONO REGULAR");
                    poligonoRegular poligonoUsuario = new poligonoRegular();
                    poligonoUsuario.lado = poligonoUsuario.ingresarLado();
                    poligonoUsuario.nlados = poligonoUsuario.ingresarNLados();
                    poligonoUsuario.calcular(poligonoUsuario.lado, poligonoUsuario.nlados);
                    opcionMenu = continuar(); break;

                default: Console.WriteLine("Ingrese  una opción válida!"); Console.Beep(); break;
            }
        }
        Console.WriteLine("\n!Programa terminado!");
        Console.WriteLine("\nPresione cualquier tecla para salir :D");
        Console.Beep();
        Console.ReadKey(true);
    }
}
