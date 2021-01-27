using TiendaVideojuegos.Comun;

namespace TiendaVideojuegos.Models
{
    public class TVideojuego
    {
        public string CodVideojuego { get; set; }
        public string Nombre { get; set; }
        public string EmpresaDesarrolladora { get; set; }
        public string Genero { get; set; }
        public string EdadRecomendada { get; set; }
        public string Precio { get; set; }
        public string Imagen { get; set; }
        public string Estado { get; set; }
        public string Borrado { get; set; }

        public TVideojuego(string codVideojuego, string nombre, string empresaDesarrolladora, string genero, string edadRecomendada, string precio, string imagen, string borrado)
        {
            this.CodVideojuego = codVideojuego;
            this.Nombre= nombre;
            this.EmpresaDesarrolladora = empresaDesarrolladora;
            this.Genero = genero;
            this.EdadRecomendada = edadRecomendada;
            this.Precio = precio;
            this.Imagen = imagen;
            this.Borrado = borrado;
        }
        public TVideojuego(string nombre, string empresaDesarrolladora, string genero, string edadRecomendada, string precio, string imagen)
        {
            this.CodVideojuego = Util.GenerarCodigo(this.GetType());
            this.Nombre = nombre;
            this.EmpresaDesarrolladora = empresaDesarrolladora;
            this.Genero = genero;
            this.EdadRecomendada = edadRecomendada;
            this.Precio = precio;
            this.Imagen = imagen;
            this.Borrado = "0";
        }
        public TVideojuego() { }

        public override string ToString()
        {
            return CodVideojuego + ": " + Nombre.ToUpper();
        }

    }
}