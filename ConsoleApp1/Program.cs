using PatronPrototipo;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos el admininstrador

            CAdministrarClones admin = new CAdministrarClones();

            //creamos dos instancias . no se usa palabra new por que el objeto ya existe en el catalogo de prototipo
            CPersona uno = (CPersona)admin.obtenerClones("persona");
            CPersona dos = (CPersona)admin.obtenerClones("persona");

            //se verifica que realmente es el mmismo objetos clonado

            Console.WriteLine(uno);
            Console.WriteLine(dos);

            Console.WriteLine("---------------");

            //aqui modificamos y personalizamos cada objeto. cada uno tiene propiedades independientes

            uno.Nombre = "edith";
            uno.Edad = 32;
            dos.Nombre = "oriana";
            dos.Edad = 12;


            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("---------------");

            //creamos un objeto mas dificil de crear
            CAutomovil auto = new CAutomovil("Nissan", 250000);

            //lo agregamos al catalogo
            admin.adicionarClones("Auto", auto);

            //obtenemos unn prototipo de ese nissan

            CAutomovil auto2 = (CAutomovil)admin.obtenerClones("Auto");

            auto2.Modelo = "honda";

            //verificamos que cada una tenga su estado. 

            Console.WriteLine(auto);
            Console.WriteLine(auto2);
            Console.WriteLine("-----------------");

            //este es un constructos costoso de clonar. donde conviene modificar su uso

            CPrecio valor = (CPrecio)admin.obtenerClones("valores");
            Console.WriteLine(valor);
        }
    }
}
