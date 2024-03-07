using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using WebApi_Swagger.Models;
using WebApi_Swagger.Services;


namespace WebApi_Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IServicesStudent servicesStudent;
        public StudentController(IServicesStudent servicesStudent) { 
            this.servicesStudent= servicesStudent;
        }

         
        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return servicesStudent.Get();
        }

         
        [HttpGet("{id}")]
        public ActionResult<Student> Get(string id)
        {
            var student = servicesStudent.Get(id);
            if (student == null)
            {
                return NotFound("Student not found");
            }
            return student;

      
        }
 
        [HttpPost]
        public ActionResult<Student> Post([FromBody] Student student)
        {
            servicesStudent.Create(student);
            return CreatedAtAction(nameof(Get), new { id = student.Id }, student);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
