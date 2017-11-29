using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerramientasNegocio;
using ModelosNegocio;
using LogicaNegocio;

namespace Principal
{
    class ClasificacionANimales
    {
        static void Main(string[] args)
        {         
            LeerArchivos leer = new LeerArchivos();
            // Se debe cambiar la ruta del archivo y en la capa HerramientasNegocio-> clase Procesar Archivo cambiar la direccion para guardar el archivo 
            List<string> datos = leer.LeerArchivoDat("C:/Users/Simone Villa/Documents/Visual Studio 2017/Projects/IdentificacionBovinosEquinos/Archivos/EQUNOSBOVINOS.DAT");

            // Para clasificar los animales se debe enviar el ArrayList datos
            LogicaNAnimal LogicaNanimal = new LogicaNAnimal();
            List<Animal> animales=LogicaNanimal.ClasificarAnimales(datos);
            // Las listas de datos que debemos mandar a los metodos que clasifican a los animales deben ser de tipo string
            // dentro de los metodos se realiza la conversion en animales y su respectiva categoria
            // DATOS PARA OTRO TIPO DE PRUEBA
            /*
            List<string> animales2 = new List<string>();
            string burro = "Burro";
            string yegua = "Yegua";
            animales2.Add(yegua);
            animales2.Add(burro);*/

            // despues de clasificar los animales se debe crear una pecebrera y agregarle los datos
            LogicaNPesebrera LNpesebrera = new LogicaNPesebrera();
            Pesebrera pesebrera1 = LNpesebrera.CrearPesebrera(1, "Pesebrera 1", animales);
            //LNpesebrera.AgregarAnimalesenPesebrera(pesebrera1, animales2);

            // Clasificar animales permite clasificar en categorias ('Bovino' y 'Equino') los animales de una pesebrera
            LNpesebrera.ClasificarAnimales(pesebrera1);

            
        }
        
    }
}
