using Microsoft.AspNetCore.Mvc;
using MvcCoreClientesWCF.Services;
using ServicioCountries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreClientesWCF.Controllers
{
    public class CountriesController : Controller
    {
        private ServiceCountries service;

        public CountriesController(ServiceCountries service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            tCountryCodeAndName[] countries =
                await this.service.GetCountries();
            return View(countries);
        }

        public async Task<IActionResult> CountryInfo(string isocode)
        {
            tCountryInfo country =
                await this.service.GetCountryInfo(isocode);
            return View(country);
        }
    }
}
