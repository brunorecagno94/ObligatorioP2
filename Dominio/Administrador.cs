using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Administrador : Usuario, IValidable
  {
    #region Constructores
    public Administrador(string nombreUsuario, string apellidoUsuario, string emailUsuario, string passUsuario) : base(nombreUsuario, apellidoUsuario, emailUsuario, passUsuario)
    {
      NombreUsuario = nombreUsuario;
      ApellidoUsuario = apellidoUsuario;
      EmailUsuario = emailUsuario;
      PassUsuario = passUsuario;

    }
    #endregion

    #region Métodos
    public override string ToString()
    {
      return $"Nombre completo: {NombreUsuario} {ApellidoUsuario}" +
      $"\nEmail: {EmailUsuario}" +
      $"\nContraseña: {PassUsuario}";
    }

    public void Validar()
    {

      if (string.IsNullOrEmpty(NombreUsuario))
      {
        throw new Exception("El nombre no puede estar vacío");
      }
      if (string.IsNullOrEmpty(ApellidoUsuario))
      {
        throw new Exception("El apellido no puede estar vacío");
      }
      if (string.IsNullOrEmpty(EmailUsuario))
      {
        throw new Exception("El email no puede estar vacío");
      }
      if (string.IsNullOrEmpty(PassUsuario))
      {
        throw new Exception("El email no puede estar vacío");
      }
    }
    #endregion
  }
}
