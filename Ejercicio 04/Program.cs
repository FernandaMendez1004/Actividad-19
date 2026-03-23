Console.WriteLine("Hello, World!");
int year;
bool correcto;

do
{
    Console.WriteLine("Ingrese el año de su nacimiento");
    correcto = int.TryParse(Console.ReadLine(), out year);
    if (!correcto)
    {
        Console.WriteLine("No es un valor numerico");
    }
    else if (year < 1900 || year > 2026)
    {
        Console.WriteLine($"El año debe estar entre 1900 y {year}");
        correcto = false;
    }
}
while (!correcto);