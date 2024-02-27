namespace Park2024.Models
{
    public class ParkingIstorija
    {
        public int id { get; set; }
        public int profil_id { get; set; }
        public int parking_id { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Parking Parking { get; set; }
    }
}
