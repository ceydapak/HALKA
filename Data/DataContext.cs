using Microsoft.EntityFrameworkCore;


namespace _HALKA.Data
{
    public class DataContext :DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Libraries{ get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
     

    }
}
