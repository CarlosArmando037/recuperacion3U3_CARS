using recuperacionU3_CARS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperacionU3_CARS.Clases
{
    internal class ListaEnlazada
    {
        public Nodo primero;
        public Nodo ultimo;

        public ListaEnlazada()
        {
            primero = ultimo = null;
        }


        //metodos

        public bool EsVacio()
        {
            if (primero == null)
            {
                return true;
            }
            return false;
        }

        public void insertarInicio(ProductoModel producto)
        {
            if (EsVacio())
            {
                primero= ultimo = new Nodo(producto);
            }
            else
            {
                primero = new Nodo(producto, primero);
            }
        }

        public void imprimir()
        {
            if (EsVacio())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Nodo actual = primero;
                while (actual != null)
                {
                    Console.WriteLine($"el producto es: {actual.producto.Nombre} y su precio es: {actual.producto.Precio}");
                    actual = actual.siguiente;
                }
            }
        }

        public void ordenamientoASC ()
        {
            if (EsVacio())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                


                Nodo actual = primero;
                while(actual != null)
                {                
                    Nodo proximo = primero.siguiente;
                    while (proximo != null)
                    {
                        if (proximo.producto.Precio < actual.producto.Precio)
                        {
                            Nodo temp = proximo;
                            proximo = actual;
                            actual = temp;

                            proximo = proximo.siguiente;

                        }
                        actual = actual.siguiente;
                    }
                }
            }
        }

        public void Busqueda(ProductoModel producto)
        {
            if (EsVacio())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Nodo actual = primero;
                while(actual != null)
                {
                    if (actual.producto.Precio == producto.Precio)
                    {
                        Console.WriteLine($"el producto es: {actual.producto.Nombre} y su precio es: {actual.producto.Precio}");
                    }
                    actual = actual.siguiente;
                }
            }
        } 

    }
}
