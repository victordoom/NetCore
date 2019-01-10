using NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Data
{
    public class DbInitializer
    {
        public static void Initialize(NetCoreContext context)
        {
            context.Database.EnsureCreated(); //creo la base

            //buscar si existen registros en la tabla categoria
            if (context.Categoria.Any())
            {
                return;
            }
            //si la base de datos es nueva y no hay registros se ingresaran los siguientes datos de prueba
            var categorias = new Categoria[]
            {
                new Categoria{Nombre="Programacion", Descripcion="Cursos", Estado=true},
                new Categoria{Nombre="Diseño grafico", Descripcion="Cursos de dieño", Estado=true}
            };

            foreach (Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }

            context.SaveChanges();
        }
    }
}
