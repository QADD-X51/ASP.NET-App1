namespace DAWM_Backend_API.DataLayer.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int ModelYear { get; set; }
        public int Power { get; set; }
        public int EngineCapacity { get; set; }
        public string EngineType { get; set; }
        public string FuelType { get; set; }
        public string Drivetrain { get; set; }
        public int Weight { get; set; }
        public int Mileage { get; set; }
        public float Price { get; set; }
        public bool Negotiable { get; set; }
        public string Description { get; set; }

        public int MakerId { get; set; }
        public Maker Maker { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
