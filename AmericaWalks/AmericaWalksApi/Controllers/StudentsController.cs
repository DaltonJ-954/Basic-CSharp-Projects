using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmericaWalksApi.Controllers
{

    // https://localhost:portnumber/api/name of controller(students)
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //GET: https://localhost:portnumber/api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentsNames = new string[] { "Sylvia", "Nontle", "Linda", "Dalton", "Precious", "Keenan", "Lucky", "Sima"};

            return Ok(studentsNames);
        }
    }
}
