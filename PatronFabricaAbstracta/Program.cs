using System;

namespace PatronFabricaAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabricaAbstracta miFabrica = new FabricaQuimica();

            miFabrica.crearProducto();

            IProductoLeche miLeche = miFabrica.ObtenerProductoLeche;
            IProductoSaborizante miSabor = miFabrica.ObtenSabor;

            miLeche.producir();
            miSabor.obtener();

            Console.WriteLine("mi malteada es {0}  y {1} ", miLeche.obtenerDatos(), miSabor.informacion());
            Console.WriteLine("------------------");

            miFabrica = new FabricaNatural();

            miFabrica.crearProducto();
            miLeche = miFabrica.ObtenerProductoLeche;
            miSabor = miFabrica.ObtenSabor;

            Console.WriteLine("Mi malteada es de {0} y {1} ", miLeche.obtenerDatos(), miSabor.informacion());



        }
    }
}
