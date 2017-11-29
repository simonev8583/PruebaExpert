using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelosNegocio;
using HerramientasNegocio;

namespace LogicaNegocio
{
    public class LogicaNPesebrera
    {
        public Pesebrera CrearPesebrera(int id,string nombre)
        {
            Pesebrera pesebrera = new Pesebrera(id, nombre);
            return pesebrera;
        }
        public Pesebrera CrearPesebrera(int id, string nombre, List<Animal> animales)
        {
            Pesebrera pesebrera = new Pesebrera(id, nombre,animales);
            return pesebrera;
        }
        public void AgregarAnimalesenPesebrera(Pesebrera pesebrera,List<string> nombreanimales)
        {
            LogicaNAnimal LNAnimal = new LogicaNAnimal();
            List<Animal> nuevosanimales = LNAnimal.ClasificarAnimales(nombreanimales);
            pesebrera.setListaAnimales(nuevosanimales);
        }
        public void ClasificarAnimales(Pesebrera pesebrera)
        {
            List<string> Equinos = new List<string>();
            List<string> Bovinos = new List<string>();
            for (int i = 0; i < pesebrera.getListaAnimales().Count; i++)
            {
                if (pesebrera.getListaAnimales()[i].getCategoriaanimal().Equals("Equino"))
                {
                    Equinos.Add(pesebrera.getListaAnimales()[i].getNombreAnimal());
                }
                else
                {
                    Bovinos.Add(pesebrera.getListaAnimales()[i].getNombreAnimal());
                }
            }
            ProcesarArchivos procesarArchivos = new ProcesarArchivos();
            procesarArchivos.CrearArchivoTxt("Equinos",pesebrera.getNombrePesebrera(), Equinos);
            procesarArchivos.CrearArchivoTxt("Bovinos",pesebrera.getNombrePesebrera(), Bovinos);

        }
    }
}
