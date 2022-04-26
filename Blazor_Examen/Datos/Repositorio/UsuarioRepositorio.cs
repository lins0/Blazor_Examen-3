using Dapper;
using Datos.Interfaces;
using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorio;

public class UsuarioRepositorio : IUsuarioRepositorio
{

    private string CadenaConexion;
    public UsuarioRepositorio(string cadenaconexion)
    {
        CadenaConexion = cadenaconexion;
    }
    private MySqlConnection Conexion()
    {
        return new MySqlConnection(CadenaConexion);
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
        IEnumerable<Usuarios> lista = new List<Usuarios>();
        try
        {
            using MySqlConnection conexion = Conexion();
            await conexion.OpenAsync();
            string sql = "SELECT * FROM usuario;";
            lista = await conexion.QueryAsync<Usuarios>(sql);
        }
        catch (Exception ex)
        {

        }
        return lista;
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
