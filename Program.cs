// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Calculadora miCalculadora = new Calculadora();
miCalculadora.Limpiar();
Console.WriteLine("Menu de la calculadora");
Console.WriteLine("Ingrese el numero correspondiente a la operacion: 1 suma, 2 resta, 3 multiplicacion, 4 division, 5 limpiar,  0 para salir");
string leer = Console.ReadLine();
float num = float.Parse(leer);
Console.WriteLine("num= {num}");
int numOpe=0;
do{
        switch (num)s
    {
        case 0: Console.WriteLine("Resultado: " + miCalculadora.Memoria);
                miCalculadora.Limpiar();
        break;
        case 1: Console.WriteLine("Ingrese el numero a sumar");
                numOpe=float.Parse(Console.ReadLine());
                miCalculadora.Sumar(numOpe);
        break;
        case 2: Console.WriteLine("Ingrese el numero a restar");
                numOpe=float.Parse(Console.ReadLine());
                miCalculadora.Restar(numOpe);
        break;
        case 3: Console.WriteLine("Ingrese el numero a multiplicar");
                numOpe=float.Parse(Console.ReadLine());
                miCalculadora.Multiplicar(numOpe);
        break;
        case 4: Console.WriteLine("Ingrese el numero a dividir");
                numOpe=float.Parse(Console.ReadLine());
                miCalculadora.Dividir(numOpe);
        break;
        case 5: Console.WriteLine("Limpiano...");
                miCalculadora.Limpiar();
        break;
        default: Console.WriteLine("Numero invalido");
        break;
    }
}while(num!= 0);

Console.WriteLine("Resultado: " + miCalculadora.Memoria);