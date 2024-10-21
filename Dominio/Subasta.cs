using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Sistema;

namespace Dominio
{
  public class Subasta : Publicacion, IValidable
  {
    #region Atributos
    private List<Oferta> _listaOfertas;
    #endregion

    #region Propiedades
    public static List<Oferta> ListaOfertas { get; set; }
    #endregion

    #region Constructores
    public Subasta(string nombrePublicacion, Estado estadoPublicacion, DateTime fechaPublicacion, List<Oferta> listaOfertas, List<Articulo> listaArticulos) : base(nombrePublicacion, estadoPublicacion, fechaPublicacion, listaArticulos)
    {
      this.NombrePublicacion = nombrePublicacion;
      this.EstadoPublicacion = estadoPublicacion;
      this.FechaPublicacion = fechaPublicacion;
      ListaOfertas = listaOfertas;
      listaArticulos = listaArticulos;
    }
    #endregion

    #region Metodos

    public void Validar()
    {
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
