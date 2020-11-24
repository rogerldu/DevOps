using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace MicroService.Controllers
{
    /// <summary>
    /// API controller for DevOps example
    /// </summary>

    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class DevOpsController : ControllerBase
    {
        private readonly ILogger<DevOpsController> _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger"></param>
        public DevOpsController(ILogger<DevOpsController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Show a message
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ResponseModel Post([FromBody] RequestModel model)
        {
            var response = new ResponseModel();
            if (model == null)
            {
                response.message = "ERROR";
                return response;
            }
            response.message = $"Hello { model.to } your message will be send";
            return response;
        }
    }
}
