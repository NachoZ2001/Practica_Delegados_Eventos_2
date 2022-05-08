Logica.Program logica = new Logica.Program();
logica.ImprimirParrafo += Logica.Program.AlmacenarVocalesParrafo;
Console.WriteLine("Ingresar letra, (ESC = salida)");
string letra = Console.ReadLine();
while (letra.ToUpper() != "ESC" )
{
    logica.AlmacenarCaracteres(letra);
    Console.WriteLine("Ingresar letra, (ESC = salida)");
    letra = Console.ReadLine();
}
logica.ImprimirVocales();
Console.Read();
