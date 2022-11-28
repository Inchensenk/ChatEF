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

        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MessageStatus> MessageStatuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserChatLink> UserChatLinks { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
            var canConnect = Database.CanConnect();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb; Database=CHAT; Trusted_Connection=True; Encrypt=false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*OnUserCreated(modelBuilder);*/
            modelBuilder.ApplyConfiguration(new ChatConfiguration());
            modelBuilder.ApplyConfiguration(new MessegeConfiguration());
            modelBuilder.ApplyConfiguration(new UserChatLinkConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new MessageStatusConfigarition());

        }

        /*private void OnUserCreated(ModelBuilder modelBuilder)
        {
            //данные пользователя сохраненные после регистрации
        }*/

        public override async ValueTask DisposeAsync()
        {
            await base.DisposeAsync();
            await logStream.DisposeAsync();
        }
    }
}
