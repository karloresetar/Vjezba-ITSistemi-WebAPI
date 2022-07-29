using ItSistemiWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ItSistemiWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

    }
}
