namespace Aspangular.Domain.DTOs;

public record UsuarioDTO
{
    public string Nome { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Senha { get; set; } = default!;
}
