namespace HealthDataManagement.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public string Medication { get; set; }
        public DateTime DatePrescribed { get; set; }
    }
}
