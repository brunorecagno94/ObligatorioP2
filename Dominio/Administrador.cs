using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Administrador : Usuario
    {
        public Administrador(int idUsuario, string nombreUsuario, string apellidoUsuario, string emailUsuario, string passUsuario) : base(idUsuario, nombreUsuario, apellidoUsuario, emailUsuario, passUsuario)
        {
        }
    }
}
