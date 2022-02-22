using Microsoft.AspNetCore.Mvc;
using MvcCoreClientesWCF.Services;
using ReferenceCochesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreClientesWCF.Controllers
{
    public class CochesController : Controller
    {
        private ServiceCoches service;

        public CochesController(ServiceCoches service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            Coche[] cars = await this.service.GetCochesAsync();
            return View(cars);
        }

        public async Task<IActionResult> Details(int id)
        {
            Coche car = await this.service.FindCocheAsync(id);
            return View(car);
        }
    }
}
