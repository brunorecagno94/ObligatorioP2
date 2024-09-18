using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Usuario
  {
    private int _idUsuario;
    private string _nombreUsuario;
    private string _apellidoUsuario;
    private string _eMailUsuario;
    private string _passUsuario;

    public int IdUsuario { get; set; }
    public string NombreUsuario { get; set; }
    public string ApellidoUsuario { get; set; }
    public string EMailUsuario { get; set; }
    public string PassUsuario { get; set; }
  }
}
