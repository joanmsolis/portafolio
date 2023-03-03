using portafolio.Models;

namespace portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyactos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyactos()
        {
            return new List<Proyecto>() {new Proyecto
            {
               Titulo = "Amazon",
               Descripcion = "E-Commerce ralizado en ASP.NET core",
               Link = "https://amazon.com",
               ImagenURL = "/img/amazon.png"
            },
                  new Proyecto
            {
               Titulo = "New york Time",
               Descripcion = "Pagina de noticia en react",
               Link = "https://nytime.com",
               ImagenURL = "/img/newyork.png"
            },
                   new Proyecto
            {
               Titulo = "steam",
               Descripcion = "tiendas en linea para comprar videos juegos",
               Link = "https://store.steampowerd.com",
               ImagenURL = "/img/steam.jpg"
            },
                    new Proyecto
            {
               Titulo = "Reddit",
               Descripcion = "REd sociales para compartir en comunidades",
               Link = "https://reddit.com",
               ImagenURL = "/img/reddit.png"
            },
        };
        }
    }
}
