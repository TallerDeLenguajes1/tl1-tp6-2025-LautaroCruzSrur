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
        int resultado = a + b;
        Console.WriteLine("El resultado de la suma es:" + resultado);

        break;
    case 2:

        break;
    case 3:

        break;
    case 4:

        break;
}
