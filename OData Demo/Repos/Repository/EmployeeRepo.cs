using OData_Demo.Data;
using OData_Demo.Models;

namespace OData_Demo.Repos.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<Employee> GetAll()
        {
            return _context.Employees
                .AsQueryable();
        }


        public IQueryable<Employee> GetById(int id)
        {
            return

               _context.Employees.AsQueryable()
            .Where(c => c.Id == id);
        }
        public void Create(Employee employee)
        {
            _context.Employees
                .Add(employee);
            _context.SaveChanges();
        }
        public void Update(Employee employee)
        {
            _context.Employees
                .Update(employee);
            _context.SaveChanges();
        }
        public void Delete(Employee employee)
        {
            _context.Employees
                .Remove(employee);
            _context.SaveChanges();
        }
    }
}

