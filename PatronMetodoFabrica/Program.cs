using System;

namespace PatronMetodoFabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato;
            int dinero;
            IVehiculo vehiculo;

            Console.WriteLine("cuanto dinero tienes para tu vehiculo");
            dato = Console.ReadLine();
            dinero = Convert.ToInt32(dato);
            vehiculo = CAdministradorProducto.Metodofabrica(dinero);

            vehiculo.Encender();
            vehiculo.Acelerar();
            vehiculo.Frenar();
            vehiculo.Girar();

        }
    }
}
