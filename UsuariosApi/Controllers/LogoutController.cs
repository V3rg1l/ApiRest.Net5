using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogoutController : ControllerBase
    {
        private LogoutService _logoutService;

        public LogoutController(LogoutService logoutService)
        {
            _logoutService = logoutService;
        }

        [HttpPost]
        public ActionResult DeslogaUsuario()
        {
            Result resultado =  _logoutService.DeslogaUsuario();
            if (resultado.IsFailed) return Unauthorized();
            return Ok(resultado.Successes);
        }
    }
}
