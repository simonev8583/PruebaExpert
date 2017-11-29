using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelosNegocio;
using System.Collections;

namespace LogicaNegocio
{
    public class LogicaNAnimal
    {
        public Animal CrearAnimal(string nombre,CategoriaAnimal categoria)
        {
            Animal animal = new Animal(nombre, categoria);
            return animal;
        }
        public Animal CrearAnimal(string nombre)
        {
            Animal animal = new Animal(nombre);
            return animal;
        }
        public List<Animal> ClasificarAnimales(List<string> datos)
        {
            LogicaNCategoriaAnimal categoriaAnimal = new LogicaNCategoriaAnimal();
            CategoriaAnimal Equino=categoriaAnimal.AgregarCategoria(1, "Equino");
            CategoriaAnimal Bovino = categoriaAnimal.AgregarCategoria(2, "Bovino");
            List<Animal> ListaAnimales=new List<Animal>();
            foreach (string indice in datos)
            {
                if(indice[0] == 'b' || indice[0] == 'B')
                {
                    Animal animal= CrearAnimal(indice, Bovino);
                    ListaAnimales.Add(animal);
                }
                else
                {
                    Animal animal= CrearAnimal(indice, Equino);
                    ListaAnimales.Add(animal);
                }
            }
            return ListaAnimales;
        }
    }
}
