using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBuilder
{
    class BuilderNormal:IBuilder
    {
        private Producto auto = new Producto();

        public void ConstruyeMotor()
        {
            auto.colocaMotor(new MotorBasico());
        }
        public void ConstruyeLlantas()
        {
            auto.colocaLlantas(new LlantasBasica());
        }

        public void ConstruyeCarroceria()
        {
            auto.colocaCarroceria(new CarroceriaBasica());
        }
        public Producto obtenProducto()
        {
            return auto;
        }

    }
}
