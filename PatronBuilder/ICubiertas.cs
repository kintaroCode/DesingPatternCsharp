using System;
using System.Collections.Generic;
using System.Text;

namespace PatronBuilder
{
    interface ICubiertas
    {
        string EquiparLlantas();
    }
    class LlantasBasica : ICubiertas
    {
        public string EquiparLlantas()
        {
            return "llantas de 12 pulgadas";
        }
    }
    class LlantasDeportivas : ICubiertas
    {
        public string EquiparLlantas()
        {
            return "llantas michellin de 18 pulgadas";
        }

    }

}
