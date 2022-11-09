using DAL;
using Entidades;

namespace EjMandalorianoBL
{
    /// <summary>
    /// Metodo que impone las reglas de negocio a la busqueda de misiones retornada por la DAL
    /// Precondiciones: Ninguna
    /// Postcondiciones:Ninguna
    /// </summary>
    public class BuscarMisionBL
    {
        public static clsMision obtenerMisionPorIdBL(String id)
        {
            return BuscarMisionDAL.obtenerMisionPorId(id);
        }
        
    }
}
