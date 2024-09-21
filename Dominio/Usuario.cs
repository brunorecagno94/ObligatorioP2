using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
<<<<<<< HEAD
  public class Usuario
  {
    #region Atributos
    private int _idUsuario;
    private string _nombreUsuario;
    private string _apellidoUsuario;
    private string _eMailUsuario;
    private string _passUsuario;
    #endregion

    #region Propiedades
    public int IdUsuario { get; set; }
    public string NombreUsuario { get; set; }
    public string ApellidoUsuario { get; set; }
    public string EmailUsuario { get; set; }
    public string PassUsuario { get; set; }
    #endregion

    #region Constructores
    public Usuario(int idUsuario, string nombreUsuario, string apellidoUsuario, string emailUsuario, string passUsuario)
    {
      this.IdUsuario = idUsuario;
      this.NombreUsuario = nombreUsuario;
      this.ApellidoUsuario = apellidoUsuario;
      this.EmailUsuario = emailUsuario;
      this.PassUsuario = passUsuario;
    }
    #endregion
  }
=======
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
>>>>>>> 35f9630c461df418eb566b3aa21ea2e41d671a6f
}
