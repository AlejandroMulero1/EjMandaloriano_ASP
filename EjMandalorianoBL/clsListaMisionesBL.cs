using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjMandalorianoBL
{
    /// <summary>
    /// Metodo que impone las reglas de negocio a la lista de misiones retornada por la DAL
    /// Precondiciones: Ninguna
    /// Postcondiciones:Ninguna
    /// </summary>
    public class clsListaMisionesBL
    {
        public static List<clsMision> obtenerListaMisiones()
        {
            List<clsMision> mision;
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                mision = null;
            }
            else { 
            mision= clsListaMisiones.obtenerListaMisiones();
            }

            return mision;
        }
    }
}

