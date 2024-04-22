namespace HernanJurado_Progreso1.Models
{
    public class Estudiantes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Apellido { get; set; }
        public DateOnly? Fecha { get; set; }
        public Boolean? Inscrito { get; set; }
        public decimal? Matricula { get; set; }
    }
}
