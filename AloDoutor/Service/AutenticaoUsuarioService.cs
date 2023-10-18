using AloDoutor.Domain.Generic;
using AloDoutor.UseCases;

namespace AloDoutor.Service;

public class AutenticaoUsuarioService : IAutenticaoUsuario
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IConfiguration _configuration;

    public AutenticaoUsuarioService( IConfiguration config, IHttpClientFactory clientFactory)
    {
        _configuration = config;
        _httpClientFactory = clientFactory;

    }
    
    public Usuario Autenticar(Usuario usuario)
    {
        var clientHttp = _httpClientFactory.CreateClient();
        clientHttp.BaseAddress = new Uri("http://localhost:9090/realms/AloDoutor-DEV/.well-known/openid-configuration");
        
        clientHttp.Po

    }
}