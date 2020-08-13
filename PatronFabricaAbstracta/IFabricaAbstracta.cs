using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabricaAbstracta
{
    interface IFabricaAbstracta
    {
        void crearProducto();

        IProductoLeche ObtenerProductoLeche { get; }

        IProductoSaborizante ObtenSabor { get; }


    }
}
