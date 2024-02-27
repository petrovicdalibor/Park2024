namespace Park2024.Models
{
    public class Zalbi
    {
        public int id { get; set; }
        public string tip { get; set; }
        public string opis { get; set; }
        public int parking_id { get; set; }
        public int korisnik_id { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Parking Parking { get; set; }
    }
}
