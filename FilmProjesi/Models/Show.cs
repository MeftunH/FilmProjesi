using System;

namespace FilmProjesi.Models
{
    public class Show
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public int SalonId { get; set; }
        public string SalonNo { get; set; }
        public DateTime Start { get; set; }
        public bool? Subtitle { get; set; }
        public Film Film { get; set; }
        public Salon Salon { get; set; }
    }
}