using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oragon.Spring.GetStarted.Model;

namespace Oragon.Spring.GetStarted.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<OragonSpringExample> Get([FromServices] OragonSpringExample oragonSpringExample)
        {
            return oragonSpringExample;
        }

    }
}
