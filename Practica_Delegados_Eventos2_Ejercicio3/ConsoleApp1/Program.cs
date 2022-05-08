Console.WriteLine("Ingrese la velocidad maxima del auto");
int velocidadMaxima = int.Parse(Console.ReadLine());    
Logica.Auto auto = new Logica.Auto(velocidadMaxima);
auto.VelocidadMaximaSuperada += Logica.Program.VelocidadMaximaSuperadaHandler;
Console.WriteLine("Inserte la velocidad");
int nuevaVelocidad = int.Parse(Console.ReadLine());
Console.Clear();
while (nuevaVelocidad >= 0)
{
    auto.ModificarVelocidad(nuevaVelocidad);
    Console.WriteLine("Inserte la velocidad");
    nuevaVelocidad = int.Parse(Console.ReadLine());
    Console.Clear();
}
if (nuevaVelocidad < 0)
{
    Console.WriteLine("Auto apagado");
}
