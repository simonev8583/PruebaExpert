using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerramientasNegocio
{
    public class LeerArchivos
    {
        public List<string> LeerArchivoDat(string direccion)
        {
            StreamReader Fichero = new StreamReader(direccion);
            string dato = "";
            List<string> ListaDatos = new List<string>();

            while (dato != null)
            {
                dato = Fichero.ReadLine();
                if (dato != null)
                    ListaDatos.Add(dato);
            }
            Fichero.Close();
            return ListaDatos;
        }
    }
}
