int salario;
bool correcto;

do
{
    Console.WriteLine("Ingrese su salario");
    correcto = int.TryParse(Console.ReadLine(), out salario);
    if (!correcto)
    {
        Console.WriteLine("No es un valor numerico");
        correcto = false;
    }
    else if (salario < 0)
    {
        Console.WriteLine("El salario no puede ser negativo");
        correcto = false;
    }
} while (!correcto);
Console.WriteLine($"El salario ingresado es: {salario}");