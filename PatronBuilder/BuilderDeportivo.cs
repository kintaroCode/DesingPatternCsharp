using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBuilder
{
    class BuilderDeportivo:IBuilder
    {
        
            private Producto auto = new Producto();

            public void ConstruyeMotor()
            {
                auto.colocaMotor(new MotorDeportivo());
            }
            public void ConstruyeLlantas()
            {
                auto.colocaLlantas(new LlantasDeportivas());
            }

            public void ConstruyeCarroceria()
            {
                auto.colocaCarroceria(new CarroceriaDeportiva());
            }
            public Producto obtenProducto()
            {
                return auto;
            }

        
    }
}
