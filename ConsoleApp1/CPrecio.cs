using System;
using System.Collections.Generic;
using System.Text;

namespace PatronPrototipo
{
    class CPrecio:IPrototipo
    {
        private double sumatoria;
        private int m = 1;

        public int M { get => m; set => m = value;}
        public double Sumatoria { get => sumatoria; set => sumatoria = value; }

        public CPrecio() { }

        //este es un constructor costoso

        public CPrecio(int pM)
        {
            m = pM;
            int n = 0;
            for (n = 0; n <90;  n++)
            {
                sumatoria += Math.Sin(n * 0.0175);
            }

        }

        public override string ToString()
        {
            return string.Format("{0}", sumatoria*m);
        }

        public object Clonar()
        {
            CPrecio clon = new CPrecio();
            clon.M = m;
            clon.Sumatoria = sumatoria;

            return clon;
        }



    }
}
