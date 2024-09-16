using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Articulo
  {
    private int _idArticulo;
    private string _nombreArticulo;
    private string _categoriaArticulo;
    private int _precioArticulo;


    public int IdArticulo { get; set; }
    public string NombreArticulo { get; set; }
    public string CategoriaArticulo { get; set; }
    public int PrecioArticulo { get; set; }


    public Articulo(int Id, string Nombre, string Categoria, int Precio)
    {

      this._idArticulo = Id;
      this._nombreArticulo = Nombre;
      this._categoriaArticulo = Categoria;
      this._precioArticulo = Precio;


    }

    public override string ToString()
    {
      return $" id: {_idArticulo} ,nombre: {_nombreArticulo} ,categoria: {_categoriaArticulo} ,precio: {_precioArticulo} ";
    }
  }
}
