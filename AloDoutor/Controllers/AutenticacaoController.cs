using Microsoft.AspNetCore.Mvc;

namespace AloDoutor.Controllers;

[ApiController]
[Route("autenticacao")]
public class AutenticacaoController : Controller
{
    [HttpPost]
    public IActionResult Login()
    {
        return Ok("Logando");
    }
}