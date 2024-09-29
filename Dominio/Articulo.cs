using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Articulo
  {
    #region Atributos
    public static int _idArticulo = 1;
    private string _nombreArticulo;
    private string _categoriaArticulo;
    private int _precioArticulo;
    #endregion

    #region Propiedades
    public int IdArticulo { get; }
    public string NombreArticulo { get; set; }
    public string CategoriaArticulo { get; set; }
    public int PrecioArticulo { get; set; }
    #endregion

    #region Constructores
    public Articulo(string nombreArticulo, string categoriaArticulo, int precioArticulo)
    {
      IdArticulo = _idArticulo++;
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
    #endregion
  }
}
