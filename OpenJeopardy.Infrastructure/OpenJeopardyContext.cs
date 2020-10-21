using Microsoft.EntityFrameworkCore;
using OpenJeopardy.Core.Boards;
using OpenJeopardy.Core.Users;

namespace OpenJeopardy.Infrastructure
{
    public class OpenJeopardyContext : DbContext
    {
        public OpenJeopardyContext(DbContextOptions<OpenJeopardyContext> options) : base(options)
        {
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<User> Users { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSql("");
        //}
    }
}