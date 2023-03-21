namespace DAWM_Backend_API.DataLayer.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<Car> Cars { get; set; }
    }
}
