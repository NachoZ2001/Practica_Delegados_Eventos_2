namespace Logica
{
    public class Program
    {
        public static void VelocidadMaximaSuperadaHandler(object? sender, AutoEventArgs auto)
        {
            Console.WriteLine($"Velocidad máxima de {auto.VelocidadMaximaSuperada} ha sido sobrepasada");
        }
    }
    public class Auto
    {
        public EventHandler<AutoEventArgs> VelocidadMaximaSuperada;
        private bool Encendido { get; set; }
        private int VelocidadActual { get; set; }
        private int VelocidadMaxima { get; set; }

        public Auto(){} 
        public Auto(int velocidadMaxima)
        {
            this.Encendido = false;
            this.VelocidadActual = 0;
            this.VelocidadMaxima = velocidadMaxima;
        }
        private bool Arrancar()
        {
            if (Encendido)
            {
                return false;
            }
            Encendido = true; 
            return true;
        }

        public void ModificarVelocidad(int nuevaVelocidad)
        {
            if (VelocidadActual == 0)
            {
                Arrancar();
            }
            if (nuevaVelocidad > VelocidadActual)
            {
                SubirVelocidad(nuevaVelocidad);               
            }
            if (nuevaVelocidad < VelocidadActual)
            {
                BajarVelocidad(nuevaVelocidad);
            }
            if (nuevaVelocidad == 0)
            {
                Encendido = false;
            }
        }

        private void SubirVelocidad(int nuevaVelocidad)
        {
            VelocidadActual = nuevaVelocidad;
            if (VelocidadActual > VelocidadMaxima)
            {
                if (this.VelocidadMaximaSuperada != null)
                {
                    this.VelocidadMaximaSuperada(this, new AutoEventArgs { VelocidadMaximaSuperada = VelocidadMaxima });
                }
            }
        }
        private void BajarVelocidad(int nuevaVelocidad)
        {
            VelocidadActual = nuevaVelocidad;
        }
    }
    public class AutoEventArgs : EventArgs
    {
        public int VelocidadMaximaSuperada { get; set; }
    }
}