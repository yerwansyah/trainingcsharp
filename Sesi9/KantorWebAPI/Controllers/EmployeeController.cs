using KantorWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace KantorWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeContext context;

        public EmployeeController(EmployeeContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<EmployeeItem>> ListEmployee()
        {
            context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;

            return context.ListEmployee();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<EmployeeItem> GetEmployee(int id)
        {
            context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;

            return context.GetEmployee(id);
        }
    }
}
