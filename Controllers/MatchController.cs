using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using gloryhall.Data.Models;
using gloryhall.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace gloryhall.Controllers

{
    public class MatchController : Controller
    {
        private AppDBContent db;
        IWebHostEnvironment _appEnvironment;
        UserManager<User> _userManager;
        public MatchController(AppDBContent context, IWebHostEnvironment appEnvironment, UserManager<User> userManager)
        {
            db = context;
            _appEnvironment = appEnvironment;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(int id)
        {
            //var match = db.Match.Where(p => p.id == id).ToArray();
            //Thread thread = new Thread();
            //thread.name = "Test";
            //thread.match = match[0];
            //db.Thread.Add(thread);
            //await db.SaveChangesAsync();
            ViewData["id"] = id;
            return View(await db.Thread.Include(p=>p.match).Where(p => p.match.id == id).ToListAsync());
        }

        public async Task<IActionResult> Edit(int id)
        {
            Match match = await db.Match.FindAsync(id);
            if (match == null)
            {
                return NotFound();
            }
            else
            {
                EditMatchViewModel model = new EditMatchViewModel { id = id, name = match.name, team1 = match.team1, team2 = match.team2, scoresTeam1 = match.scoresTeam1, scoresTeam2 = match.scoresTeam2 };
                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditMatchViewModel model)
        {
            if (ModelState.IsValid)
            {
                Match match = await db.Match.FindAsync(model.id);
                if (match != null)
                {
                    match.name = model.name;
                    match.team1 = model.team1;
                    match.team2 = model.team2;
                    match.scoresTeam1 = Convert.ToSByte(model.scoresTeam1);
                    match.scoresTeam2 = Convert.ToSByte(model.scoresTeam2);

                    await db.SaveChangesAsync();
                    
                    return RedirectToAction("Index", "Home");   
                }
            }
            return View(model);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(CreateMatchViewModel model)
        {
            if (ModelState.IsValid)
            {
                Match match = new Match();
                match.name = model.name;
                match.team1 = model.team1;
                match.team2 = model.team2;
                match.scoresTeam1 = Convert.ToSByte(model.scoresTeam1);
                match.scoresTeam2 = Convert.ToSByte(model.scoresTeam2);
                match.img = model.img.FileName;
                match.date = DateTime.Now;
                // путь к папке Files
                string path = "/img/" + model.img.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await model.img.CopyToAsync(fileStream);
                }
                db.Match.Add(match);
                await db.SaveChangesAsync();
                
                return RedirectToAction("Index", "Home");
                
            }
            return View(model);
        }

        public IActionResult CreateThread(int id){
            CreateThreadViewModel model = new CreateThreadViewModel { id = id };
            return View(model);
        }
        

        [HttpPost]
        public async Task<IActionResult> CreateThread(CreateThreadViewModel model)
        {
            if (ModelState.IsValid)
            {
                Thread thread = new Thread();
                Match match = db.Match.Find(model.id);
                thread.match = match;
                thread.name = model.name;
                thread.user = await _userManager.GetUserAsync(User);
                
                db.Thread.Add(thread);
                await db.SaveChangesAsync();

                return RedirectToAction("Index", "Match", new { id = model.id });

            }
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> DeleteThread(string id)
        {
            Thread thread = await db.Thread.Include(p=>p.match).FirstOrDefaultAsync(i => i.id == Convert.ToInt32(id));
            var messages = await db.Messages.Include(p => p.Thread).Where(p => p.Thread.id == Convert.ToInt32(id)).ToListAsync();
            if (messages != null)
            {
                db.Messages.RemoveRange(messages);
                await db.SaveChangesAsync();
            }
            if (thread != null)
            {
                db.Thread.Remove(thread);
                await db.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Match", new { id = thread.match.id });
        }

        [HttpPost]
        public async Task<ActionResult> Delete(string id)
        {
            Match match = await db.Match.FindAsync(Convert.ToInt32(id));
            
            if (match != null)
            {
                db.Match.Remove(match);
                await db.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
