using recuperacionU3_CARS.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperacionU3_CARS.Clases
{
    internal class Nodo
    {
        public ProductoModel _Producto;
        public Nodo _Siguiente;

        public Nodo(ProductoModel producto)
        {
            _Producto = producto;
            _Siguiente = null;
        }
        public Nodo(ProductoModel producto,Nodo siguiente)
        {
            _Producto = producto;
            _Siguiente = siguiente;
        }

        public ProductoModel producto { get { return _Producto; } set { _Producto = value; } }
        public Nodo siguiente { get { return _Siguiente; } set { _Siguiente = value; } }

    }
}
