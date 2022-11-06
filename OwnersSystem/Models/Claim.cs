using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OwnersSystem.Models
{
	public class Claim
	{
        [Key]
        public int ClaimId { get; set; }
        [Required]
        public string Description { get; set; }

        public string Status { get; set; }

        public DateTime Date { get; set; }

        // Foreign key   
        [Display(Name = "Vechicle")]
        public virtual int VechicleId { get; set; }

        [ForeignKey("VechicleId")]
        public virtual Vehicle Vehicles { get; set; }
    }
}
