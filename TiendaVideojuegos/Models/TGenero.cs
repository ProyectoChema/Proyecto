namespace TiendaVideojuegos.Models
{
    public class TGenero
    {
        public string Genero { get; set; }
        public string Borrado { get; set; }

        public TGenero()
        {
        }

        public TGenero(string genero)
        {
            this.Genero = genero;
        }

    }
}