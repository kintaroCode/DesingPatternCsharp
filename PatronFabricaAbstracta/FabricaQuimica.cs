using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabricaAbstracta
{
    class FabricaQuimica : IFabricaAbstracta
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        public IProductoLeche ObtenerProductoLeche { get { return leche; } }
        public IProductoSaborizante ObtenSabor { get { return sabor; } }

        public void crearProducto()
        {
            Console.WriteLine("estamos produciendo tu malteadad");
            leche = new LecheVaca();
            sabor = new SaborChocolate();
        }
    }
}