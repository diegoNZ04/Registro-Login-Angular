using Aspangular.Domain.DTOs;
using Aspangular.Domain.Entities;
using Aspangular.Domain.Interfaces;
using Aspangular.Infrastructure.Db;

namespace Aspangular.Domain.Services;

public class UsuarioService : IUsuarioService
{
    private readonly DbContexto _contexto;

    public UsuarioService(DbContexto contexto)
    {
        _contexto = contexto;
    }
    
    public Usuario? Cadastro(Usuario usuario)
    {
        _contexto.Usuarios.Add(usuario);
        _contexto.SaveChanges();

        return usuario;
    }

    public Usuario? Login(LoginDTO loginDTO)
    {
        var usuario = _contexto.Usuarios.Where(u => u.Email == loginDTO.Email && u.Senha == loginDTO.Senha).FirstOrDefault();
        return usuario;
    }
}
