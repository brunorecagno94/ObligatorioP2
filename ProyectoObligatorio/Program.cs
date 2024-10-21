using Dominio;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoObligatorio
{
  public class Program
  {
    static void Main(string[] args)
    {
      Sistema sistema = new Sistema();


      // MENÚ PRINCIPAL
      int opcionMenu = -1;

      while (opcionMenu != 0)
      {
        Console.Clear();
        Console.WriteLine("Menú principal:" +
          "\n1. Listado de clientes" +
          "\n2. Listar artículos de una categoría establecida" +
          "\n3. Crear un artículo" +
          "\n4. Listar publicaciones entre dos fechas" +
          "\n0. Salir");

        while (!int.TryParse(Console.ReadLine(), out opcionMenu))
        {
          Console.WriteLine("Ingrese una opción válida.");
        }

        switch (opcionMenu)
        {
          // Opción 1: Listado de clientes
          case 1:
            foreach (Cliente cliente in sistema.GetListaClientes())
            {
              Console.WriteLine(cliente);
            }
            if (sistema.GetListaClientes().Count == 0)
            {
              Console.WriteLine("No hay clientes para listar.");
            }

            break;

          // Opción 2: Listar artículos de una categoría establecida
          case 2:

            //Se crea listado de categorías
            Console.WriteLine("Categorías:");

            List<string> listaCategorias = sistema.GetListaCategorias();

            //Se ingresa la categoría y se hace la búsqueda
            Console.WriteLine("Elige una categoría por su nombre:");
            string respuesta = Console.ReadLine();

            foreach (Articulo item in sistema.GetArticulosPorCategoria(respuesta, listaCategorias))
            {
              Console.WriteLine(item);
            }

            if (sistema.GetArticulosPorCategoria(respuesta, listaCategorias).Count == 0)
            {
              Console.WriteLine("No hay artículos que pertenezcan a esa categoría.");
            }

            break;

          // Opción 3: Crear un artículo
          case 3:

            //Se ingresan los datos
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

            //Validación general de los datos antes de cargar el artículo
            if (string.IsNullOrEmpty(nombreArticulo) || string.IsNullOrEmpty(categoriaArticulo))
            {
              Console.WriteLine("Error en ingreso de datos. Intente nuevamente.");
            }
            else
            {
              //Se crea el artículo, se agrega al listado en Sistema y se muestra en consola
              sistema.PrecargarArticulo(nombreArticulo, categoriaArticulo, precioArticulo);
              Console.WriteLine("¡Artículo creado y agregado al listado correctamente!" +
                $"\nNombre: {nombreArticulo}" +
                $"\nCategoría: {categoriaArticulo}" +
                $"\nPrecio: ${precioArticulo}");
            }
            break;

          // Opción 4: Listar publicaciones entre dos fechas
          case 4:

            // Se ingresan las dos fechas
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

            // Se devuelven las publicaciones si pasaron las validaciones

            foreach (Publicacion publicacion in sistema.GetPublicacionesPorFecha(fechaInicio, fechaFin))
            {
              Console.WriteLine($"{publicacion} \n");
            }

            if (sistema.GetPublicacionesPorFecha(fechaInicio, fechaFin).Count == 0)
            {
              Console.WriteLine("No hay publicaciones en ese rango de fechas.");
            }
            break;

          // Opción 0: Salir
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
