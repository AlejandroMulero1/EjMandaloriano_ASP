namespace Entidades
{
    public class clsMision
    {
        public clsMision() { 
        
        }

        public clsMision(String id, String nombreMision, String descripcion, int recompensa) {
            Id = id;
            NombreMision = nombreMision;
            Descripcion = descripcion;
            Recompensa = recompensa;
            Contextualizacion = "";
        }
        public clsMision(String id, String nombreMision, String descripcion, int recompensa, String contextualizacion)
        {
            Id = id;
            NombreMision = nombreMision;
            Descripcion = descripcion;
            Recompensa = recompensa;
            Contextualizacion = contextualizacion;
        }

        public String Id { get; }
        public String NombreMision { get; }
        public String Descripcion { get; }
        public int Recompensa { get; }
        public String Contextualizacion { get; }


    }
}