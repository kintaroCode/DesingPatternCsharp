using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabricaAbstracta
{
    class SaborVainilla:IProductoSaborizante
    {
        public void obtener()
        {
            Console.WriteLine("se produce extracto de vainilla");
        }

        public string informacion()
        {
            return "sabor a vainilla";
        }
    }
}
