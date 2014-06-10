using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SI.DataContract
{
    [DataContract]
    public class Compra_Producto_SuperMercadoDC
    {

        String codCompra;
        String codCliente;
        String codProducto;
        String codSupermercado;
        int cantidad;
        String subtotal;
        String nombre;
        String precio;

        [DataMember]
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [DataMember]
        public String Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        [DataMember]
        public String CodCompra
        {
            get { return codCompra; }
            set { codCompra = value; }
        }

        [DataMember]
        public String CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }

        [DataMember]
        public String CodProducto
        {
            get { return codProducto; }
            set { codProducto = value; }
        }

        [DataMember]
        public String CodSupermercado
        {
            get { return codSupermercado; }
            set { codSupermercado = value; }
        }

        [DataMember]
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        [DataMember]
        public String Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

    }
}
