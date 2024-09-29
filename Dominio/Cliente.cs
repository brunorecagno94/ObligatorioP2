using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Cliente : Usuario
  {
    #region Atributos
    private int _saldoDisponible;
    private static List<Cliente> listaClientes = new List<Cliente>();
    #endregion

    #region Propiedades
    public int SaldoDisponible { get; set; }
    #endregion

    #region Constructores
    public Cliente(int idUsuario, string nombreUsuario, string apellidoUsuario, string emailUsuario, string passUsuario, int saldoDisponible) : base(nombreUsuario, apellidoUsuario, emailUsuario, passUsuario)
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
      return $"Nombre: {NombreUsuario}" +
      $"\nID: {IdUsuario}" +
      $"\nApellido: {ApellidoUsuario}" +
      $"\nEmail: {EmailUsuario}" +
      $"\nContraseña: {PassUsuario}" +
      $"\nSaldo disponible: ${SaldoDisponible}";
    }
    #endregion
  }
}
