using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Articulo : IValidable
  {
    #region Atributos
    private static int _idArticuloGlobal = 0;
    private int _idArticulo;
    private string _nombreArticulo;
    private string _categoriaArticulo;
    private int _precioArticulo;
    #endregion

    #region Propiedades
    public int IdArticulo
    {
      get { return _idArticulo; }
      private set { _idArticulo = value; }
    }
    public string NombreArticulo { get; set; }
    public string CategoriaArticulo { get; set; }
    public int PrecioArticulo { get; set; }
    #endregion

    #region Constructores
    public Articulo(string nombreArticulo, string categoriaArticulo, int precioArticulo)
    {
      IdArticulo = _idArticuloGlobal++;
      NombreArticulo = nombreArticulo;
      CategoriaArticulo = categoriaArticulo;
      PrecioArticulo = precioArticulo;


    }
    #endregion

    #region Métodos
    public override string ToString()
    {
      return $"Nombre: {NombreArticulo}" +
      $"\nID: {IdArticulo}" +
      $"\nCategoría: {CategoriaArticulo}" +
      $"\nPrecio: {PrecioArticulo}";
    }

    public void Validar()
    {
      if (string.IsNullOrEmpty(NombreArticulo))
      {
        throw new Exception("El nombre no puede estar vacio");
      }

      if (string.IsNullOrEmpty(CategoriaArticulo))
      {
        throw new Exception("La categoria no puede estar vacia");
      }

      if (PrecioArticulo <= 0)
      {
        throw new Exception("El precio del articulo debe ser mayor que 0");
      }
    }
    #endregion
  }
}
