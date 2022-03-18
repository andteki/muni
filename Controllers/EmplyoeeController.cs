
using Microsoft.AspNetCore.Mvc;

namespace App01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly DataContext _context;
        public EmployeeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            return Ok(await _context.Employees.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Employee>>> Get(int id)
        {
            var dbEmployee = await _context.Employees.FindAsync(id);
            if (dbEmployee == null) {
                return BadRequest("A dolgozó nem található");
            }
            return Ok(dbEmployee);
        }

        [HttpPost]
        public async Task<ActionResult<List<Employee>>> AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return Ok(await _context.Employees.ToListAsync());
        }
        
        [HttpPut]
        public async Task<ActionResult<List<Employee>>> UpdateEmployee(Employee request)
        {
            var dbEmployee = await _context.Employees.FindAsync(request.Id);
            
            if (dbEmployee == null) {
                return BadRequest("A dolgozó nem található");
            }            
            dbEmployee.Name = request.Name;
            dbEmployee.City = request.City;
            dbEmployee.Salary = request.Salary;

            await _context.SaveChangesAsync();
            _context.Employees.Remove(dbEmployee);
            await _context.SaveChangesAsync();
            return Ok(await _context.Employees.ToListAsync());
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Employee>>> Delete(int id)
        {
            var dbEmployee = await _context.Employees.FindAsync(id);
            if (dbEmployee == null) {
                return BadRequest("A dolgozó nem található");
            }

            _context.Employees.Remove(dbEmployee);
            await _context.SaveChangesAsync();
            return Ok(await _context.Employees.ToListAsync());
        }

    }
}