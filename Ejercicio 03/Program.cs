int estudiantes;
bool correcto;

do
{
    Console.WriteLine("Ingrese la cantidad de estudiantes");
    correcto = int.TryParse(Console.ReadLine(), out estudiantes);
    if (!correcto)
    { Console.WriteLine("No es un valor numerico");
        correcto = false;
    }
    else if (estudiantes < 0)
    {
        Console.WriteLine("La cantidad de estudiantes no puede ser negativa");
        correcto = false;
    }
}
while (!correcto);
//ejercicio 3