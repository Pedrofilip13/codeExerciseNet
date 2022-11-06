using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OwnersSystem.Models
{
	public class Vehicle
	{
        [Key]
        public int VehicleId { get; set; }
        [Required]
        public string Brand { get; set; }

        public string Vin { get; set; }

        public string Color { get; set; }

        public string Year { get; set; }

        // Foreign key   
        [Display(Name = "Owner")]
        public virtual int OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public virtual Owner Owners { get; set; }
    }
}
