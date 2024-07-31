
using System.ComponentModel.DataAnnotations;

namespace HealthDataManagement.Models
{
    public class SomeEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
