using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Trucks.Crosscutting.ViewModels;
using Trucks.Domain.Contracts.Services;
using Trucks.Domain.Entities;
using Trucks.Domain.Enums;

namespace Trucks.Web.Controllers
{
    public class TruckController : Controller
    {
        private readonly ITruckService _truckService;
        private readonly ITruckModelService _truckModelService;

        public TruckController(ITruckService truckService, ITruckModelService truckModelService)
        {
            _truckService = truckService;
            _truckModelService = truckModelService;
        }

        public async Task<IActionResult> Index()
        {
            var trucks = await _truckService.GetAllAsync();

            return View(trucks);
        }

        public async Task<IActionResult> Create()
        {
            var manufactureYears = new List<int>() { DateTime.Now.Year };
            var modelYears = new List<int>() { DateTime.Now.Year, DateTime.Now.Year + 1 };
            var truckModels = await _truckModelService.GetAllAsync();
            
            ViewData["ManufactureYear"] = new SelectList(manufactureYears);
            ViewData["ModelYear"] = new SelectList(modelYears);
            ViewData["TruckModel"] = new SelectList(truckModels, nameof(TruckModel.Id), nameof(TruckModel.Name));

            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id is null)
                return NotFound();

            return View(await _truckService.GetDetailsAsync((int)id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TruckViewModel truckViewModel)
        {
            if (ModelState.IsValid)
            {
                await _truckService.CreateAsync(truckViewModel);

                return RedirectToAction(nameof(Index));
            }

            return View(truckViewModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null)
                return NotFound();

            var truck = await _truckService.GetAsync((int)id);

            if (truck is null)
                return NotFound();

            var manufactureYears = new List<int>() { DateTime.Now.Year };
            var modelYears = new List<int>() { DateTime.Now.Year, DateTime.Now.Year + 1 };
            var truckModels = await _truckModelService.GetAllAsync();

            ViewData["ManufactureYear"] = new SelectList(manufactureYears);
            ViewData["ModelYear"] = new SelectList(modelYears);
            ViewData["TruckModel"] = new SelectList(truckModels, nameof(TruckModel.Id), nameof(TruckModel.Name));

            return View(truck);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TruckViewModel truckViewModel)
        {
            if (id != truckViewModel.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                await _truckService.UpdateAsync(id, truckViewModel);

                return RedirectToAction(nameof(Index));
            }

            return View(truckViewModel);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null)
                return NotFound();

            var truck = await _truckService.GetDetailsAsync((int)id);

            if (truck is null)
                return NotFound();

            return View(truck);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _truckService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}