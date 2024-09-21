using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Cliente : Usuario
  {
    private int _saldoDisponible;
       private static List<Cliente> listaClientes = new List<Cliente>();


        public int SaldoDisponible { get; set; }

        public Cliente(int idUsuario, string nombreUsuario, string apellidoUsuario, string emailUsuario, string passUsuario, int saldoDisponible) : base (idUsuario, nombreUsuario, apellidoUsuario, emailUsuario, passUsuario)
        {
            IdUsuario = idUsuario;
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

    }

   
    
    

}
