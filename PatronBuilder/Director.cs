using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBuilder
{
    class Director
    {
        public void construye(IBuilder pConstruye)
        {
            pConstruye.ConstruyeMotor();
            pConstruye.ConstruyeCarroceria();
            pConstruye.ConstruyeLlantas();
        }
    }
}
