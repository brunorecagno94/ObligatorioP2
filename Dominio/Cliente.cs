using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Cliente : Usuario
  {
<<<<<<< HEAD
    #region Atributos
=======
       
>>>>>>> 35f9630c461df418eb566b3aa21ea2e41d671a6f
    private int _saldoDisponible;
    private static List<Cliente> listaClientes = new List<Cliente>();
    #endregion

<<<<<<< HEAD
    #region Propiedades
    public int SaldoDisponible { get; set; }
    #endregion

    #region Constructores
    public Cliente(int idUsuario, string nombreUsuario, string apellidoUsuario, string emailUsuario, string passUsuario, int saldoDisponible) : base(idUsuario, nombreUsuario, apellidoUsuario, emailUsuario, passUsuario)
    {
      IdUsuario = idUsuario;
      NombreUsuario = nombreUsuario;
      ApellidoUsuario = apellidoUsuario;
      EmailUsuario = emailUsuario;
      PassUsuario = passUsuario;
      SaldoDisponible = saldoDisponible;
=======
        
        public int SaldoDisponible { get; set; }

        public Cliente(string nombreUsuario, string apellidoUsuario, string emailUsuario, string passUsuario, int saldoDisponible) : base (nombreUsuario, apellidoUsuario, emailUsuario, passUsuario)
        {

            NombreUsuario = nombreUsuario;
            ApellidoUsuario = apellidoUsuario;
            EmailUsuario = emailUsuario;
            PassUsuario = passUsuario;
            SaldoDisponible = saldoDisponible;
          

        }

        public override string ToString()
        {
            return $" id: {IdUsuario} ,nombre: {NombreUsuario} ,Apellido: {ApellidoUsuario} ,Email: {EmailUsuario}, Pass: {PassUsuario}, saldo: {SaldoDisponible}  ";
        }

>>>>>>> 35f9630c461df418eb566b3aa21ea2e41d671a6f
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
