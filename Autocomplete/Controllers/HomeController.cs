using Autocomplete.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Autocomplete.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        List<customer> liobj = new List<customer>();
        customer obj=new customer();    
       
        [HttpPost]
        public JsonResult AutoComplete(string prefix)
        {
            obj.id = 1;
            obj.customerName = "karan";
            liobj.Add(obj);
            customer bj = new customer();
            bj.id = 2;
            bj.customerName = "kunal";
            liobj.Add(bj);
            customer j = new customer();
            j.id = 3;
            j.customerName = "kunnu";
            liobj.Add(j);
            customer c = new customer();
            c.id = 4;
            c.customerName = "mohit";
            liobj.Add(c);
            var customers = (from customer in liobj
                             where customer.customerName.StartsWith(prefix)
                             select new
                             {
                                 label = customer.customerName,
                                 val = customer.id
                             }).ToList();

            return Json(customers);
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