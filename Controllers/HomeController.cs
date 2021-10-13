using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticleDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PracticleDemoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
      

        public HomeController(ILogger<HomeController> logger)
        {                                  
                 _logger = logger;          
        }

        public IActionResult Index(int id)
        {
            try
            {
                List<Bee> lstDynamic = Call.getList();
                if (id > 0)
                {                  
                    Bee findRecord = lstDynamic.Where(x => x.id == id).FirstOrDefault();
                    return View(findRecord.Damage(id));
                }
                else
                {
                    return View(lstDynamic);
                }
            }
            catch (Exception e)
            {
                throw;
            }
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
