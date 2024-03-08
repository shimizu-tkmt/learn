using Microsoft.AspNetCore.Mvc;

namespace SampleMVCApp.Controllers
{
    public class SelectController : Controller
    {
        public List<string> list;
        public SelectController() 
        {
            list = new List<string>();
            list.Add("Japan");
            list.Add("USA");
            list.Add("UK");

        }
        public IActionResult Index()
        {
            ViewData["message"] = "Select item:";
            ViewData["list"] = new string[] {};
            ViewData["listdata"] = list;
            return View();
        }

        [HttpPost]
        public IActionResult Form()
        {
            ViewData["message"] = '"' + Request.Form["list"] + '"' + " selected.";
            ViewData["list"] = Request.Form["list"];
            ViewData["listdata"] = list;
            return View("Index");
        }
    }
}
