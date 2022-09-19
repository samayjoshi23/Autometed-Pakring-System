using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ParkingSystem_API.Model
{
    public class ParkingDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FloorId { get; set; }
        public int Slot1 { get; set; }
        public int Slot2 { get; set; }
        public int Slot3 { get; set; }
        public int Slot4 { get; set; }
        public int Slot5 { get; set; }
        public int Slot6 { get; set; }
        public int Slot7 { get; set; }
        public int Slot8 { get; set; }
        public int Slot9 { get; set; }
        public int Slot10 { get; set; }
        public int Slot11 { get; set; }
        public int Slot12 { get; set; }
        public int Slot13 { get; set; }
        public int Slot14 { get; set; }
        public int Slot15 { get; set; }
        public int Slot16 { get; set; }
        public int Slot17 { get; set; }
        public int Slot18 { get; set; }
        public int Slot19 { get; set; }
        public int Slot20 { get; set; }
    }
}
