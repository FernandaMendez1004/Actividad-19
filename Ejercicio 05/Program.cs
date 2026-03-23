int numero;
bool correcto;
do
{
    Console.WriteLine("Ingrese un numero");
    correcto = int.TryParse(Console.ReadLine(), out  numero);

    if (!correcto)
    {         Console.WriteLine("No es un valor numerico");
        correcto = false;
    }
    else if (numero < 0)
    {
        Console.WriteLine("El numero no puede ser negativo");
        correcto = false;

    }
}
while (!correcto);

if  (numero % 2 == 0)
{
    Console.WriteLine("El numero es par");
}
else
{
    Console.WriteLine("El numero es impar");
} //ejercicio 5