using Entidades;
namespace DAL

{
    /// <summary>
    /// Metodo que accede a la base de datos para obtener una lista con las misiones a mostrar en la pagina
    /// </summary>
    /// Precondiciones:Se debe validar la conexión a la base de datos
    /// listaMisiones: Lista que contiene todas las misiones a enseñar en la pagina
    public class clsListaMisiones
    {
        public static List<clsMision> obtenerListaMisiones() { 
        List<clsMision> listaMisiones = new List<clsMision>();

            listaMisiones.Add(new clsMision("1","Rescate de Baby Yoda", "Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamiento.", 5000));
            listaMisiones.Add(new clsMision("2", "Recuperar armadura Beskar", "La armadura de Bershka ha sido robada. Debes encontrarla.", 2000, "El Beskar fue utilizado en gran medida por los mandalorianos como parte de su" +
                " iniciativa colectiva para el avance tecnológico. Se vieron obligados durante muchos años a enfrentarse a los Jedi en luchas de poder, pero no pudieron explicar cómo los Jedi usaron la Fuerza para frustrarlos. " +
                "El Beskar ayudó a la causa, e incluso a defenderse de un golpe indirecto de un sable de luz."));
            listaMisiones.Add(new clsMision("3", "Planeta Sorgon", "Debes llevar a un niño de vuelta a su planeta natal “Sorgon”.", 500));
            listaMisiones.Add(new clsMision("4", "Renacuajos", "Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.", 500));

            return listaMisiones;
        }
    }
}