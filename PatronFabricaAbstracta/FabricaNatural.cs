using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabricaAbstracta
{
    class FabricaNatural:IFabricaAbstracta
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;
        
        public IProductoLeche ObtenerProductoLeche { get { return leche; } }
        public IProductoSaborizante ObtenSabor { get { return sabor; } }

        public void crearProducto()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string seleccion;
            Console.WriteLine("estamos creando tu bebida");
            Console.WriteLine("1) almendras \n 2) coco \n 3) vaca ");
            seleccion = Console.ReadLine();
            
            
            if (seleccion=="1")
            {
                leche = new LecheAlmendras();
            }
            else if (seleccion=="2")
            {
                leche = new LecheCoco();
            }

            else
            {
                leche = new LecheVaca();
            }

            leche.producir();

            Console.WriteLine("ahora obtenemoms el sabor");
            Console.WriteLine("1) chocolate \n 2) vainilla");
            seleccion = Console.ReadLine();
            
            sabor = seleccion == "1"?sabor= new SaborChocolate(): sabor = new SaborVainilla();

            sabor.obtener();
        }
    }
}
