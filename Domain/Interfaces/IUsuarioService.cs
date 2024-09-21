using Aspangular.Domain.DTOs;
using Aspangular.Domain.Entities;

namespace Aspangular.Domain.Interfaces;

public interface IUsuarioService
{
    Usuario? Cadastro(Usuario usuario);
    Usuario? Login(LoginDTO loginDTO);
}
