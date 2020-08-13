using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabricaAbstracta
{
    class LecheAlmendras:IProductoLeche
    {
        public void producir()
        {
            Console.WriteLine("triturar las almendras");
        }

        public string obtenerDatos()
        {
            return "leche para veganos";

        }
    }
}
