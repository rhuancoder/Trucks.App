using Microsoft.AspNetCore.Mvc;

namespace Trucks.Web.Controllers
{
    public class TruckController : Controller
    {
        public TruckController()
        {
        }

        public async Task<IActionResult> Index()
        {
            var trucks = new List<Models.TruckViewModel>()
            {
                new Models.TruckViewModel() 
                { 
                    Description = "Xpto",
                    TruckModel = "FM",
                    ManufactureYear = 2019,
                    ModelYear = 2022
                }
            };

            return View(trucks);
        }
    }
}
