using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkingSystem_API.Data;
using ParkingSystem_API.Model;

namespace ParkingSystem_API.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("api/parkingHistory")]
    public class HistoryController : Controller
    {
        private readonly ParkingSystemDbContext _psDbContext;
        public HistoryController(ParkingSystemDbContext parkingSystemDbContext)
        {
            _psDbContext = parkingSystemDbContext;
        }

        [HttpGet]
        [Route("/admin")]
        public async Task<IActionResult> GetParkingHistory()
        {
            var allVehicleList = await _psDbContext.vehicleDbModels.ToListAsync();
            var parkedVehicleList = (from v in allVehicleList where v.UnparkingTime == null select v);
            var unparkedVehicleList = (from v in allVehicleList where v.UnparkingTime != null select v);
            
            int allvehicleCount = allVehicleList.Count;
            int parkedVehicleCount = parkedVehicleList.Count();
            int unparkedVehicleCount = allvehicleCount - parkedVehicleCount;

            return Ok(new { allVehicleList, parkedVehicleList,  unparkedVehicleList, allvehicleCount, parkedVehicleCount, unparkedVehicleCount});
        }

        [HttpPost]
        public async Task<IActionResult> AddVehicle([FromBody]VehicleDbModel vehicleInfo)
        {
            vehicleInfo.Vehicle_Id = Guid.NewGuid();
            vehicleInfo.ParkingTime = DateTime.Now;
            vehicleInfo.UnparkingTime = null;

            await _psDbContext.vehicleDbModels.AddAsync(vehicleInfo);
            await _psDbContext.SaveChangesAsync();

            return Ok(vehicleInfo);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateVehicle([FromRoute]int id, int pin)
        {
            var vehicleInfo = await _psDbContext.vehicleDbModels.FirstOrDefaultAsync(x => x.CustomerId == id);


            if (vehicleInfo == null)
                return NotFound();

            if (vehicleInfo.ParkingPin != pin)
                return Unauthorized();
            
            vehicleInfo.UnparkingTime = DateTime.Now;

            await _psDbContext.SaveChangesAsync();

            return Ok(vehicleInfo);
        }
    }
}