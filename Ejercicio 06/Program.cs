DateTime fecha;
bool correcta;
do
{
    Console.WriteLine("Ingrese una fecha");
    correcta = DateTime.TryParse(Console.ReadLine(), out fecha);
    if (!correcta)
    { Console.WriteLine("Fecha invalida"); }
}
while (!correcta);

Console.WriteLine($"La fecha ingresada es: {fecha.ToShortDateString()}"); //ejercicio 06