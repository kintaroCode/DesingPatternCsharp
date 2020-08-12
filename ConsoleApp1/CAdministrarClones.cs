using System;
using System.Collections.Generic;
using System.Text;

namespace PatronPrototipo
{
    class CAdministrarClones
    {
        private Dictionary<string, IPrototipo> catalogoClones = new Dictionary<string, IPrototipo>();

        public CAdministrarClones()
        {
            CPersona persona = new CPersona("Ciudadano", 18);
            catalogoClones.Add("persona", persona);

            CPrecio valores = new CPrecio(1);
            catalogoClones.Add("valores", valores);

        }

        public void adicionarClones(string pLlave, IPrototipo pPrototipo)
        {
            catalogoClones.Add(pLlave, pPrototipo);

        }

        public object obtenerClones(string pLlave)
        {
            return catalogoClones[pLlave].Clonar();
        }

    }
}
