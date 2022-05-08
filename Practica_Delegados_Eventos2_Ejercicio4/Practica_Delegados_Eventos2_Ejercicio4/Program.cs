namespace Logica
{
    public class Program
    {
        public static void CambioPisoHandler (object? sender, Ascensor ascensor)
        {
            Console.WriteLine("----");
            Console.WriteLine($"{ascensor.PisoActual}");
        }
    }
    public class Ascensor
    {
        public int PisoActual { get; set; }
        public int PisoDestino { get; set; }
        public EventHandler<Ascensor> CambioPiso;

        public Ascensor() 
        {
            PisoActual = 0;
            PisoDestino = 0;
        }
        
        public void DefinirPiso(int pisoNuevo)
        {
            PisoDestino = pisoNuevo;
            if (PisoActual > PisoDestino)
            {
                while (PisoActual != PisoDestino)
                {
                    BajarPiso();
                    Thread.Sleep(1000);
                }
            }
            else
            {
                while (PisoActual != PisoDestino)
                {
                    SubirPiso();
                    Thread.Sleep(1000);
                }
            }
            if (this.CambioPiso != null)
            {
                this.CambioPiso(this, this);
            }
        }
        private void SubirPiso()
        {           
            if (this.CambioPiso != null)
            {
                this.CambioPiso(this, this);
            }
            PisoActual = PisoActual + 1;
        }
        private void BajarPiso()
        {          
            if (this.CambioPiso != null)
            {
                this.CambioPiso(this, this);
            }
            PisoActual = PisoActual - 1;
        }
        public void LlamarAscensor(int pisoLlamada)
        {
            DefinirPiso(pisoLlamada);
        }
    }
}