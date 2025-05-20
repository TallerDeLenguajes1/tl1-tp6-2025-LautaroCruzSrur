// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola Bienvenido a la calculadora");
Console.Write("Ingrese la opcion que desea realizar: \n 1) Suma \n 2)Resta \n 3)Multiplicacion \n 4)Dividir\n");
int opciones = int.Parse(Console.ReadLine());

switch (opciones)
{
    case 1:
        Console.WriteLine("Ingrese un numero \n");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero\n");
        int b = int.Parse(Console.ReadLine());
        int resultadoSuma = a + b;
        Console.WriteLine("El resultado de la suma es:" + resultadoSuma);

        break;
    case 2:
        Console.WriteLine("Ingrese un numero \n");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero\n");
        int d = int.Parse(Console.ReadLine());
        int resultadoResta = c - d;
        Console.WriteLine("El resultado de la suma es:" + resultadoResta);
    
        break;
    case 3:
        Console.WriteLine("Ingrese un numero \n");
        int e = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero\n");
        int f = int.Parse(Console.ReadLine());
        int resultadoMultiplicacion = e * f;
        Console.WriteLine("El resultado de la suma es:" + resultadoMultiplicacion);
        break;
    case 4:
        Console.WriteLine("Ingrese un numero \n");
        int g = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un numero\n");
        int h = int.Parse(Console.ReadLine());
        int resultadoDivision = g / h;
        Console.WriteLine("El resultado de la suma es:" + resultadoDivision);
        break;
}
