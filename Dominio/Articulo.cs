using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Articulo
  {
    public static int _idArticulo = 1;
    private string _nombreArticulo;
    private string _categoriaArticulo;
    private int _precioArticulo;

  

    public int IdArticulo { get;}
    public string NombreArticulo { get; set; }
    public string CategoriaArticulo { get; set; }
    public int PrecioArticulo { get; set; }


    public Articulo(string Nombre, string Categoria, int Precio)
    {

            IdArticulo = _idArticulo++;
            NombreArticulo = Nombre;
            CategoriaArticulo = Categoria;
            PrecioArticulo = Precio;
    }


    public override string ToString()
    {
            return $" id: {IdArticulo} ,nombre: {NombreArticulo} ,categoria: {CategoriaArticulo} ,precio: {PrecioArticulo} ";
        }

       
      
    }
}
