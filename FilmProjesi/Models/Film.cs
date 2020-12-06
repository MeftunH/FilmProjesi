using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmProjesi.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string FilmName { get; set; }
        public int? Year { get; set; }
        public int? Duration { get; set; }
        public double? IMDB { get; set; }
        public string Content { get; set; }
        public string Banner { get; set; }
        public string Fragman { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int Lang_Id { get; set; }
        public Language Language { get; set; }

    }
}
