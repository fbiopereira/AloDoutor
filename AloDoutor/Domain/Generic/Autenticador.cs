namespace AloDoutor.Domain.Generic;

public interface Autenticador
{
    public string Logar(string login, string senha);
    
}