using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Usuario
    {
        private int _idUsuario = 1;
        private string _nombreUsuario;
        private string _apellidoUsuario;
        private string _eMailUsuario;
        private string _passUsuario;

        public int IdUsuario { get; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string PassUsuario { get; set; }


        public Usuario(string nombreUsuario, string apellidoUsuario, string emailUsuario, string passUsuario)
        {
            this.IdUsuario = _idUsuario++;
            this.NombreUsuario = nombreUsuario;
            this.ApellidoUsuario = apellidoUsuario;
            this.EmailUsuario = emailUsuario;
            this.PassUsuario = passUsuario;
        }

   
    
    }
}
