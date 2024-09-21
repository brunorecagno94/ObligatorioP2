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
    private int _idOferta;
    private string _usuarioOferta;
    private int _montoOferta;
    private int _fechaOferta;
    #endregion

    #region Propiedades
    public int IdOferta { get; set; }
    public string UsuarioOferta { get; set; }
    public int MontoOferta { get; set; }
    public int FechaOferta { get; set; }
    #endregion
  }
}
