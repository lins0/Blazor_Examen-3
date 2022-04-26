using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces;

public interface IUsuarioRepositorio
{
    Task<bool> Nuevo(Usuarios usuario);
    Task<bool> Actualizar(Usuarios usuario);
    Task<bool> Eliminar(Usuarios usuario);
    Task<IEnumerable<Usuarios>> GetLista();
    Task<Usuarios> GetPorCodigo(string codigo);
    
}
