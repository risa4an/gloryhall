using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace gloryhall.Data.Models
{
    public class AppDBContent : IdentityDbContext<User>
    {

        public DbSet<Thread> Thread { get; set; }
        public DbSet<Match> Match { get; set; }
        public DbSet<Message> Messages { get; set; }
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
        }


    }
}
