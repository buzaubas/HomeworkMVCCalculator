using Microsoft.AspNetCore.Mvc;

namespace HomeworkMVCCalculator.Controllers
{
    public class CalcController : Controller
    {
          public IActionResult Index()
        {
            return View();
        }

        [Route("[controller]/Add/{num1:int}/{num2:int}")]
        public IActionResult Add(int num1 = 0, int num2 = 0)
        {
            ViewBag.Result = (num1 + num2).ToString();
            return View();
        }

        [Route("[controller]/Mul/{num1:int}/{num2:int}")]
        public IActionResult Mul(int num1 = 0, int num2 = 0)
        {
            ViewBag.Result = (num1 * num2).ToString();
            return View();
        }

        [Route("[controller]/Div/{num1:int}/{num2:int}")]
        public IActionResult Div(int num1 = 0, int num2 = 1)
        {
            ViewBag.Result = (num1 / num2).ToString();
            return View();
        }

        [Route("[controller]/Sub/{num1:int}/{num2:int}")]
        public IActionResult Sub(int num1 = 0, int num2 = 0)
        {
            ViewBag.Result = (num1 - num2).ToString();
            return View();
        }
    }
}
