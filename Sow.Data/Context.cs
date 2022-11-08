using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sow.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sow.Data
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Message>().HasOne(x => x.SenderUser).WithMany(y => y.WriterSender).HasForeignKey(z => z.SenderID).OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<Message>().HasOne(x => x.ReceiverUser).WithMany(y => y.WriterReceiver).HasForeignKey(z => z.ReceiverID).OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(builder);
        }




        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }



    }
}
