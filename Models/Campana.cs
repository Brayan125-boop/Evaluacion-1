// Models/Campana.cs
namespace Evaluacion1.Models
{
    public class Campana
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public double DescuentoPct { get; set; }
    public string Canal { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
}
}