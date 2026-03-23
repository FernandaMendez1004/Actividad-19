Console.WriteLine("Hello, World!");
double precio;
bool correcto;
do
{
    Console.WriteLine("Ingrese el precio");
    correcto = double.TryParse(Console.ReadLine(), out precio);
    if (!correcto)
    {
        Console.WriteLine("No es un valor numerico");
        correcto = false;
    }
    else if (precio < 0  )
    {
        Console.WriteLine("El precio no puede ser negativo");
        correcto = false;
    }
}
while (!correcto);