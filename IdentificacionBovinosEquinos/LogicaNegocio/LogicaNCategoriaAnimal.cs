using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelosNegocio;

namespace LogicaNegocio
{
    public class LogicaNCategoriaAnimal
    {
        public CategoriaAnimal AgregarCategoria(int id,string nombre)
        {
            CategoriaAnimal Categoriaanimal = new CategoriaAnimal(id, nombre);
            return Categoriaanimal;
        }
    }
}
