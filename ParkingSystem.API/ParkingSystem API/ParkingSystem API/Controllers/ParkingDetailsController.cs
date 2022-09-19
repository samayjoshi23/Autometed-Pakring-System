using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkingSystem_API.Data;
using ParkingSystem_API.Model;
using System.Reflection.Metadata.Ecma335;

namespace ParkingSystem_API.Controllers
{
    [ApiController]
    [Route("api/details")]
    public class ParkingDetailsController : Controller
    {
        private readonly ParkingSystemDbContext _psDbContext;
        public ParkingDetailsController(ParkingSystemDbContext parkingSystemDbContext)
        {
            _psDbContext = parkingSystemDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetParkingSumary()
        {
            var parkingDetails = await (from s in _psDbContext.parkingSummaries
                                        join d in _psDbContext.parkingDetails on s.ZoneId equals d.FloorId
                                        select new DetailedParkingDescription()
                                        {
                                            ZoneId = s.ZoneId,
                                            ZoneTitle = s.ZoneTitle,
                                            FilledSlots = s.FilledSlots,
                                            TotalSlots = s.TotalSlots,
                                            AvailableSlots = s.TotalSlots - s.FilledSlots,
                                            FloorId = d.FloorId,
                                            Slot1 = d.Slot1,
                                            Slot2 = d.Slot2,
                                            Slot3 = d.Slot3,
                                            Slot4 = d.Slot4,
                                            Slot5 = d.Slot5,
                                            Slot6 = d.Slot6,
                                            Slot7 = d.Slot7,
                                            Slot8 = d.Slot8,
                                            Slot9 = d.Slot9,
                                            Slot10 = d.Slot10,
                                            Slot11 = d.Slot11,
                                            Slot12 = d.Slot12,
                                            Slot13 = d.Slot13,
                                            Slot14 = d.Slot14,
                                            Slot15 = d.Slot15,
                                            Slot16 = d.Slot16,
                                            Slot17 = d.Slot17,
                                            Slot18 = d.Slot18,
                                            Slot19 = d.Slot19,
                                            Slot20 = d.Slot20
                                        }).ToListAsync();


            //List<ParkingSummary> summary = await _psDbContext.parkingSummaries.ToListAsync();
            //List<ParkingDetails> details = await _psDbContext.parkingDetails.ToListAsync();


            //var parkingDetails = (from s in summary
            //                      join d in details on s.ZoneId equals d.FloorId into table1
            //                      from d in table1.ToList()
            //                      select new DetailedParkingDescription()
            //                      {
            //                          parkingSummary = s,
            //                          parkingDetails = d
            //                      });


            return Ok(parkingDetails);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetParkingSlots([FromRoute] int id)
        {
            var parkingData = await _psDbContext.parkingDetails.FirstOrDefaultAsync(x => x.FloorId == id);

            return Ok(parkingData);
        }


        [HttpPut]
        [Route("{id}/{slotId}")]
        public async Task<IActionResult> GetParkingSlots([FromRoute] int id, int slotId, string type)
        {
            int slotSetter = 0;
            var parkingData = await _psDbContext.parkingDetails.FirstOrDefaultAsync(x => x.FloorId == id);

            if (parkingData == null)
                return NotFound();

            if (type == "park")
                slotSetter = 0;
            else
                slotSetter = 1;

            switch (slotId)
            {
                case 1: parkingData.Slot1 = slotSetter; break;
                case 2: parkingData.Slot2 = slotSetter; break;
                case 3: parkingData.Slot3 = slotSetter; break;
                case 4: parkingData.Slot4 = slotSetter; break;
                case 5: parkingData.Slot5 = slotSetter; break;
                case 6: parkingData.Slot6 = slotSetter; break;
                case 7: parkingData.Slot7 = slotSetter; break;
                case 8: parkingData.Slot8 = slotSetter; break;
                case 9: parkingData.Slot9 = slotSetter; break;
                case 10: parkingData.Slot10 = slotSetter; break;
                case 11: parkingData.Slot11 = slotSetter; break;
                case 12: parkingData.Slot12 = slotSetter; break;
                case 13: parkingData.Slot13 = slotSetter; break;
                case 14: parkingData.Slot14 = slotSetter; break;
                case 15: parkingData.Slot15 = slotSetter; break;
                case 16: parkingData.Slot16 = slotSetter; break;
                case 17: parkingData.Slot17 = slotSetter; break;
                case 18: parkingData.Slot18 = slotSetter; break;
                case 19: parkingData.Slot19 = slotSetter; break;
                case 20: parkingData.Slot20 = slotSetter; break;
            }

            await _psDbContext.SaveChangesAsync();

            return Ok(parkingData);
        }
    }
}
