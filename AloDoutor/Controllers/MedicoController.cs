using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AloDoutor.Controllers;

[ApiController]
[Route("medico")]
public class MedicoController : Controller
{
    [HttpGet]
    [Authorize]
    public IActionResult ListarMedicos()
    {
        return Ok("Listando Médicos");
    }
    
    [HttpPost]
    public IActionResult CadastrarMedico()
    {
        return Ok("Cadastrando Médico");
    }
    
}