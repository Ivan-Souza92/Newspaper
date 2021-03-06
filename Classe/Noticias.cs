using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.News
{
    class Noticias
    {
        private string Titulo { get; set; }

        private string Autor { get; set; }

        private string Noticia { get; set; }


        public Noticias(string titulo, string autor, string noticia)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Noticia = noticia;
        }



        public override string ToString()
        {
            string retorno = "";

            retorno += "\nTitulo: " + this.Titulo;
            retorno += "\nAutor: " + this.Autor;
            retorno += "\nNoticia: " + this.Noticia;

            return retorno;

        }

        internal void Remove(int j)
        {
            Noticia.Remove(j);
            Console.WriteLine("Noticia removida com sucesso");
        }
    }
}
