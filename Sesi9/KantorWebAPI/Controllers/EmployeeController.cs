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

        public ActionResult<IEnumerable<EmployeeItem>> ListEmployee()
        {
            context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;

            return context.ListEmployee();
        }

        [HttpGet("{id}", Name ="Get")]
        public ActionResult<EmployeeItem> GetEmployee(int id)
        {
            context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;

            return context.GetEmployee(id);
        }
    }
}
