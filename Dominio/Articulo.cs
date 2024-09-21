using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Articulo
  {
<<<<<<< HEAD
    #region Atributos
    public static int _idArticulo;
=======
    public static int _idArticulo = 1;
>>>>>>> 35f9630c461df418eb566b3aa21ea2e41d671a6f
    private string _nombreArticulo;
    private string _categoriaArticulo;
    private int _precioArticulo;
    #endregion

<<<<<<< HEAD
    #region Propiedades
    public int IdArticulo { get; set; }
=======
  

    public int IdArticulo { get;}
>>>>>>> 35f9630c461df418eb566b3aa21ea2e41d671a6f
    public string NombreArticulo { get; set; }
    public string CategoriaArticulo { get; set; }
    public int PrecioArticulo { get; set; }
    #endregion

<<<<<<< HEAD
    #region Constructores
    public Articulo(int id, string nombre, string categoria, int precio)
    {
      _idArticulo = id;
      NombreArticulo = nombre;
      CategoriaArticulo = categoria;
      PrecioArticulo = precio;
=======

    public Articulo(string Nombre, string Categoria, int Precio)
    {

            IdArticulo = _idArticulo++;
            NombreArticulo = Nombre;
            CategoriaArticulo = Categoria;
            PrecioArticulo = Precio;
>>>>>>> 35f9630c461df418eb566b3aa21ea2e41d671a6f
    }
    #endregion

<<<<<<< HEAD
    #region Métodos
    public override string ToString()
    {
      return $"Nombre: {NombreArticulo}" +
      $"\nID: {IdArticulo}" +
      $"\nCategoría: {CategoriaArticulo}" +
      $"\nPrecio: {PrecioArticulo}";
=======

    public override string ToString()
    {
            return $" id: {IdArticulo} ,nombre: {NombreArticulo} ,categoria: {CategoriaArticulo} ,precio: {PrecioArticulo} ";
        }

       
      
>>>>>>> 35f9630c461df418eb566b3aa21ea2e41d671a6f
    }
    #endregion
  }
}
