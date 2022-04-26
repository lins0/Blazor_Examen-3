using Modelo;

namespace Blazor_Examen.Interfaces;

public interface IUsuarioServicio
{
    Task<bool> Nuevo(Usuarios usuario);
    Task<bool> Actualizar(Usuarios usuario);
    Task<bool> Eliminar(Usuarios usuario);
    Task<IEnumerable<Usuarios>> GetLista();
    Task<Usuarios> GetPorCodigo(string codigo);

}
