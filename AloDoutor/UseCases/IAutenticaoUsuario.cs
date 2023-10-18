using AloDoutor.Domain.Generic;

namespace AloDoutor.UseCases;

public interface IAutenticaoUsuario
{
    Usuario Autenticar(Usuario usuario);
    
}