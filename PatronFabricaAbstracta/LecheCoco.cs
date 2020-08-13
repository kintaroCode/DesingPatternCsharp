using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabricaAbstracta
{
    class LecheCoco:IProductoLeche
    {
        public void producir()
        {
            Console.WriteLine("subir al cocotero y bajar los cocos");
        }

        public string obtenerDatos()
        {
            return "la mejor leche del mundo";

        }
    }
}
