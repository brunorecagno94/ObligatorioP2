using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Sistema;

namespace Dominio
{
  public class Venta : Publicacion, IValidable
  {
    #region Atributos
    private bool _ofertaRelampago;
    #endregion

    #region Propiedads
    public bool OfertaRelampago { get; set; }
    #endregion

    #region Constructores
    public Venta(bool ofertaRelampago, string nombrePublicacion, Estado estadoPublicacion, DateTime fechaPublicacion, List<Articulo> listaArticulos) : base(nombrePublicacion, estadoPublicacion, fechaPublicacion, listaArticulos)
    {
      this.OfertaRelampago = ofertaRelampago;
      this.NombrePublicacion = nombrePublicacion;
      this.EstadoPublicacion = estadoPublicacion;
      this.FechaPublicacion = fechaPublicacion;
    }
    #endregion

    #region Metodos

    public void Validar()
    {

      if (OfertaRelampago == null)
      {
        throw new Exception("la oferta relampago tiene que estar definida");
      }
      if (string.IsNullOrEmpty(NombrePublicacion))
      {
        throw new Exception("El nombre no puede estar vacío");
      }
      if (EstadoPublicacion == null)
      {
        throw new Exception("El estado no puede estar vacío");
      }
      if (FechaPublicacion == DateTime.MinValue)
      {
        throw new Exception("La fecha no puede ser indefinida");
      }
      if (ListaArticulos == null || ListaArticulos.Count == 0)
      {
        throw new Exception($"la lista de articulos de {NombrePublicacion} no puede estar vacía");
      }
    }
    #endregion
  }
}
