using OData_Demo.Models;

namespace OData_Demo.Repos
{
    public interface IEmployeeRepo
    {
        public IQueryable<Employee> GetAll();
        public IQueryable<Employee> GetById(int id);
        public void Create(Employee employee);
        public void Update(Employee employee);
        public void Delete(Employee employee);
    }
}
