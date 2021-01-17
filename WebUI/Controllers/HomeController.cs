using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ResponseStates.Enums;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WebUI.Models;
using WebUI.MWAccess.Abstract;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMWClient _mwClient;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IMWClient mwClient, ILogger<HomeController> logger)
        {
            _mwClient = mwClient;
            _logger = logger;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Ekle")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Ekle")]
        public IActionResult Create(Person person)
        {
            if (!ModelState.IsValid)
                return View(person);

            var response = _mwClient.PostJSON(new Connection<Person>()
            {
                Controller = "Person",
                Model = person
            });

            if (!response.Status.Success)
            {
                ViewBag.Error = response.Status.Message;
                return View(person);
            }
            else
                ModelState.Clear();

            ViewBag.Message = response.Status.Message;
            return View();
        }

        [HttpGet("Liste")]
        public IActionResult List()
        {
            var response = _mwClient.GetJSON<List<Person>>(new Connection()
            {
                Controller = "Person"
            });

            return View(response.Content);
        }

        [HttpGet("Detay/{id}")]
        public IActionResult Detail(int id)
        {
            var response = _mwClient.GetJSON<Person>(new Connection()
            {
                Controller = "Person",
                Query = id.ToString()
            });

            return View(response.Content);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
