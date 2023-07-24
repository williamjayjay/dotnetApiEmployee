using Microsoft.EntityFrameworkCore;
using SegundaAPI.Domain.Model.CompanyAggregate;
using SegundaAPI.Domain.Model.EmployeeAggregate;

namespace SegundaAPI.Infrastructure
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Company { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
            "Server=localhost;" +
            "Port=5432;Database=EMPLOYEE_DB;" +
            "User Id=postgres;" +
            "Password=P@ssw0rd;"
            );
        
    }
}
