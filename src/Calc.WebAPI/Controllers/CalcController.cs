using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calc.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {

        [Route("add")]
        [HttpPost]
        public IActionResult Add([FromBody] values value)
        {
            try
            {
                int v1 = Convert.ToInt32(value.value1);
                int v2 = Convert.ToInt32(value.value2);

                return new ObjectResult(v1+v2);
            }
            catch(Exception ex)
            {
                return BadRequest("not valid numbers");
            }
        }
    }

    public class values
    {
        public string value1 { get; set; }
        public string value2 { get; set; }
    }
}
