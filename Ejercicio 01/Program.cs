int edad;
bool correcto;
do 
{
    Console.WriteLine("Ingrese su edad");
    correcto = int.TryParse(Console.ReadLine(), out edad);
    if (!correcto )
    {
        Console.WriteLine("No es un valor numerico");
        correcto = false;
    }
    else if (edad < 0 || edad > 110)
    {
        Console.WriteLine("La edad debe estar entre 0 y 110");
        correcto = false;
    }
}
while (!correcto || edad < 0 || edad > 110);