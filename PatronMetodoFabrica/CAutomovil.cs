using System;
using System.Collections.Generic;
using System.Text;

namespace PatronMetodoFabrica
{
    class CAutomovil:IVehiculo
    {
        public void Encender()
        {
            Console.WriteLine("girar llave de encendido y mas moderno boton.");
        }

        public void Frenar()
        {
            Console.WriteLine("usan pastillas y discos de frenado");
        }

        public void Acelerar()
        {
            Console.WriteLine("inyecta mas gasolina la motor");
        }

        public void Girar()
        {
            Console.WriteLine("usa el volante para girar en curvas");
        }
    }
}
