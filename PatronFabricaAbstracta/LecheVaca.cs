using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabricaAbstracta
{
    class LecheVaca:IProductoLeche
    {
        public void producir()
        {
            Console.WriteLine("ordeñar las vacas");
        }

        public string obtenerDatos() 
        {
            return "leche fresca y refrescante de vaca";
        
        }
            

    }
}
