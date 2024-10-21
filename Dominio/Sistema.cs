using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Sistema
  {
    #region Atributos
    private List<Cliente> _listaClientes = new List<Cliente>();
    private List<Administrador> _listaAdministradores = new List<Administrador>();
    private List<Articulo> _listaArticulos = new List<Articulo>();
    private List<Venta> _listaVentas = new List<Venta>();
    private List<Subasta> _listaSubastas = new List<Subasta>();
    #endregion

    #region Constructor
    public Sistema()
    {
      PrecargarDatos();
    }
    #endregion

    #region Metodos

    public void PrecargarDatos()
    {
      //Clientes
      PrecargarCliente("Lucas", "Martínez", "lucas.martinez@mail.com", "pass123", 5000);
      PrecargarCliente("Ana", "Gómez", "ana.gomez@mail.com", "pass456", 3400);
      PrecargarCliente("Carlos", "Pérez", "carlos.perez@mail.com", "pass789", 2100);
      PrecargarCliente("María", "Fernández", "maria.fernandez@mail.com", "pass321", 6700);
      PrecargarCliente("Sofía", "Rodríguez", "sofia.rodriguez@mail.com", "pass654", 8200);
      PrecargarCliente("Javier", "López", "javier.lopez@mail.com", "pass987", 1500);
      PrecargarCliente("Natalia", "García", "natalia.garcia@mail.com", "pass741", 4600);
      PrecargarCliente("Federico", "Ramos", "federico.ramos@mail.com", "pass852", 2200);
      PrecargarCliente("Lucía", "Torres", "lucia.torres@mail.com", "pass963", 7100);
      PrecargarCliente("Alejandro", "Méndez", "alejandro.mendez@mail.com", "pass159", 5300);

      //Administradores
      PrecargarAdmin("Roberto", "Silva", "roberto.silva@admin.com", "adminpass123");
      PrecargarAdmin("Laura", "Giménez", "laura.gimenez@admin.com", "adminpass456");

      //Artículos
      PrecargarArticulo("Laptop Dell XPS", "Electronica", 1500);
      PrecargarArticulo("Silla ergonómica", "Muebles", 200);
      PrecargarArticulo("Samsung Galaxy S21", "Electronica", 800);
      PrecargarArticulo("Televisor LG 55''", "Electronica", 1200);
      PrecargarArticulo("Cafetera Nespresso", "Electrodomesticos", 150);
      PrecargarArticulo("Aspiradora Dyson", "Electrodomesticos", 300);
      PrecargarArticulo("Monitor ASUS 27''", "Electronica", 400);
      PrecargarArticulo("Escritorio de madera", "Muebles", 350);
      PrecargarArticulo("Bicicleta de montaña", "Deportes", 500);
      PrecargarArticulo("Auriculares Bose", "Electronica", 250);
      PrecargarArticulo("Tablet iPad Air", "Electronica", 600);
      PrecargarArticulo("Cámara Nikon D3500", "Fotografi", 900);
      PrecargarArticulo("Smartwatch Garmin", "Electronica", 350);
      PrecargarArticulo("Frigorífico Samsung", "Electrodomesticos", 1000);
      PrecargarArticulo("Estantería modular", "Muebles", 150);
      PrecargarArticulo("Consola PS5", "Videojuegos", 500);
      PrecargarArticulo("Libro 'El Hobbit'", "Libros", 20);
      PrecargarArticulo("Set de herramientas", "Hogar", 100);
      PrecargarArticulo("Sofá de 3 plazas", "Muebles", 800);
      PrecargarArticulo("Cama king size", "Muebles", 1200);
      PrecargarArticulo("Zapatillas Nike Air", "Deportes", 150);
      PrecargarArticulo("Chaqueta de cuero", "Moda", 300);
      PrecargarArticulo("Reloj Apple Watch", "Electronica", 400);
      PrecargarArticulo("Bicicleta eléctrica", "Deportes", 1200);
      PrecargarArticulo("Impresora HP", "Electronica", 250);
      PrecargarArticulo("Juego de comedor", "Muebles", 600);
      PrecargarArticulo("Guitarra Fender Stratocaster", "Instrumentos", 700);
      PrecargarArticulo("Lavadora LG", "Electrodomesticos", 900);
      PrecargarArticulo("Parlante JBL", "Electronica", 150);
      PrecargarArticulo("Cámara GoPro Hero", "Fotografia", 350);
      PrecargarArticulo("Bicicleta estática", "Deportes", 300);
      PrecargarArticulo("Chaqueta North Face", "Moda", 250);
      PrecargarArticulo("Casco de moto", "Deportes", 100);
      PrecargarArticulo("Mesa de jardín", "Muebles", 400);
      PrecargarArticulo("Silla gamer", "Muebles", 180);
      PrecargarArticulo("Hoverboard", "Deportes", 250);
      PrecargarArticulo("Teclado mecánico", "Electronica", 120);
      PrecargarArticulo("Audífonos Sony", "Electronica", 180);
      PrecargarArticulo("Cámara Canon EOS", "Fotografia", 1300);
      PrecargarArticulo("Proyector Epson", "Electronica", 800);
      PrecargarArticulo("Cinturón de cuero", "Moda", 50);
      PrecargarArticulo("Zapatos formales", "Moda", 100);
      PrecargarArticulo("Drone DJI", "Electronica", 700);
      PrecargarArticulo("Funda para iPhone", "Accesorios", 20);
      PrecargarArticulo("Perfume Dior", "Belleza", 150);
      PrecargarArticulo("Lampara de pie", "Hogar", 100);
      PrecargarArticulo("Mochila deportiva", "Deportes", 80);
      PrecargarArticulo("Reloj Casio", "Electronica", 50);
      PrecargarArticulo("Lentes de sol Ray-Ban", "Moda", 200);
      PrecargarArticulo("Batería portátil", "Accesorios", 30);

      //Ventas
      PrecargarVenta(true, "Laptop HP en Oferta", Estado.ABIERTA, new DateTime(2022, 4, 15));
      PrecargarVenta(false, "Smartphone Samsung Galaxy S10", Estado.ABIERTA, new DateTime(2023, 6, 1));
      PrecargarVenta(true, "Bicicleta de Montaña Pro", Estado.ABIERTA, new DateTime(2023, 8, 22));
      PrecargarVenta(false, "Consola PS5 con 2 Controles", Estado.ABIERTA, new DateTime(2024, 1, 5));
      PrecargarVenta(true, "Cámara Nikon DSLR", Estado.ABIERTA, new DateTime(2021, 11, 10));
      PrecargarVenta(false, "Sofá Modular de 3 Plazas", Estado.ABIERTA, new DateTime(2023, 5, 18));
      PrecargarVenta(true, "Auriculares Bose QC35", Estado.ABIERTA, new DateTime(2023, 7, 30));
      PrecargarVenta(true, "Monitor Gamer 32''", Estado.ABIERTA, new DateTime(2022, 10, 12));
      PrecargarVenta(false, "Cafetera Expresso", Estado.ABIERTA, new DateTime(2024, 2, 20));
      PrecargarVenta(true, "Televisor OLED 65'' LG", Estado.ABIERTA, new DateTime(2021, 12, 7));

      //Subastas
      PrecargarSubasta("Subasta de Guitarra Fender", Estado.ABIERTA, new DateTime(2024, 3, 17), new List<Oferta>()
        { new Oferta(_listaClientes[0], 1000, new DateTime(2020, 08, 20)), new Oferta(_listaClientes[4], 1001, new DateTime(2020, 08, 30))
        });
      PrecargarSubasta("Subasta de Laptop Gaming Alienware", Estado.ABIERTA, new DateTime(2023, 8, 9), new List<Oferta>()
        { new Oferta(_listaClientes[2], 2300, new DateTime(2021, 02, 10)), new Oferta(_listaClientes[5], 2350, new DateTime(2021, 02, 11))
        });
      PrecargarSubasta("Subasta de Bicicleta Eléctrica", Estado.ABIERTA, new DateTime(2022, 7, 24), null);
      PrecargarSubasta("Subasta de Cámara Sony Alpha", Estado.ABIERTA, new DateTime(2024, 5, 3), null);
      PrecargarSubasta("Subasta de Colección de Cómics", Estado.ABIERTA, new DateTime(2021, 9, 13), null);
      PrecargarSubasta("Subasta de Silla Gamer Premium", Estado.ABIERTA, new DateTime(2023, 12, 1), null);
      PrecargarSubasta("Subasta de Coche Eléctrico", Estado.ABIERTA, new DateTime(2023, 10, 5), null);
      PrecargarSubasta("Subasta de Colección de Sellos", Estado.ABIERTA, new DateTime(2024, 6, 18), null);
      PrecargarSubasta("Subasta de Drone DJI Mavic", Estado.ABIERTA, new DateTime(2022, 2, 21), null);
      PrecargarSubasta("Subasta de Reloj Rolex Vintage", Estado.ABIERTA, new DateTime(2023, 11, 15), null);
    }

    //Métodos de precarga de objetos
    public void PrecargarCliente(string nombreUsuario, string apellidoUsuario, string emailUsuario, string passUsuario, int saldoDisponible)
    {
      try
      {
        Cliente nuevoCliente = new(nombreUsuario, apellidoUsuario, emailUsuario, passUsuario, saldoDisponible);
        nuevoCliente.Validar();
        _listaClientes.Add(nuevoCliente);
      }
      catch (Exception ex)
      {
        // Mostrar el mensaje de la excepción en la consola
        Console.WriteLine(ex.Message);
        Console.ReadLine();
      }
    }

    public void PrecargarAdmin(string nombreUsuario, string apellidoUsuario, string emailUsuario, string passUsuario)
    {
      try
      {
        Administrador nuevoAdministrador = new(nombreUsuario, apellidoUsuario, emailUsuario, passUsuario);
        nuevoAdministrador.Validar();
        _listaAdministradores.Add(nuevoAdministrador);
      }
      catch (Exception ex)
      {
        // Mostrar el mensaje de la excepción en la consola
        Console.WriteLine(ex.Message);
        Console.ReadLine();
      }
    }

    public void PrecargarArticulo(string nombreArticulo, string categoriaArticulo, int precioArticulo)
    {
      try
      {
        Articulo nuevoArticulo = new(nombreArticulo, categoriaArticulo, precioArticulo);
        nuevoArticulo.Validar();
        _listaArticulos.Add(nuevoArticulo);
      }
      catch (Exception ex)
      {
        // Mostrar el mensaje de la excepción en la consola
        Console.WriteLine(ex.Message);
        Console.ReadLine();
      }
    }

    public void PrecargarVenta(bool ofertaRelampago, string nombrePublicacion, Estado estadoPublicacion, DateTime fechaPublicacion)
    {
      try
      {
        List<Articulo> listaArticulosVenta = new List<Articulo>();
        for (int i = 0; i < 2; i++)
        {
          listaArticulosVenta.Add(_listaArticulos[i]);
        }

        Venta nuevaVenta = new(ofertaRelampago, nombrePublicacion, estadoPublicacion, new DateTime(2020, 01, 28), listaArticulosVenta);
        nuevaVenta.Validar();

        _listaVentas.Add(nuevaVenta);
      }
      catch (Exception ex)
      {
        // Mostrar el mensaje de la excepción en la consola
        Console.WriteLine(ex.Message);
        Console.ReadLine();
      }
    }

    public void PrecargarSubasta(string nombrePublicacion, Estado estadoPublicacion, DateTime fechaPublicacion, List<Oferta> listaOfertasSubasta)
    {
      List<Articulo> listaArticulosSubasta = new List<Articulo>();
      for (int i = 0; i < 2; i++)
      {
        listaArticulosSubasta.Add(_listaArticulos[i]);
      }
      try
      {
        Subasta nuevaSubasta = new(nombrePublicacion, estadoPublicacion, new DateTime(2021, 07, 28), listaOfertasSubasta, listaArticulosSubasta);
        nuevaSubasta.Validar();
        _listaSubastas.Add(nuevaSubasta);
      }
      catch (Exception ex)
      {
        // Mostrar el mensaje de la excepción en la consola
        Console.WriteLine(ex.Message);
        Console.ReadLine();
      }
    }

    //Listar categorías de artículos
    public List<string> GetListaCategorias()
    {
      List<string> listaCategorias = new List<string>();

      foreach (Articulo articulo in _listaArticulos)
      {
        if (!listaCategorias.Contains(articulo.CategoriaArticulo))
        {
          Console.WriteLine(articulo.CategoriaArticulo);
          listaCategorias.Add(articulo.CategoriaArticulo);
        }
      }
      return listaCategorias;
    }

    //Listar artículos por categoría
    public List<Articulo> GetArticulosPorCategoria(string categoriaIngresada, List<string> listaCategorias)
    {
      List<Articulo> listaFiltrada = new List<Articulo>();

      foreach (Articulo item in _listaArticulos)
      {
        if (item.CategoriaArticulo.Trim().ToUpper() == categoriaIngresada.Trim().ToUpper())
        {
          listaFiltrada.Add(item);
        }
      }

      return listaFiltrada;
    }

    //Mostrar las listas
    public List<Cliente> GetListaClientes()
    {
      return _listaClientes;
    }

    public List<Articulo> GetListaArticulos()
    {
      return _listaArticulos;
    }

    public List<Venta> GetListaVentas()
    {
      return _listaVentas;
    }

    public List<Subasta> GetListaSubastas()
    {
      return _listaSubastas;
    }

    public List<Publicacion> GetPublicaciones()
    {
      List<Publicacion> listaAux = new List<Publicacion>();

      foreach (Venta venta in _listaVentas)
      {
        listaAux.Add(venta);
      }

      foreach (Subasta subasta in _listaSubastas)
      {
        listaAux.Add(subasta);
      }

      return listaAux;
    }

    public List<Publicacion> GetPublicacionesPorFecha(DateTime fechaInicio, DateTime fechaFin)
    {
      List<Publicacion> listaFiltrada = new List<Publicacion>();

      foreach (Publicacion publicacion in GetPublicaciones())
      {
        if (publicacion.FechaPublicacion >= fechaInicio && publicacion.FechaPublicacion <= fechaFin)
        {
          listaFiltrada.Add(publicacion);
        }
      }
      return listaFiltrada;
    }
    #endregion
  };
}