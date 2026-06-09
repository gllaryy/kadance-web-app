namespace KAdanceAPI.models
{
    public class Registration
    {
        public int Id { get; set; }

        
        public int ClientId { get; set; }
        public Client Client { get; set; } = null!;

       
        public int DanceClassId { get; set; }
        public DanceClass DanceClass { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
