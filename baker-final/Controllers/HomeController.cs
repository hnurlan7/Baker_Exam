using baker_final.DAL;
//using baker_final.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace baker_final.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //HomeVM homeVM = new HomeVM();
            //homeVM.Slider = _context.Sliders.ToList();
            return View();
        }
    }
}
