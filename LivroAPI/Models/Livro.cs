using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivroAPI.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string Resumo { get; set; }
        public string Autor { get; set; }
    }
}