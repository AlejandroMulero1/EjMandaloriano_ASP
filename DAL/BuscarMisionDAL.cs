using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BuscarMisionDAL
    {
        /// <summary>
        /// Metodo que recibe una id y la compara con la lista de misiones para encontrar la lista de misiones
        /// Precondicion: El id debe ser un numero valido
        /// </summary>
        /// <param name="id">Id de la mision seleccionada</param>
        /// <returns></returns>
        public static clsMision obtenerMisionPorId(String id)
        {
            List<clsMision> listaMisiones = clsListaMisiones.obtenerListaMisiones();
            clsMision misionElegida = new clsMision();
            foreach (clsMision mision in listaMisiones)
            {
                if (mision.Id == id)
                {
                    misionElegida = mision;
                }
            }
            return misionElegida;
        }
    }
}
