using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using gloryhall.Data.Models; // пространство имен моделей и контекста данных

namespace gloryhall.Controllers
{
    public class HomeController : Controller
    {
        private AppDBContent db;
        public HomeController(AppDBContent context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            
            return View(await db.Match.OrderByDescending(p=>p.date).ToListAsync());
        }


        
    }
}