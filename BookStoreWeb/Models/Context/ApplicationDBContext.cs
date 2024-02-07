using BookStoreWeb.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace BookStoreWeb.Models.Context
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
