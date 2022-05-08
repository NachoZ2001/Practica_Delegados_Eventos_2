namespace Logica
{
    public class Program
    {
        public EventHandler<NumerosEventsArgs> NumeroMenorAlPromedio;

        public static Dictionary<int, int> NumerosRepetidos = new Dictionary<int, int>();
       
        public static void AlmacenarNumeros(object? sender, NumerosEventsArgs numero)
        {
            NumerosRepetidos.Add(numero.Numero, +1 );
        }

        public void GenerarNumeros()
        {
            Numero numero = new Numero(new Random().Next(0, 100));
            if (EsMenorAlPromedio(numero))
            {
                if (NumeroMenorAlPromedio != null)
                {
                    this.NumeroMenorAlPromedio(this, new NumerosEventsArgs { Numero = numero.ValorNumero });
                }
            }
            numero.AgregarNumeroLista();          
        }

        public bool EsMenorAlPromedio(Numero numero)
        {
            if (numero.ObtenerListaNumeros().Count != 0 )
            {
                return numero.ValorNumero <= numero.ObtenerListaNumeros().Average() ? true : false;
            }
            return false;
        }

    }
    public class Numero
    {
        public static List<int> ListaNumeros = new List<int>(); 
        public int ValorNumero { get; set; }

        public Numero() { }
        public Numero(int numero)
        {
            this.ValorNumero = numero;  
        }

        public List<int> ObtenerListaNumeros()
        {
            return ListaNumeros;
        }
        public void AgregarNumeroLista()
        {
            ListaNumeros.Append(this.ValorNumero);
        }
        
    }
    public class NumerosEventsArgs : EventArgs
    {
        public int Numero;
    }
}