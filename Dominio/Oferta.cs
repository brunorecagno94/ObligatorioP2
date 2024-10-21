using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Oferta
  {
    #region Atributos
    private static int _idOfertaGlobal = 0;
    private int _idOferta;
    private Cliente _usuarioOferta;
    private int _montoOferta;
    private DateTime _fechaOferta;
    #endregion

    #region Propiedades
    public int IdOferta
    {
      get { return _idOferta; }
      private set { _idOferta = value; }
    }
    public Cliente UsuarioOferta { get; set; }
    public int MontoOferta { get; set; }
    public DateTime FechaOferta { get; set; }
    #endregion

    #region Constructores
    public Oferta(Cliente usuarioOferta, int montoOferta, DateTime fechaOferta)
    {
      IdOferta = _idOfertaGlobal++;
      UsuarioOferta = usuarioOferta;
      FechaOferta = fechaOferta;
    }
    #endregion
  }
}
