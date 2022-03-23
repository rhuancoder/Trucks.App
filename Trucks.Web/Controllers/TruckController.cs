using Microsoft.AspNetCore.Mvc;
using Trucks.Domain.Contracts.Services;

namespace Trucks.Web.Controllers
{
    public class TruckController : Controller
    {
        private readonly ITruckService _truckService;

        public TruckController(ITruckService truckService)
        {
            _truckService = truckService;
        }

        public async Task<IActionResult> Index()
        {
            var trucks = await _truckService.GetAll();

            return View(trucks);
        }
    }
}