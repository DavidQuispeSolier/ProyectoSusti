namespace ProyectoSusti.Models
{
    public class Matricula
    {
        public int MatriculaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Seccion { get; set; }
        public string Grado { get; set; }

        public bool IsActive { get; set; }
    }
}
