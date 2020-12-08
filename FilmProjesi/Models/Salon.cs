namespace FilmProjesi.Models
{
    public class Salon
    {
        public int Id { get; set; }
        public string SalonName { get; set; }
        public int? CinemaId { get; set; }
        public int? Capacity { get; set; }
    }
}