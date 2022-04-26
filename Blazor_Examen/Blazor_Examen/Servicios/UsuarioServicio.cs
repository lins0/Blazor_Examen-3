using Blazor_Examen.Data;
using Blazor_Examen.Interfaces;
using Datos.Interfaces;
using Datos.Repositorio;
using Modelo;

namespace Blazor_Examen.Servicios;

public class UsuarioServicio : IUsuarioServicio
{

    private readonly MySQLConfiguration _configuration;
    private  IUsuarioRepositorio usuarioRepositorio;

    public UsuarioServicio(MySQLConfiguration configuration)
    {
        _configuration = configuration;
         usuarioRepositorio = new UsuarioRepositorio(configuration.CadenaConexion);
    }
    public Task<bool> Actualizar(Usuarios usuario)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(Usuarios usuario)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Usuarios>> GetLista()
    {
        return await usuarioRepositorio.GetLista();
    }

    public Task<Usuarios> GetPorCodigo(string codigo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Nuevo(Usuarios usuario)
    {
        throw new NotImplementedException();
    }
}
