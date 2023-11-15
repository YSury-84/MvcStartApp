using Microsoft.EntityFrameworkCore;
using MvcStartApp.Models.Db;

namespace MvcStartApp.Models.Context
{
    public class LogContext : DbContext
    {
        public DbSet<Request> Requests { get; set; }
        public LogContext(DbContextOptions<LogContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
