using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using gloryhall.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System;

namespace gloryhall.Hubs
{
    [Authorize]
    public class Chathub : Hub
    {
        private AppDBContent db;
        UserManager<User> _userManager;

        public Chathub(AppDBContent dbContext, UserManager<User> userManager)
        {
            this.db = dbContext;
            _userManager = userManager;
        }


        public async Task SendMessage(string message, string _id)

        {
            int id = Convert.ToInt32(_id);
            var userName = Context.User.Identity.Name;
            Message mes = new Message();
            mes.text = message;
            mes.date = DateTime.Now;
            mes.User = await _userManager.GetUserAsync(Context.User);
            mes.Thread = await db.Thread.FindAsync(id);
            db.Messages.Add(mes);
            await db.SaveChangesAsync();
            await Clients.All.SendAsync("ReceiveMessage", userName, message);
            
        }

        public override async Task OnConnectedAsync()
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, "SignalR Users");
            await base.OnConnectedAsync();
        }
    }
}
