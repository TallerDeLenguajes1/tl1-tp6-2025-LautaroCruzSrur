// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido \n Ingrese un numero para invertir");
string s = Console.ReadLine();
int n = 0, invertido = 0, aux = 0;

bool resultado = int.TryParse(s, out n);

if (resultado)
{
    while (n > 0)
    {
        aux = n % 10;
        invertido = invertido * 10 + aux;
        n /= 10;
    }
    
    Console.WriteLine("El numero invertido es :" + invertido);
}
else
{
    Console.WriteLine("\n Esto no es un numero");
}
