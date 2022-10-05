using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace rote66.Models
{
    public class Noticias
    {
        public int NoticiasId { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }

        public IEnumerable<Noticias> TodasAsNoticias()
        {
            var retorno = new Collection<Noticias>
            {

                new Noticias
                {
                NoticiasId = 1,
                Categoria = "Esportes",
                Titulo = "O time da escola ganha",
                Conteudo = "O time da escola ganha de 10 a 2",
                Data = new DateTime(22 / 03 / 2019)
                },

                new Noticias
                {
                NoticiasId = 2,
                Categoria = "Saude",
                Titulo = "Crise na saude",
                Conteudo = "Greve",
                Data = new DateTime(25 / 04 / 2019)
                },

                new Noticias
                {
                NoticiasId = 3,
                Categoria = "Tempo",
                Titulo = "Clima frio se aproxima",
                Conteudo = "Frente fria",
                Data = new DateTime(29 / 04 / 2019)
                },

                new Noticias
                {
                NoticiasId = 4,
                Categoria = "Saude",
                Titulo = "Casos de Covid aumentam no BG",
                Conteudo = "7 alunos com covid",
                Data = new DateTime(27 / 06 / 2022)
                }



             };
            return retorno;
        }
    }
}