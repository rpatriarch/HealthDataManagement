namespace HealthDataManagement.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Content { get; set; }
        public DateTime DateSent { get; set; }
    }
}
