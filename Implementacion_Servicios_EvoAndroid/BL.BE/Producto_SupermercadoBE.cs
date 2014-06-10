using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.BE
{
    public class Producto_SupermercadoBE
    {
        String codProducto;
        String codSupermercado;
        Double precio;
        String oferta;
        int stock;       

        public String CodProducto
        {
            get { return codProducto; }
            set { codProducto = value; }
        }
        public String CodSupermercado
        {
            get { return codSupermercado; }
            set { codSupermercado = value; }
        }

        public Double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public String Oferta
        {
            get { return oferta; }
            set { oferta = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }


    }
}
