using System;
using System.Collections.Generic;
using System.Text;

namespace PatronMetodoFabrica
{
    interface IVehiculo
    {
        void Acelerar();
        void Frenar();
        void Encender();
        void Girar(); 
    }
}
