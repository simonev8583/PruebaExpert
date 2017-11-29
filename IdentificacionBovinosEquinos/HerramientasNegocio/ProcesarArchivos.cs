using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerramientasNegocio
{
    public class ProcesarArchivos
    {

        public void CrearArchivoTxt(string nombreArchivo,string nombrePesebrera, List<string> datos)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Simone Villa\Source\Repos\PruebaExpert\IdentificacionBovinosEquinos\Archivos\" + nombrePesebrera+nombreArchivo + ".txt"))
            {
                foreach (string dato in datos)
                {
                    file.WriteLine(dato);
                }
            }
        }

    }
}
