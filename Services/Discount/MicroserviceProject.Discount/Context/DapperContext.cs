using MicroserviceProject.Discount.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace MicroserviceProject.Discount.Context
{
    public class DapperContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MELI\\SQLEXPRESS; initial Catalog = MicroserviceProjectDiscountDb; integrated Security= true");
        }

        public DbSet<Coupon> Coupons { get; set; }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString); //bu metod çağrıldığında yeni bir sql bağlantısı oluşturma
    }
}
