using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBuilder
{
    interface IMotor
    {
        string especificacionesMotor();
    }
    class MotorBasico : IMotor
    {
        public string especificacionesMotor()
        {
            return "motor de 4 cilindros";
        }
    }
    
    class MotorDeportivo:IMotor
    { 
        public string especificacionesMotor()
        {
            return "motor de 8 cilidros";
        }
    }
}
