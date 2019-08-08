using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCore.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public async Task<int[]> Get()
        {
            return Enumerable.Range(0, 100).ToArray();
        }
    }
}