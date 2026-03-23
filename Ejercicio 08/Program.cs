Console.WriteLine("Hello, World!");

double numero;
bool correcto;
double raiz;

do
{
    Console.WriteLine("Ingrese un numero");
    correcto = double.TryParse(Console.ReadLine(), out numero);

    if (!correcto)
    {
        Console.WriteLine("No es un valor numerico");
    }
    else if (numero < 0)
    {
        Console.WriteLine("El numero no puede ser negativo");
        correcto = false; // aquí sí tiene sentido
    }

} while (!correcto);

raiz = Math.Sqrt(numero);
Console.WriteLine($"La raiz cuadrada es {raiz}");