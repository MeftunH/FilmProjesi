using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmProjesi.Models
{
    public class FilmActor
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int ActorId { get; set; }
        public int? Number { get; set; }
        public string Role { get; set; }
        public Actor Actor { get; set; }
    }
}
