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

        [HttpPost("Submit")]
        public IActionResult Submit(Survey survey)
        {
            if(ModelState.IsValid)
            {
                return View("result", survey);
            }
            else
            {
                return View("Index");
            }
        }
    }
}