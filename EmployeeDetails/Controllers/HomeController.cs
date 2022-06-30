using Employee_DetailsAPI.Models;
using EmployeeDetails.Helper;
using EmployeeDetails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeDetails.Controllers
{
   
    public class HomeController : Controller
    {
        EmployeeApi _empapi = new EmployeeApi();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<EmployeeWeb> employeeapi = new List<EmployeeWeb>();
            HttpClient client = _empapi.Initial();
            HttpResponseMessage response = await client.GetAsync("api/employeedetails");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                employeeapi = JsonConvert.DeserializeObject<List<EmployeeWeb>>(result);
            }


            return View(employeeapi);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
