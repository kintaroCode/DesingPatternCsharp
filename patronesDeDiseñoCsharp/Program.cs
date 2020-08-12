using System;

namespace patronesDeDiseñoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CPersona uno = CPersona.ProporcionarInstancia();

            //hacemos algo con la instancia
            uno.PonerDatos("iris", 21);
            uno.AlgunProceso();
            Console.WriteLine(uno);
            Console.WriteLine("---------------------");

            CPersona dos = CPersona.ProporcionarInstancia();
            Console.WriteLine(dos);
            
            
            //podemos modificar sus propiedades


            dos.PonerDatos("isrrael", 36);
            Console.WriteLine(dos);
            Console.WriteLine(uno);

            //al crear otro tenemos el mismo objeto creado en dos

            CPersona tres = CPersona.ProporcionarInstancia();
            Console.WriteLine(tres);


            //la instancia mantiene el mismo estado siempre que ses convocada. 
            //la clase sinleton será solo una . puede cambiar sus propiedades 
            //y agregar o quitar metodos. pero sera una clase unica. 

        }


    }


    class CPersona
    {
        //aqui se crea y se guarda la unica instancia que va existir .

        private static CPersona instancia;

        private string nombre;
        private int edad;

        //creamos el constructor privado el cual no se puede acceder
        //de forma usual con la palabra new
        private CPersona()
        {
            nombre = "sin asignar";
            edad = 99;
            
        }
        public static CPersona ProporcionarInstancia()
        {
            //verificamos que la instancia no existe
            if (instancia==null)
            {
                //si no existe se crea
                instancia = new CPersona();
                Console.WriteLine("creada por primera vez");
            }
            //retornamos la instancia
            return instancia; 
        }

        public override string ToString()
        {
            return string.Format("la persona {0} tiene edad de {1}", nombre, edad);
        }

        public void PonerDatos(string pNombre, int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;
        }

        //esto es cualquier otro proceso en la clase
        public void AlgunProceso()
        {
            Console.WriteLine("{0} esta trabajando",0);
        }


    }

}
