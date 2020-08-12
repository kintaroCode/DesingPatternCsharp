using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBuilder
{
    class Producto
    {
        private IMotor motor;
        private ICubiertas llantas;
        private IChasis carroceria;

        public void colocaMotor(IMotor pMotor)
        {
            motor = pMotor;
            Console.WriteLine("se ha colocado un motor de : {0}", motor.especificacionesMotor());
        }

        public void colocaCarroceria(IChasis pCarroceria)
        {
            carroceria = pCarroceria;
            Console.WriteLine("se ha colocado una carroceria de : {0}",carroceria.caracteristicas());
        }

        public void colocaLlantas(ICubiertas pLlantas)
        {
            llantas = pLlantas;
            Console.WriteLine( "se ha colocado llantas:{0}", llantas.EquiparLlantas() );
        }
        public void mostrarAuto()
        {
            Console.WriteLine($"tu auto tiene {motor.especificacionesMotor()}, {carroceria.caracteristicas()}, y {llantas.EquiparLlantas()}");
        }

        
    }
}
