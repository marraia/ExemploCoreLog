using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExemploCoreLog.Controllers
{
    [Produces("application/json")]
    [Route("api/Cidade")]
    public class CidadeController : Controller
    {
        private readonly ILogger _logger;
        public CidadeController(ILogger<CidadeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            _logger.LogInformation(1002, "GET {ID} item", id);

            return Ok();
        }
    }
}