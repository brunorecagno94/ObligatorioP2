using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Cliente : Usuario, IValidable
  {
    #region Atributos
    private int _saldoDisponible;
    #endregion

    #region Propiedades
    public int SaldoDisponible { get; set; }
    #endregion

    #region Constructores
    public Cliente(string nombreUsuario, string apellidoUsuario, string emailUsuario, string passUsuario, int saldoDisponible) : base(nombreUsuario, apellidoUsuario, emailUsuario, passUsuario)
    {
      NombreUsuario = nombreUsuario;
      ApellidoUsuario = apellidoUsuario;
      EmailUsuario = emailUsuario;
      PassUsuario = passUsuario;
      SaldoDisponible = saldoDisponible;


    }
    #endregion

    #region Métodos
    public override string ToString()
    {
      return $"Id: {IdUsuario}" +
      $"\nNombre completo: {NombreUsuario} {ApellidoUsuario}" +
      $"\nEmail: {EmailUsuario}" +
      $"\nContraseña: {PassUsuario}" +
      $"\nSaldo disponible: ${SaldoDisponible}";
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
        throw new Exception("La contraseña no puede estar vacía");
      }
      if (SaldoDisponible < 0)
      {
        throw new Exception("El saldo no puede ser negativo");
      }
    }

    #endregion
  }
}
