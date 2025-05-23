// See https://aka.ms/new-console-template for more information
bool vuelta = true;
Console.WriteLine("Hola Bienvenido a la calculadora");
while (vuelta)
{
    Console.Write("\nIngrese la opcion que desea realizar: \n 1) Suma \n 2)Resta \n 3)Multiplicacion \n 4)Dividir\n");
int opciones = 0;
bool resultado = int.TryParse(Console.ReadLine(), out opciones);
Console.WriteLine("Ingrese dos números:");

Console.Write("Primer número: ");
bool validoA = int.TryParse(Console.ReadLine(), out int a);

Console.Write("Segundo número: ");
bool validoB = int.TryParse(Console.ReadLine(), out int b);

if (resultado && validoA && validoB)
{
        switch (opciones)
        {
            case 1:
                int resultadoSuma = a + b;
                Console.WriteLine("El resultado de la suma es:" + resultadoSuma);
                break;
            case 2:
                int resultadoResta = a - b;
                Console.WriteLine("El resultado de la suma es:" + resultadoResta);
                break;
            case 3:
                int resultadoMultiplicacion = a * b;
                Console.WriteLine("El resultado de la suma es:" + resultadoMultiplicacion);
                break;
            case 4:
                int resultadoDivision = a / b;
                Console.WriteLine("El resultado de la suma es:" + resultadoDivision);
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



