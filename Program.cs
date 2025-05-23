// See https://aka.ms/new-console-template for more information
bool vuelta = true;
Console.WriteLine("Hola Bienvenido a la calculadora");
while (vuelta)
{
    Console.Write("\nIngrese la opcion que desea realizar: \n 1)Valor Absoluto \n 2)Cuadrado \n 3)Raiz Cuadrada \n 4)Seno \n 5)Coseno \n 6) Parte entera de un tipo Float");
int opciones = 0;
bool resultado = int.TryParse(Console.ReadLine(), out opciones);
Console.WriteLine("Ingrese un números:");

Console.Write("Primer número: ");
bool validoA = double.TryParse(Console.ReadLine(), out double a);



if (resultado && validoA )
{
        switch (opciones)
        {
            case 1:
                Console.Write($"El valor absoluto de({a}) es {Math.Abs(a)}");
                break;
            case 2:
                Console.Write($"La Raiz cuadrada de({a}) es {Math.Pow(a,2)}");
                break;
            case 3:
                Console.Write($"El cuadrado de({a}) es {Math.Sqrt(a)}");
                break;
            case 4:
                Console.Write($"El Seno de({a}) es {Math.Asin(a)}");
                break;
            case 5:
                Console.Write($"El Coseno de({a}) es {Math.Acos(a)}");
                break;
            case 6:
                Console.Write($"La Parte entera  de({a}) es {Math.Floor(a)}");
                break;
        }
        Console.WriteLine("Desea Realizar otro calculo? Y/N");
        string bandera = Console.ReadLine();
        if (bandera == "N" || bandera == "n")
        {
            vuelta = false;
        }
    }else
{
    Console.WriteLine("Uno o ambos valores no son números válidos.");
}        
}



