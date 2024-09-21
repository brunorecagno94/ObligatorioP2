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
    public static int _idArticulo;
    private string _nombreArticulo;
    private string _categoriaArticulo;
    private int _precioArticulo;
    #endregion

    #region Propiedades
    public int IdArticulo { get; set; }
    public string NombreArticulo { get; set; }
    public string CategoriaArticulo { get; set; }
    public int PrecioArticulo { get; set; }
    #endregion

    #region Constructores
    public Articulo(int id, string nombre, string categoria, int precio)
    {
      _idArticulo = id;
      NombreArticulo = nombre;
      CategoriaArticulo = categoria;
      PrecioArticulo = precio;
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
