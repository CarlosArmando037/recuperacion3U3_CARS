using recuperacionU3_CARS.Clases;
using recuperacionU3_CARS.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperacionU3_CARS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            Console.WriteLine("seleccione una opcion: ");
            Console.WriteLine("1._salir");
            Console.WriteLine("2._agregar");
            Console.WriteLine("3._imprimir inventario");
            Console.WriteLine("4._ordenamiento // ");
            Console.WriteLine("5._ busqueda por precio");
            int opcion = Convert.ToInt32(Console.ReadLine());


            while (opcion != 1)
            {
                switch (opcion)
                {
                    case 2:
                        ProductoModel producto = new ProductoModel();
                        Console.WriteLine("inserte el nombre del producto");
                        producto.Nombre = Console.ReadLine();
                        Console.WriteLine("inserte el precio del producto");
                        producto.Precio = Convert.ToInt32(Console.ReadLine());
                        lista.insertarInicio(producto);
                        Console.WriteLine("ingresado correctamente");
                        break;
                    case 3:
                        lista.imprimir();
                        break;
                    case 4:
                        lista.ordenamientoASC();
                        break;
                    case 5:
                        ProductoModel producto1 = new ProductoModel();
                        Console.WriteLine("inserte el prducto que quiera buscar por PRECIO");
                        producto1.Precio = Convert.ToInt32(Console.ReadLine());
                        break;

                }
                Console.WriteLine("seleccione otra opcion:");
                opcion = Convert.ToInt32(Console.ReadLine());
                
            }

        }
    }
}
