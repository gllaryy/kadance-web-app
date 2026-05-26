namespace KAdanceAPI.models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;


        public List<Registration> Registrations { get; set; } = new();
    }
}
