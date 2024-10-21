using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Sistema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio
{
  public class Publicacion
  {
    #region Atributos

    private static int _idPublicacionGlobal = 0;
    private int _idPublicacion;
    private string _nombrePublicacion;
    private Estado _estadoPublicacion;
    private DateTime _fechaPublicacion;
    private Cliente _clienteComprador;
    private Cliente _usuarioFinalizador;
    private DateTime _fechaFin;
    private static List<Articulo> _listaArticulos;
    #endregion

    #region Propiedades
    public int IdPublicacion
    {
      get { return _idPublicacion; }
      private set { _idPublicacion = value; }
    }
    public string NombrePublicacion { get; set; }
    public Estado EstadoPublicacion { get; set; }
    public DateTime FechaPublicacion { get; set; }
    public Cliente ClienteComprador { get; set; }
    public Cliente UsuarioFinalizador { get; set; }
    public DateTime FechaFin { get; set; }
    public static List<Articulo> ListaArticulos { get; set; }

    #endregion

    #region Constructores
    public Publicacion(string nombrePublicacion, Estado estadoPublicacion, DateTime fechaPublicacion, List<Articulo> listaArticulos)
    {
      IdPublicacion = _idPublicacionGlobal++;
      this.NombrePublicacion = nombrePublicacion;
      this.EstadoPublicacion = estadoPublicacion;
      this.FechaPublicacion = fechaPublicacion;
      ListaArticulos = listaArticulos;
    }
    #endregion

    #region Métodos
    public override string ToString()
    {
      return
      $"\nNombre: {NombrePublicacion}" +
      $"\nID: {IdPublicacion}" +
      $"\nEstado: {EstadoPublicacion}" +
      $"\nFecha de publicación: {FechaPublicacion}";
    }
    #endregion
  }
}

