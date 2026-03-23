bool correcto;
int nota;
do
{
    Console.WriteLine("Ingrese una nota");
    correcto = int.TryParse(Console.ReadLine(), out nota);

    if (!correcto)
    {
        Console.WriteLine("No es valor numerico");
    }
    else if (nota < 0 || nota > 100)
    {
        Console.WriteLine("La nota debe estar entre 0 y 10");
        correcto = false;
    }
}
while (!correcto);

if (nota <=61)
{ Console.WriteLine("Reprobo"); }
else if (nota <100)
{ Console.WriteLine("Aprobo"); }
//ej 09