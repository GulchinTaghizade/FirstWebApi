using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        string[] Cities = { "Baku", "Moscow", "Paris", "Tokio" };
        public string[] Get()
        {
            return Cities;
        }
    }
}
