using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bootstrap_cons_api.Models;
using bootstrap_cons_api.Services;

namespace bootstrap_cons_api.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult MegaSena()
        {
            return View();
        }
        public IActionResult Quina()
        {
            var obj = new ServicesDataResponse().GetDataResponse("https://lotericas.io/api/v1/jogos/quina/lasted");
            Console.WriteLine(obj.Data[0].TipoJogo);
            return View();
        }

        public IActionResult Federal()
        {
            var obj = new ServicesDataResponse().GetDataResponse("https://lotericas.io/api/v1/jogos/federal/lasted");
            Console.WriteLine(obj.Data[0].TipoJogo);
            return View();
        }

        public IActionResult Duplasena()
        {
            var obj = new ServicesDataResponse().GetDataResponse("https://lotericas.io/api/v1/jogos/duplasena/lasted");
            Console.WriteLine(obj.Data[0].TipoJogo);
            return View();
        }

        public IActionResult Loteca()
        {
            var obj = new ServicesDataResponse().GetDataResponse("https://lotericas.io/api/v1/jogos/loteca/lasted");
            Console.WriteLine(obj.Data[0].TipoJogo);
            return View();
        }

        public IActionResult Lotofacil()
        {
            var obj = new ServicesDataResponse().GetDataResponse("https://lotericas.io/api/v1/jogos/lotofacil/lasted");
            Console.WriteLine(obj.Data[0].TipoJogo);
            return View();
        }

        public IActionResult Lotomania()
        {
            var obj = new ServicesDataResponse().GetDataResponse("https://lotericas.io/api/v1/jogos/lotomania/lasted");
            Console.WriteLine(obj.Data[0].TipoJogo);
            return View();
        }

        public IActionResult Timemania()
        {
            var obj = new ServicesDataResponse().GetDataResponse("https://lotericas.io/api/v1/jogos/timemania/lasted");
            Console.WriteLine(obj.Data[0].TipoJogo);
            return View();
        }

        public IActionResult Diadesorte()
        {
            var obj = new ServicesDataResponse().GetDataResponse("https://lotericas.io/api/v1/jogos/diadesorte/lasted");
            Console.WriteLine(obj.Data[0].TipoJogo);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
