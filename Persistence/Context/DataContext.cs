using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Persistence.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options) {

        }

        public DbSet<Acitivity> Activities {get; set;}
    }
}