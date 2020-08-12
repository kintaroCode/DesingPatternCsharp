using System;

namespace PatronBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director miDirector = new Director();

            BuilderNormal normal = new BuilderNormal();

            miDirector.construye(normal);

            Producto auto1 = normal.obtenProducto();

            auto1.mostrarAuto();
            Console.WriteLine("--------------------------------");

            BuilderDeportivo deportivo = new BuilderDeportivo();
            miDirector.construye(deportivo);
            Producto auto2 = deportivo.obtenProducto();
            auto2.mostrarAuto();

        }
    }
}
