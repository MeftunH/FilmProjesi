using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmProjesi.Models
{
    public class FilmDirector
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int DirectorId { get; set; }
        public string YonetmenTip { get; set; }
        public int? Number { get; set; }
        public Director Director { get; set; }
    }
}
