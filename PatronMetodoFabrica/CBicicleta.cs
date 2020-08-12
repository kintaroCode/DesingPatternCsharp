using System;
using System.Collections.Generic;
using System.Text;

namespace PatronMetodoFabrica
{
    class CBicicleta:IVehiculo
    {
        public void Encender()
        {
            Console.WriteLine("las Bicis no necesitan encendido");
        }

        public void Frenar()
        {
            Console.WriteLine("frenan con guayas y si falla puedes frenar con los pies");
        }

        public void Acelerar()
        {
            Console.WriteLine("se usa la fuerza motriz de las piernas");
        }

        public void Girar()
        {
            Console.WriteLine("se usa un manubrio");
        }

    }
}
