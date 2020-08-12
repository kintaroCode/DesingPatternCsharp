using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBuilder
{
    interface IBuilder
    {
        void ConstruyeMotor();
        void ConstruyeCarroceria();
        void ConstruyeLlantas();
    }
}
