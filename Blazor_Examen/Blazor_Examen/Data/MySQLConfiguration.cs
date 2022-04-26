namespace Blazor_Examen.Data
{
    public class MySQLConfiguration
    {
        public string CadenaConexion { get; }
        public MySQLConfiguration(string cadenaconexion)
        {
            CadenaConexion = cadenaconexion;
        }
           
    }
}
