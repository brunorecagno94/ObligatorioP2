using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public abstract class Usuario
  {
    #region Atributos
    private static int _idUsuarioGlobal = 0;
    private int _idUsuario;
    private string _nombreUsuario;
    private string _apellidoUsuario;
    private string _eMailUsuario;
    private string _passUsuario;
    #endregion

    #region Propiedades
    public int IdUsuario
    {
      get { return _idUsuario; }
      private set { _idUsuario = value; }
    }
    public string NombreUsuario { get; set; }
    public string ApellidoUsuario { get; set; }
    public string EmailUsuario { get; set; }
    public string PassUsuario { get; set; }



    #endregion

    #region Constructores
    public Usuario(string nombreUsuario, string apellidoUsuario, string emailUsuario, string passUsuario)
    {
      IdUsuario = _idUsuarioGlobal++;
      this.NombreUsuario = nombreUsuario;
      this.ApellidoUsuario = apellidoUsuario;
      this.EmailUsuario = emailUsuario;
      this.PassUsuario = passUsuario;
    }
    #endregion

    #region Métodos
    public abstract override string ToString();
    #endregion
  }
}

