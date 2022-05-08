namespace Logica
{
    public class Program
    {
        public static List<string> Letras { get; set; }

        public EventHandler<LetraVocalEspacioEventArgs> ImprimirParrafo;

        public void AlmacenarCaracteres(string letra)
        {
            
            if (letra.ToUpper() == "A" || letra.ToUpper() == "E" || letra.ToUpper() == "I" || letra.ToUpper() == "O" || letra.ToUpper() == "U" || letra.ToUpper() == " ")
            {
                if (this.ImprimirParrafo != null)
                {
                    this.ImprimirParrafo(this, new LetraVocalEspacioEventArgs { VocalOEspacio = letra });
                }
            }
        }

        public static void AlmacenarVocalesParrafo(object? sender, LetraVocalEspacioEventArgs letras)
        {
            if (Letras == null)
            {
                Letras = new List<string>();
            }
            Letras.Add(letras.VocalOEspacio);
        }

        public void ImprimirVocales()
        {
            string parrafoSoloVocalesEspacio = "";
            foreach (string letra in Letras)
            {
                parrafoSoloVocalesEspacio = parrafoSoloVocalesEspacio + letra;
            }
            Console.WriteLine($"El paraffo con solo vocales es {parrafoSoloVocalesEspacio}");
        }
    }
    public class LetraVocalEspacioEventArgs : EventArgs
    {
        public string VocalOEspacio{ get; set; }
    }
}