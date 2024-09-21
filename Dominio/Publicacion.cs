using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio
{
  public class Publicacion
  {

    //HACER ENUM PARA ESTADO

    private int _idPublicacion;
    private string _nombrePublicacion;
    private string _estadoPublicacion;
    private DateTime _fechaPublicacion;
    private string _clienteComprador;
    private string _usuarioFinalizador;
    private DateTime _fechaFin;
 



       static private List<Articulo> _listaArticulos;



        public int IdPublicacion { get; set; }
    public string NombrePublicacion { get; set; }
    public string EstadoPublicacion { get; set; }
    public DateTime FechaPublicacion { get; set; }
    public string ClienteComprador { get; set; }
    public string UsuarioFinalizador { get; set; }
    public DateTime FechaFin { get; set; }

    static public List<Articulo> listaArticulos { get; set; }



        public Publicacion(int IdPublicacion, string NombrePublicacion, string EstadoPublicacion, DateTime FechaPublicacion, string ClienteComprador, string UsuarioFinalizador, DateTime FechaFin, List<Articulo> listaArticulos)
    {
      this.IdPublicacion = IdPublicacion;
      this.NombrePublicacion = NombrePublicacion;
      this.EstadoPublicacion = EstadoPublicacion;
      this.FechaPublicacion = FechaPublicacion;
      this.ClienteComprador = ClienteComprador;
      this.UsuarioFinalizador = UsuarioFinalizador;
      this.FechaFin = FechaFin;
      listaArticulos = listaArticulos;
        }

        public override string ToString()
        {
            return $"hola";
        }



        public string devolvervalores()
        {
            return $" id: {IdPublicacion} ,nombre: {NombrePublicacion} ,estado: {EstadoPublicacion} ,fechainicio: {FechaPublicacion} ";

        }



    }
}
