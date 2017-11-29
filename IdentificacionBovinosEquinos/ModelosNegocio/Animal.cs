using System.Collections.Generic;

namespace ModelosNegocio
{
    public class Animal
    {
        private string NombreAnimal { get; set; }
        private CategoriaAnimal Categoriaanimal { get; set; }

        public Animal(string nombre,CategoriaAnimal categoria)
        {
            this.NombreAnimal = nombre;
            Categoriaanimal = categoria;
        }
        public Animal(string nombre)
        {
            this.NombreAnimal = nombre;
        }
        public string getNombreAnimal()
        {
            return NombreAnimal;
        }
        public void setNombreAnimal(string nombre)
        {
           NombreAnimal=nombre;
        }
        public string getCategoriaanimal()
        {
            return Categoriaanimal.getNombreCategoria();
        }
        public void setCategoriaanimal(string nombre)
        {
            Categoriaanimal.setNombreCategoria(nombre);
        }

    }
}
