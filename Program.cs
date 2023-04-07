// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //delegados
            var del = Method;
            del.Invoke("Hola Mundo");

            del = Method1;
            del.Invoke("Daniel");

            //con genericos
            //defino los tipos y envio el metodo que se encarga de hacer el mapping
            //el metodo debe llevar la 
            var service = new GenericService<Entity, DTO>(MapperToDTO);

            var entity = service.CreateEntity();
            var dto = service.toDTO(entity);
          
        }

        public static void Method(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public static void Method1(string mensaje)
        {
            Console.WriteLine($"Hola {mensaje}");
        }

        public static DTO MapperToDTO(Entity en)
        {
            return new DTO { Id = en.Id, Name = en.Name };
        }
    }
}