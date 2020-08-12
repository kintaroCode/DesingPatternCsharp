using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBuilder
{
    interface IChasis
    {
        string caracteristicas();
    }

    class CarroceriaBasica:IChasis
    {
        public string caracteristicas()
        {
            return "carroceria de metal";
        }

    }
    class CarroceriaDeportiva : IChasis
    {
        public string caracteristicas()
        {
            return "Carroceria de fibra de carbono";
        }

    }
}
