using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public class Sistema
  {
    private List<Usuario> _listaUsuarios = new List<Usuario>()
    {
            new Cliente(1, "Carlos", "García", "carlos.garcia@gmail.com", "pass123", 500),
            new Cliente(2, "María", "López", "maria.lopez@hotmail.com", "pass456", 1500),
            new Cliente(3 ,"Juan", "Pérez", "juan.perez@yahoo.com", "pass789", 2000),
            new Cliente(4, "Lucía", "Martínez", "lucia.martinez@gmail.com", "pass123", 2500),
            new Cliente(5, "Ana", "Gómez", "ana.gomez@gmail.com", "pass456", 3000),
            new Cliente(6, "Pedro", "Hernández", "pedro.hernandez@yahoo.com", "pass789", 3500),
            new Cliente(7, "Sofía", "Díaz", "sofia.diaz@hotmail.com", "pass123", 4000),
            new Cliente(8, "Miguel", "Ramírez", "miguel.ramirez@gmail.com", "pass456", 4500),
            new Cliente(9, "Laura", "Vega", "laura.vega@gmail.com", "pass789", 5000),
            new Cliente(10, "Andrés", "Ruiz", "andres.ruiz@hotmail.com", "pass123", 5500),
            new Administrador(11, "Manuel", "Sánchez", "manuel.sanchez@empresa.com", "admin123"),
            new Administrador(12, "Elena", "Morales", "elena.morales@empresa.com", "admin456")
        };

    private List<Articulo> _listaArticulos = new List<Articulo>
        {
            new Articulo("Laptop Lenovo", "Electrónica", 1200),
            new Articulo("iPhone 12", "Electrónica", 999),
            new Articulo("Smart TV Samsung 50\"", "Electrónica", 750),
            new Articulo("Audífonos Bluetooth Sony", "Electrónica", 150),
            new Articulo("Lavadora LG", "Electrodomésticos", 600),
            new Articulo("Refrigerador Whirlpool", "Electrodomésticos", 1200),
            new Articulo("Cafetera Nespresso", "Electrodomésticos", 200),
            new Articulo("Aspiradora Dyson", "Electrodomésticos", 400),
            new Articulo("Mesa de comedor", "Muebles", 300),
            new Articulo("Silla de oficina ergonómica", "Muebles", 250),
            new Articulo("Cama Queen", "Muebles", 800),
            new Articulo("Sofá de cuero", "Muebles", 1200),
            new Articulo("Reloj inteligente Garmin", "Electrónica", 300),
            new Articulo("Bicicleta de montaña Trek", "Deportes", 700),
            new Articulo("Trotadora eléctrica", "Deportes", 900),
            new Articulo("Raqueta de tenis Wilson", "Deportes", 150),
            new Articulo("Cámara Canon EOS", "Fotografía", 1200),
            new Articulo("Lente Nikon 50mm", "Fotografía", 300),
            new Articulo("Impresora HP LaserJet", "Oficina", 250),
            new Articulo("Mochila para laptop", "Accesorios", 80),
            new Articulo("Zapatos deportivos Nike", "Ropa y accesorios", 120),
            new Articulo("Chaqueta de cuero", "Ropa y accesorios", 350),
            new Articulo("Gafas de sol Ray-Ban", "Accesorios", 180),
            new Articulo("Colchón ortopédico", "Muebles", 600),
            new Articulo("Juego de sábanas King", "Textiles", 120),
            new Articulo("Lámpara de escritorio", "Iluminación", 60),
            new Articulo("Placa de inducción Bosch", "Electrodomésticos", 500),
            new Articulo("Microondas Panasonic", "Electrodomésticos", 150),
            new Articulo("Batidora KitchenAid", "Electrodomésticos", 350),
            new Articulo("Cámara de seguridad", "Seguridad", 180),
            new Articulo("Drone DJI", "Electrónica", 1000),
            new Articulo("Patinete eléctrico", "Transporte", 450),
            new Articulo("Auriculares gaming Razer", "Electrónica", 120),
            new Articulo("Consola de videojuegos PS5", "Electrónica", 500),
            new Articulo("Juego FIFA 24", "Videojuegos", 60),
            new Articulo("Teclado mecánico Logitech", "Electrónica", 100),
            new Articulo("Monitor 4K LG", "Electrónica", 400),
            new Articulo("Reloj Casio", "Accesorios", 80),
            new Articulo("Camisa de algodón", "Ropa y accesorios", 40),
            new Articulo("Jeans Levi's", "Ropa y accesorios", 70),
            new Articulo("Sudadera Adidas", "Ropa y accesorios", 90),
            new Articulo("Bolso de cuero", "Accesorios", 220),
            new Articulo("Perfume Dior", "Cosmética", 150),
            new Articulo("Set de maquillaje", "Cosmética", 80),
            new Articulo("Cepillo de dientes eléctrico Oral-B", "Salud", 100),
            new Articulo("Tostadora Philips", "Electrodomésticos", 50),
            new Articulo("Parrilla eléctrica George Foreman", "Electrodomésticos", 100),
            new Articulo("Tablet Samsung Galaxy", "Electrónica", 600),
            new Articulo("Juego de cubiertos", "Hogar", 70)
        };

    public List<Usuario> ListaUsuarios { get; set; }

    public List<Articulo> ListaArticulos { get; set; }
  }
}
