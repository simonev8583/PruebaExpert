using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosNegocio
{
    public class CategoriaAnimal
    {
        private int IdCategoria { get; set; }
        private string NombreCategoria { get; set; }

        public CategoriaAnimal(int id,string nombre)
        {
            this.IdCategoria = id;
            this.NombreCategoria = nombre;
        }

        public string getNombreCategoria()
        {
            return NombreCategoria;
        }
        public void setNombreCategoria(string nombre)
        {
            NombreCategoria=nombre;
        }
    }
}
