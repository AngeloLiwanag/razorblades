using Microsoft.AspNetCore.Mvc;
namespace Home
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}