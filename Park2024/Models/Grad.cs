namespace Park2024.Models
{
    public class Grad
    {
        public int id {  get; set; }
        public string ime { get; set; }

        public IList<Parking> Parkings { get; set; }
    }
}
