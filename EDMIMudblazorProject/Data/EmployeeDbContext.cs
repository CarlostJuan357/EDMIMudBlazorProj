using Microsoft.EntityFrameworkCore;

namespace EDMIMudblazorProject.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(GetEmployees());
            base.OnModelCreating(modelBuilder);
        }

        private List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee { EmployeeId = 1001, FirstName = "Andrew", LastName = "Tate", Email = "testEmail@gmail.com", PhoneNumber ="+639521087463", HireDate=DateTime.Now, JobTitle="Senior Dev", Salary=60000.00, DepartmentName="Internal"},
                new Employee { EmployeeId = 1002, FirstName = "Tiger", LastName = "Woods", Email = "testEmail@gmail.com", PhoneNumber ="+639521087463", HireDate=DateTime.Now, JobTitle="Senior Dev", Salary=60000.00, DepartmentName="Internal"},
                new Employee { EmployeeId = 1003, FirstName = "Prince", LastName = "Charles", Email = "testEmail@gmail.com", PhoneNumber ="+639521087463", HireDate=DateTime.Now, JobTitle="Senior Dev", Salary=60000.00, DepartmentName="Internal"},
                new Employee { EmployeeId = 1004, FirstName = "John", LastName = "Wick", Email = "testEmail@gmail.com", PhoneNumber ="+639521087463", HireDate=DateTime.Now, JobTitle="Senior Dev", Salary=60000.00, DepartmentName="Internal"},
                new Employee { EmployeeId = 1005, FirstName = "Nice", LastName = "Guy", Email = "testEmail@gmail.com", PhoneNumber ="+639521087463", HireDate=DateTime.Now, JobTitle="Senior Dev", Salary=60000.00, DepartmentName="Internal"},
                new Employee { EmployeeId = 1006, FirstName = "Nate", LastName = "Diaz", Email = "testEmail@gmail.com", PhoneNumber ="+639521087463", HireDate=DateTime.Now, JobTitle="Senior Dev", Salary=60000.00, DepartmentName="Internal"},
                new Employee { EmployeeId = 1007, FirstName = "Lionel", LastName = "Messi", Email = "testEmail@gmail.com", PhoneNumber ="+639521087463", HireDate=DateTime.Now, JobTitle="Senior Dev", Salary=60000.00, DepartmentName="Internal"},
            };
        }

    }
}
