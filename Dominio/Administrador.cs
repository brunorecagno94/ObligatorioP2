using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Administrador : Usuario
  {
    #region Constructores
    public Administrador(int idUsuario, string nombreUsuario, string apellidoUsuario, string emailUsuario, string passUsuario) : base(idUsuario, nombreUsuario, apellidoUsuario, emailUsuario, passUsuario)
    {
<<<<<<< HEAD
=======
        public Administrador(int idUsuario, string nombreUsuario, string apellidoUsuario, string emailUsuario, string passUsuario) : base(nombreUsuario, apellidoUsuario, emailUsuario, passUsuario)
        {
        }
>>>>>>> 35f9630c461df418eb566b3aa21ea2e41d671a6f
    }
    #endregion
  }
}
