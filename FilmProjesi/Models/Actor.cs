using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmProjesi.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Dateofbirth { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public Gender gender { get; set; }
        public enum Gender
        {
            Male=1,
            Female=2
        }
    }
}
