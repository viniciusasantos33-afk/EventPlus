using EventPlus.WebAPI.BdContextEvent;
using EventPlus.WebAPI.Interfaces;
using EventPlus.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EventPlus.WebAPI.Repositories;

public class TipoUsuarioRepository: ITipoUsuario
{

    private readonly EventContext _eventContext;
    
    public TipoUsuarioRepository(EventContext context)
    {
        _eventContext = context;
    }
    
    public async Task Cadastrar(TipoUsuario tipoUsuario)
    {
        throw new NotImplementedException();
    }

    public async Task<List<TipoUsuario>> Listar()
    {
        return await _eventContext.TipoUsuario.AsNoTracking().ToListAsync();
    }

    public async Task Atualizar(Guid id, TipoUsuario tipoUsuario)
    {
        throw new NotImplementedException();
    }

    public async Task Deletar(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<TipoUsuario> BuscarPorId(Guid id)
    {
        throw new NotImplementedException();
    }
}