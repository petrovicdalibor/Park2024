namespace Park2024.Models
{
    public class Zona
    {
        public int id { get; set; }
        public string ime { get; set; }

        public virtual IList<Parking> Parkings { get; set; }
    }
}
