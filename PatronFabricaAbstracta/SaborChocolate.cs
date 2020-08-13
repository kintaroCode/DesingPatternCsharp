using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabricaAbstracta
{
    class SaborChocolate:IProductoSaborizante
    {
        public void obtener()
        {
            Console.WriteLine("se produce complejo c7hr4");
        }

        public string informacion()
        {
            return "sabor a chocolate";
        }
    }
}
