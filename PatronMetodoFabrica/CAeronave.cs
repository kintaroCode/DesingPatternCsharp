using System;
using System.Collections.Generic;
using System.Text;

namespace PatronMetodoFabrica
{
    class CAeronave:IVehiculo
    {
        public void Encender()
        {
            Console.WriteLine("El Avion es dificil de encender");
        }

        public void Frenar()
        {
            Console.WriteLine("usa los alerones de cola y ala");
        }

        public void Acelerar()
        {
            Console.WriteLine("pone a tope las turbinas");
        }

        public void Girar()
        {
            Console.WriteLine("solo sube o baja");
        }
    }
}
