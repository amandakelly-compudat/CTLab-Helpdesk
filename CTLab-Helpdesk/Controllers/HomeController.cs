using Microsoft.AspNetCore.Mvc;

namespace CTLabHelpdesk.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MainScreen()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Administration()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult MemberMaint()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Annuity()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult ContractorMaint()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult ContractorRemit()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Reciprocity()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Pension()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult HealthWelfare()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Accounts()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult EoyProcessing()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Tour()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}