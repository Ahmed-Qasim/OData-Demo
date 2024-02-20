using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using OData_Demo.Models;
using OData_Demo.Repos;


namespace OData_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo _EmpRepo;
        public EmployeeController(IEmployeeRepo repo)
        {
            _EmpRepo = repo;
        }
        [HttpGet]
        [EnableQuery]
        public IQueryable<Employee> Get()
        {
            return _EmpRepo.GetAll();
        }




        [EnableQuery]
        [HttpGet("{id}")]
        public SingleResult<Employee> Get([FromODataUri] int key)
        {
            return SingleResult.Create(_EmpRepo.GetById(key));
        }


        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _EmpRepo.Create(employee);

            return Created("employees", employee);
        }

        [HttpPut]
        public IActionResult Put([FromODataUri] int key, [FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (key != employee.Id)
            {
                return BadRequest();
            }
            _EmpRepo.Update(employee);
            return NoContent();
        }


        [HttpDelete]
        public IActionResult Delete([FromODataUri] int key)
        {
            var company = _EmpRepo.GetById(key);
            if (company is null)
            {
                return BadRequest();
            }
            _EmpRepo.Delete(company.First());
            return NoContent();
        }




    }
}
