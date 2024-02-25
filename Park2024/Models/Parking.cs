namespace Park2024.Models
{
    public class Parking
    {
        public int Id { get; set; }
        public int Sopstvenik_Id { get; set; }
        public string Ulica { get; set; }
        public int Cena { get; set; }
        public int Br_Mesta { get; set; }
        public int Zona_Id { get; set; }
        public int Grad_Id { get; set; }

        public virtual Sopstvenik Sopstvenik { get; set; }
    }
}
