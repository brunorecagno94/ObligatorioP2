using Dominio;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoObligatorio
{
  public class Program
  {
    static void Main(string[] args)
    {
      List<Articulo> listaArticulos = new List<Articulo>();

      List<Publicacion> listaPublicaciones = new List<Publicacion>();


      Cliente cliente1 = new Cliente(1, "Andy", "Andrade", "aaaa@gmail.com", "andytoproyatusabes", 400);
      Articulo articulo1 = new Articulo(2, "hola", "hola", 2);
      listaArticulos.Add(articulo1);

      Publicacion publicacionuno = new Publicacion(22, "hola", "chau", new DateTime(2005, 3, 21), "hola", "hola", new DateTime(2009, 4, 5), listaArticulos);
      listaPublicaciones.Add(publicacionuno);

      List<Cliente> listaClientes = new List<Cliente>();
      listaClientes.Add(cliente1);

      // MENÚ PRINCIPAL

      int opcion = -1;

      while (opcion != 0)
      {
        Console.Clear();
        Console.WriteLine("Menú principal:" +
          "\n1. Listado de clientes" +
          "\n2. Listar artículos de una categoría establecida" +
          "\n3. Crear un artículo" +
          "\n4. Listar publicaciones entre dos fechas" +
          "\n0. Salir");


        while (!int.TryParse(Console.ReadLine(), out opcion))
        {
<<<<<<< HEAD
          Console.WriteLine("Ingrese una opción válida.");
=======

            // pre carga de datos
            List<Articulo> listaArticulos = new List<Articulo>();

            List<Publicacion> listaPublicaciones = new List<Publicacion>();


            Cliente cliente1 = new Cliente("Andy","Andrade","aaaa@gmail.com","andytoproyatusabes",400);
            Articulo articulo1 = new Articulo("hola", "hola",2);
            listaArticulos.Add(articulo1);




            Publicacion publicacionuno = new Publicacion(22, "hola", "chau", new DateTime(2005, 3, 21), "hola", "hola", new DateTime(2009, 4, 5), listaArticulos);
            listaPublicaciones.Add(publicacionuno);

            List <Cliente> listaClientes = new List<Cliente>();
            listaClientes.Add(cliente1);

   
            

            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine("Elija un número para el menú:");
                Console.WriteLine("Menu:");
                Console.WriteLine("1- Listado de todos los clientes");
                Console.WriteLine("2- Listar artículos de categoría establecida");
                Console.WriteLine("3- Alta artículo");
                Console.WriteLine("4- Listar publicaciones entre 2 fechas");
                Console.WriteLine("0- Salir");


                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    
                    case 1:
                        foreach (var cliente in listaClientes)
                        {
                            Console.WriteLine(cliente);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Elija su nombre de categoría:");
                        string respCategoria = Console.ReadLine();

                        foreach (var articulo in listaArticulos)
                        {

                            if (articulo.CategoriaArticulo == respCategoria)
                            {
                                Console.WriteLine(articulo);
                            }

                            else { Console.WriteLine("Tu categoria no esta en ningun articulo"); }
                            
                        }


                        break;
            
                        //aca hice la opcion para pedir los datos para un articulo, desp instancie el articulo con esos datos(menos el de id que es autoincremental) y por ultimo lo agrege a la lista
                        //tamb le di unas validaciones que no se si pide pero para que quede mas lindo
                    case 3:
                        Console.WriteLine("Elija un nombre para su artículo:");
                        string nombreArticulo = Console.ReadLine();

                        Console.WriteLine("Elija una categoría para su artículo:");
                        string categoriaArticulo = Console.ReadLine();

                        Console.WriteLine("Elija un precio para su artículo:");

                        int precioArticulo;
                        int.TryParse(Console.ReadLine(), out precioArticulo);


                        if (nombreArticulo != null && categoriaArticulo != null && precioArticulo != null)
                        {

                            Articulo articuloAlta = new Articulo(nombreArticulo, categoriaArticulo, precioArticulo);

                            listaArticulos.Add(articuloAlta);

                        }
                        else
                        {
                            Console.WriteLine("Datos inválidos. Intente nuevamente.");
                        }
                        break;

                    case 4:

                        Console.WriteLine("Elija su fecha de inicio (formato: año/mes/dia ej: 2000/01/01):");

                        DateTime fechaInicio;

   
                        if (!DateTime.TryParse(Console.ReadLine(), out fechaInicio))
                        {
                            Console.WriteLine("Formato de fecha inválido. Inténtelo de nuevo.");
                            break;
                        }

                        Console.WriteLine("Elija su fecha de fin (formato: año/mes/dia ej: 3000/01/01):");

                        DateTime fechaFin;

                        if (!DateTime.TryParse(Console.ReadLine(), out fechaFin))
                        {
                            Console.WriteLine("Formato de fecha inválido. Inténtelo de nuevo.");
                            break;
                        }

                        foreach (var publicacionrecorrida in listaPublicaciones)
                        {

                            if (publicacionrecorrida.FechaPublicacion >= fechaInicio && publicacionrecorrida.FechaFin <= fechaFin)
                            {
                                Console.WriteLine(publicacionrecorrida.devolvervalores());
                            }
                            else
                            {
                                Console.WriteLine("No se encontraron publicaciones en ese rango de fechas.");
                            }
                        }

                        break;




                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();
            }
>>>>>>> 35f9630c461df418eb566b3aa21ea2e41d671a6f
        }

        switch (opcion)
        {
          // Opción 1
          case 1:
            foreach (var cliente in listaClientes)
            {
              Console.WriteLine(cliente);
            }
            break;

          // Opción 2
          case 2:
            Console.WriteLine("Ingrese el nombre de la categoría:");
            string respCategoria = Console.ReadLine();
            Console.WriteLine($"Artículos pertenecientes a '{respCategoria}':");

            foreach (var articulo in listaArticulos)
            {

              if (articulo.CategoriaArticulo == respCategoria)
              {
                Console.WriteLine(articulo);
              }

              else
              {
                Console.WriteLine("No se encontró ningún artículo perteneciente a esta categoría.");
              }
            }
            break;

          //aca hice la opcion para pedir los datos para un articulo, desp instancie el articulo con esos datos(menos el de id que es autoincremental) y por ultimo lo agrege a la lista
          //tamb le di unas validaciones que no se si pide pero para que quede mas lindo

          // Opción 3
          case 3:
            Console.WriteLine("Ingrese un nombre para su artículo:");
            string nombreArticulo = Console.ReadLine();

            while (string.IsNullOrEmpty(nombreArticulo))
            {
              Console.WriteLine("Ingrese un nombre válido:");
              nombreArticulo = Console.ReadLine();
            };

            Console.WriteLine("Ingrese una categoría para su artículo:");
            string categoriaArticulo = Console.ReadLine();

            while (string.IsNullOrEmpty(categoriaArticulo))
            {
              Console.WriteLine("Ingrese una categoría válida:");
              categoriaArticulo = Console.ReadLine();
            };

            Console.WriteLine("Ingrese un precio para su artículo:");

            int precioArticulo;
            while (!int.TryParse(Console.ReadLine(), out precioArticulo))
            {
              Console.WriteLine("Ingrese un número válido");
            }

            Articulo articuloAlta = new Articulo(Articulo._idArticulo, nombreArticulo, categoriaArticulo, precioArticulo);
            Console.WriteLine("¡Artículo creado y agregado al listado correctamente!" +
              $"\nNombre: {nombreArticulo}" +
              $"\nCategoría: {categoriaArticulo}" +
              $"\nPrecio: ${precioArticulo}");
            listaArticulos.Add(articuloAlta);
            break;

          // Opción 4
          case 4:
            Console.WriteLine("Ingrese la fecha de inicio (formato: año/mes/dia; Ej.: 2000/01/01):");
            DateTime fechaInicio;

            while (!DateTime.TryParse(Console.ReadLine(), out fechaInicio))
            {
              Console.WriteLine("Formato de fecha inválido. Inténtelo de nuevo.");
            }

            Console.WriteLine("Elija su fecha de fin (formato: año/mes/dia; Ej.: 2000/01/01):");
            DateTime fechaFin;

            while (!DateTime.TryParse(Console.ReadLine(), out fechaFin))
            {
              Console.WriteLine("Formato de fecha inválido. Inténtelo de nuevo.");
            }

            foreach (var publicacion in listaPublicaciones)
            {
              if (publicacion.FechaPublicacion >= fechaInicio && publicacion.FechaFin <= fechaFin)
              {
                Console.WriteLine($"{publicacion} \n");
              }
              else
              {
                Console.WriteLine("No se encontraron publicaciones en ese rango de fechas.");
              }
            }
            break;

          case 0:
            Console.WriteLine("Saliendo del programa...");
            break;

          default:
            Console.WriteLine("Ingrese una opción válida.");
            break;
        }
        Console.ReadLine();
      }
    }
  }
}
