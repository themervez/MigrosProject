using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.Entities;

namespace DAL.DbContexts
{
    public class MigrosDbContext:DbContext
    {
        //DI
        private IConfiguration _configuration;
        public MigrosDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public DbSet<AdressDetails> AdressDetailses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPassword> UserPasswords { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //SQL Connection with ORM
            //base.OnConfiguring(optionsBuilder.UseSqlServer("Server=.;Database=Migros;Trusted_Connection=True"));

            var connectionString = _configuration.GetConnectionString("MsComm");//From appsettings.Development.json file
            base.OnConfiguring(optionsBuilder.UseSqlServer(connectionString));
        }
    }
}
