using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingSystem_API.Model
{
    public class ParkingSummary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZoneId { get; set; }
        public string ZoneTitle { get; set; }
        public int TotalSlots { get; set; }
        public int FilledSlots { get; set; }
    }
}
