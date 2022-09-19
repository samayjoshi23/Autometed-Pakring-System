using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ParkingSystem_API.Model
{
    public class VehicleDbModel
    {
        [Key]
        public Guid Vehicle_Id { get; set; }
        public long CustomerId{ get; set; }
        [StringLength(25)]
        public string Owner_Name { get; set; }
        [StringLength(20)]
        public string Vehicle_Number { get; set; }
        public int FloorId { get; set; }
        public int SlotId { get; set; }
        public Nullable<DateTime> ParkingTime { get; set; }
        public Nullable<DateTime> UnparkingTime { get; set; }
        public int ParkingPin { get; set; }
    }
}
