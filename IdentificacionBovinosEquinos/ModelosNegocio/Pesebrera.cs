using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ModelosNegocio
{
    public class Pesebrera
    {
        private int IdPersebrera;
        private string NombrePesebrera;
        private List<Animal> ListaAnimales;

        public Pesebrera(int id, string nombre)
        {
            this.IdPersebrera = id;
            this.NombrePesebrera = nombre;
        }
        public Pesebrera(int id, string nombre,List<Animal> animales)
        {
            this.IdPersebrera = id;
            this.NombrePesebrera = nombre;
            this.ListaAnimales = animales;
        }

        public int IdPesebrera
        {
            get{return IdPersebrera;}
            set{IdPersebrera = value;}
        }
        public string getNombrePesebrera()
        {
            return NombrePesebrera;
        }
        public void setNombrePesebrera(string nombre)
        {
            NombrePesebrera=nombre;
        }
        public List<Animal> getListaAnimales()
        {
            return ListaAnimales;
        }
        public void setListaAnimales(List<Animal> animales)
        {
            if (this.ListaAnimales.Count > 0)
            {
                for (int i = 0; i < animales.Count; i++)
                {
                    ListaAnimales.Add(animales[i]);
                }
                
            }
            else { ListaAnimales = animales; }
        }
    }
}
