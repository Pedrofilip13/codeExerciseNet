using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace OwnersSystem.Models
{
    public class Owner
    {
        [Key]
        public int OwnerId { get; set; }
        [Required]

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DriverLicense { get; set; }
    }
}