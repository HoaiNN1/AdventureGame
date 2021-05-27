using Adventure.Commom.Models;
using Microsoft.EntityFrameworkCore;

namespace Adventure.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Character> Characters { get; set; }
    }
}
