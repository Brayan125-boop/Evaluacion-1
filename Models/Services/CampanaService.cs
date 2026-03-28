using Evaluacion1.Models;

namespace Evaluacion1.Services
{
    public class CampanaService
    {
        private static List<Campana> _campanas = new List<Campana>
        {
            new Campana { Id=1, Nombre="Black Friday Tech", Categoria="Tecnología", Estado="Vigente", FechaInicio=new DateTime(2026,3,1), FechaFin=new DateTime(2026,3,31), DescuentoPct=25, Canal="Web", Descripcion="Descuentos en laptops y celulares" },
            new Campana { Id=2, Nombre="Verano Moda", Categoria="Moda", Estado="Próxima", FechaInicio=new DateTime(2026,4,1), FechaFin=new DateTime(2026,4,30), DescuentoPct=15, Canal="App", Descripcion="Ropa de temporada" },
            new Campana { Id=3, Nombre="Hogar Limpio", Categoria="Hogar", Estado="Finalizada", FechaInicio=new DateTime(2026,1,1), FechaFin=new DateTime(2026,2,28), DescuentoPct=10, Canal="Tienda", Descripcion="Electrodomésticos y limpieza" },
            new Campana { Id=4, Nombre="Cyber Electro", Categoria="Electro", Estado="Vigente", FechaInicio=new DateTime(2026,3,15), FechaFin=new DateTime(2026,4,15), DescuentoPct=30, Canal="Web", Descripcion="TVs y equipos de sonido" },
            new Campana { Id=5, Nombre="Back to School", Categoria="Tecnología", Estado="Próxima", FechaInicio=new DateTime(2026,4,10), FechaFin=new DateTime(2026,5,10), DescuentoPct=20, Canal="App", Descripcion="Útiles y laptops escolares" },
        };

        public List<Campana> ObtenerTodas() => _campanas;

        public Campana? ObtenerPorId(int id) => _campanas.FirstOrDefault(c => c.Id == id);

        public List<Campana> Filtrar(string categoria, string estado)
        {
            var resultado = _campanas.AsQueryable();
            if (!string.IsNullOrEmpty(categoria))
                resultado = resultado.Where(c => c.Categoria == categoria);
            if (!string.IsNullOrEmpty(estado))
                resultado = resultado.Where(c => c.Estado == estado);
            return resultado.ToList();
        }
    }
}