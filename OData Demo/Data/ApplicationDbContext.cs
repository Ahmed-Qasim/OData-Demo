using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using OData_Demo.Models;

namespace OData_Demo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {

            try
            {
                var dataBaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;

                if (dataBaseCreator != null)
                {
                    if (!dataBaseCreator.CanConnect()) dataBaseCreator.Create();
                    if (!dataBaseCreator.HasTables()) dataBaseCreator.CreateTables();
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
             new Employee
             {
                 Id = 1,
                 Name = "Ahmed Kassem",
                 Code = "234",
                 SalaryStatus = "valid",
                 HiringDate = DateTime.Now,
                 JobCode = "5712"

             },
             new Employee
             {
                 Id = 2,
                 Name = "Mohamed Kassem",
                 Code = "235",
                 SalaryStatus = "valid",
                 HiringDate = DateTime.Now,
                 JobCode = "5712"

             }
             ,
             new Employee
             {
                 Id = 3,
                 Name = "Mazen Ali",
                 Code = "236",
                 SalaryStatus = "valid",
                 HiringDate = DateTime.Now,
                 JobCode = "5896"

             },
             new Employee
             {
                 Id = 4,
                 Name = "Taha Emad",
                 Code = "237",
                 SalaryStatus = "unvalid",
                 HiringDate = DateTime.Now,
                 JobCode = "5476"

             }
             );

        }
    }
}
