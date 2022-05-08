Logica.Ascensor ascensor = new Logica.Ascensor();
ascensor.CambioPiso += Logica.Program.CambioPisoHandler;
Console.WriteLine("Introduzca el piso de destino");
int pisoDestino = int.Parse(Console.ReadLine());
while (pisoDestino > 0)
{
    ascensor.DefinirPiso(pisoDestino);
    Console.Clear();
    Console.WriteLine("Introduzca el piso de destino");
    pisoDestino = int.Parse(Console.ReadLine());
}

