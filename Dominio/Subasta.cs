using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Subasta : Publicacion
  {
    private Oferta[] _ListaOfertas;

        public Subasta(int IdPublicacion, string NombrePublicacion, string EstadoPublicacion, DateTime FechaPublicacion, string ClienteComprador, string UsuarioFinalizador, DateTime FechaFin, Articulo Articulopub, Articulo listaArticulo) : base(IdPublicacion, NombrePublicacion, EstadoPublicacion, FechaPublicacion, ClienteComprador, UsuarioFinalizador, FechaFin, listaArticulos)
        {
        }
    }
}
