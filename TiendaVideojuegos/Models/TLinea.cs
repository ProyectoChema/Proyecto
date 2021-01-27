using TiendaVideojuegos.Comun;

namespace TiendaVideojuegos.Models
{
    public class TLinea
    {
        public string CodFactura { get; set; }
        public string Videojuego { get; set; }
        public string Cantidad { get; set; }
        public string Total { get; set; }

        public TLinea(string codFactura, string videojuego, string cantidad, string total)
        {
            CodFactura = codFactura;
            Videojuego = videojuego;
            Cantidad = cantidad;
            Total = total;
        }

        public TLinea(string videojuego, string cantidad, string total)
        {
            CodFactura = Util.GenerarCodigo(this.GetType());
            Videojuego = videojuego;
            Cantidad = cantidad;
            Total = total;
        }

        public TLinea() { }

        public override string ToString()
        {
            return CodFactura + ": " + Videojuego.ToUpper();
        }
    }
}