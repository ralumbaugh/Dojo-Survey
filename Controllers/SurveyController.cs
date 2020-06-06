using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("submit")]
        public ViewResult submit(string Name, string Location, string Language, string Comment)
        {
            Survey mySurvey = new Survey(Name,Location,Language,Comment);
            return View("result", mySurvey);
        }
    }
}