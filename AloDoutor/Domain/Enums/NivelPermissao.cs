namespace AloDoutor.Domain.Enums;

public enum NivelPermissao
{
 Administrador = 1,
 Medico = 2,
 Paciente = 3,
 Secretaria = 4,
 Enfermagem = 5
}

public static class Permissao
{
 public const string Administrador = "Administrador";
 public const string Medico = "Médico";
 public const string Paciente = "Paciente";
 public const string Secretaria = "Secretaria";
 public const string Enfermagem = "Enfermagem";

}