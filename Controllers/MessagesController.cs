using System;
using System.Linq;
using System.Threading.Tasks;
using gloryhall.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace gloryhall.Controllers
{
    [Authorize]
    public class MessagesController : Controller
    {
        private AppDBContent db;
        IWebHostEnvironment _appEnvironment;
        UserManager<User> _userManager;

        public MessagesController(AppDBContent context, IWebHostEnvironment appEnvironment, UserManager<User> userManager)
        {
            db = context;
            _appEnvironment = appEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(int id){
            ViewData["id"] = id;
            var thread = await db.Thread.Include(p => p.match).FirstOrDefaultAsync(p=>p.id == id);
            ViewData["matchId"] = thread.match.id;
            var temp = await db.Messages.Include(p => p.Thread).Include(p=>p.User).Where(p => p.Thread.id == id).OrderBy(p => p.date).ToListAsync();
            return View(temp);
        }

    }
}
