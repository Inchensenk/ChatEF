using ChatEF.Entities;
using ChatEF.Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatEF
{
    public class ApplicationContext : DbContext
    {
        private readonly StreamWriter logStream = new StreamWriter("mylog.txt", true);

   
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Conversation> conversations { get; set; }
        public DbSet<Authorization> Authorizations { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
            var canConnect = Database.CanConnect();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb; Database=ChatEF; Trusted_Connection=True; Encrypt=false");
            optionsBuilder.UseSqlServer(@"Data Source=s-dev-01; Database=ChatEF; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            
        }



        public override async ValueTask DisposeAsync()
        {
            await base.DisposeAsync();
            await logStream.DisposeAsync();
        }
    }
}
