using Microsoft.EntityFrameworkCore;

namespace EDMIMudblazorProject.Data
{
    public class EmployeeServices
    {
        #region Private members
        private EmployeeDbContext dbContext;
        #endregion

        #region Constructor
        public EmployeeServices(EmployeeDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// This method returns the list of product
        /// </summary>
        /// <returns></returns>
        public async Task<List<Employee>> GetEmployeeAsync()
        {
            return await dbContext.Employee.ToListAsync();
        }

        /// <summary>
        /// This method add a new product to the DbContext and saves it
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            try
            {
                if (employee == null) { Console.WriteLine(employee); }
                dbContext.Employee.Add(employee);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return employee;
        }

        /// <summary>
        /// This method update and existing product and saves the changes
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Employee> UpdateEmployeeAsync(Employee employee)
        {
            try
            {
                var employeeExist = dbContext.Employee.FirstOrDefault(p => p.EmployeeId == employee.EmployeeId);
                if (employeeExist != null)
                {
                    dbContext.Update(employee);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return employee;
        }

        /// <summary>
        /// This method removes and existing product from the DbContext and saves it
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task DeleteEmployeeAsync(Employee employee)
        {
            try
            {
                dbContext.Employee.Remove(employee);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
