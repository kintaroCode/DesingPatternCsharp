using System;
using System.Collections.Generic;
using System.Text;

namespace PatronMetodoFabrica
{
    class CAdministradorProducto
    {
        public static IVehiculo Metodofabrica(int pDinero)
        {
            IVehiculo temp= null;

            if (pDinero>10000000)
            {
                temp =new CAeronave(); 
            }
            else if (pDinero>20000)
            {
                temp = new CAutomovil();
            }
            else
            {
                temp = new CBicicleta();
            }
            return temp;
        }
    }
}
