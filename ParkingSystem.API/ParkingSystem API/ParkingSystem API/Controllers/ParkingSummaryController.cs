using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkingSystem_API.Data;

namespace ParkingSystem_API.Controllers
{
    [ApiController]
    [Route("api/summary")]
    public class ParkingSummaryController : Controller
    {
        private readonly ParkingSystemDbContext _psDbContext;
        public ParkingSummaryController(ParkingSystemDbContext parkingSystemDbContext)
        {
            _psDbContext = parkingSystemDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetParkingSumary()
        {
            var parkingSummary =  await _psDbContext.parkingSummaries.ToListAsync();
            
            return Ok(parkingSummary);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateParkingSummary([FromRoute] int id, string type)
        {
            var parkingSummary = await _psDbContext.parkingSummaries.FirstOrDefaultAsync(x => x.ZoneId == id);


            if (type == "park")
            {
                if (parkingSummary.FilledSlots == parkingSummary.TotalSlots)
                    return BadRequest();
                else
                    parkingSummary.FilledSlots += 1;
            }
            else if (type == "unpark")
            {
                if (parkingSummary.FilledSlots == 0)
                    return BadRequest();
                else
                    parkingSummary.FilledSlots -= 1;
            }

            await _psDbContext.SaveChangesAsync();

            return Ok(parkingSummary);
        }
    }
}
