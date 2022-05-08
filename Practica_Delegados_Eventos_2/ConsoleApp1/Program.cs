Logica.Program logica = new Logica.Program();
logica.NumeroMenorAlPromedio += Logica.Program.AlmacenarNumeros;
int cont = 0;
while (cont != 5)
{
    cont++;
    logica.GenerarNumeros();
}
Console.Read();

