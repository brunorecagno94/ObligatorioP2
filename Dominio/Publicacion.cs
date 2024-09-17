using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Publicacion
  {

    //HACER ENUM PARA ESTADO

    private int _idPublicacion;
    private string _nombrePublicacion;
    private string _estadoPublicacion;
    private int _fechaPublicacion;
    private string _clienteComprador;
    private string _usuarioFinalizador;
    private int _fechaFin;
    private Articulo _articuloPub;


    public int IdPublicacion { get; set; }
    public string NombrePublicacion { get; set; }
    public string EstadoPublicacion { get; set; }
    public int FechaPublicacion { get; set; }
    public string ClienteComprador { get; set; }
    public string UsuarioFinalizador { get; set; }
    public int FechaFin { get; set; }

    public Articulo ArticuloPub { get; set; }

    public Publicacion(int IdPublicacion, string NombrePublicacion, string EstadoPublicacion, int FechaPublicacion, string ClienteComprador, string UsuarioFinalizador, int FechaFin, Articulo Articulopub)
    {
      this._idPublicacion = IdPublicacion;
      this._nombrePublicacion = NombrePublicacion;
      this._estadoPublicacion = EstadoPublicacion;
      this._fechaPublicacion = FechaPublicacion;
      this._clienteComprador = ClienteComprador;
      this._usuarioFinalizador = UsuarioFinalizador;
      this._fechaFin = FechaFin;
      this._articuloPub = Articulopub;
    }
  }
}
