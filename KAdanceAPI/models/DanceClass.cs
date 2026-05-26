namespace KAdanceAPI.models
{
    public class DanceClass
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;  
        public string DayOfWeek { get; set; } = string.Empty; 
        public string TimeStart { get; set; } = string.Empty; 
        public string TimeEnd { get; set; } = string.Empty;   
        public string Trainer { get; set; } = string.Empty;   

       
        public List<Registration> Registrations { get; set; } = new();
    }
}
