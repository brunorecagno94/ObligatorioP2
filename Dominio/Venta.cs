using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Venta : Publicacion
  {
    #region Atributos
    private bool _ofertaRelampago;
    #endregion

    #region Constructores
    public Venta(int IdPublicacion, string NombrePublicacion, string EstadoPublicacion, DateTime FechaPublicacion, string ClienteComprador, string UsuarioFinalizador, DateTime FechaFin, Articulo Articulopub, Articulo listaArticulo) : base(IdPublicacion, NombrePublicacion, EstadoPublicacion, FechaPublicacion, ClienteComprador, UsuarioFinalizador, FechaFin, listaArticulos)
    {
    }
    #endregion
  }
}
