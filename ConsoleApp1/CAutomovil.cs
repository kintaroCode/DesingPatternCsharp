using System;
using System.Collections.Generic;
using System.Text;

namespace PatronPrototipo
{
    class CAutomovil:IPrototipo
    {
        private string modelo;
        private int costo;

        public string Modelo { get => modelo; set => modelo = value; }
        public int Costo { get => costo; set => costo = value; }

        public CAutomovil(string pModelo, int pCosto)
        {
            modelo = pModelo;
            costo = pCosto;
        }

        public override string ToString()
        {
            return string.Format("Auto: {0} , {1}", modelo, costo);
        }

        public object Clonar()
        {
            CAutomovil clon = new CAutomovil(modelo, costo);
            return clon;
        }


    }
}
