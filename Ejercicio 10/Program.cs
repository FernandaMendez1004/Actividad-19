int productos;
bool correcto;
string nproductos;


do
{
    Console.WriteLine("Ingrese la cantidad de productos:");
    correcto = int.TryParse(Console.ReadLine(), out productos);

    if (!correcto)
    {
        Console.WriteLine("Debe ser un valor numérico");
    }
    else if (productos <= 0)
    {
        Console.WriteLine("Debe ser un número entero positivo");
        correcto = false;
    }

} while (!correcto);


for (int i = 1; i <= productos; i++)
{
    Console.WriteLine($"Ingrese el nombre del producto ");
    nproductos = Console.ReadLine();
}
//ej 10