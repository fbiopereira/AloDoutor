using AloDoutor.Domain.Enums;

namespace AloDoutor.Domain.Generic;

public interface Usuario
{
    public string Nome { get; set; }
    public string Login { get; set; }
    public string Senha { get; set; }
    public NivelPermissao NivelPermissao { get; set; }
    
    
    
    
}