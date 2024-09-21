﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
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
}
