using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.BE
{
    public class Compra_Producto_SuperMercadoBE
    {
        String codCompra;
        String codCliente;
        String codProducto;
        String codSupermercado;
        int cantidad;
        String subtotal;

        String precio;

        String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Compra_Producto_SuperMercadoBE( String codcomp,String codCli,String codpro,String codsuperm,int canti,String subtot)
        {
             codCompra=codcomp;
             codCliente=codCli;
             codProducto=codpro;
             codSupermercado=codsuperm;
             cantidad=canti;
             subtotal = subtot;
        
        }


        public Compra_Producto_SuperMercadoBE(String nom, int canti, String subtot)
        {
            nombre = nom;
          
            cantidad = canti;
            subtotal = subtot;

        }


        public String CodCompra
        {
            get { return codCompra; }
            set { codCompra = value; }
        }
        

        public String CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }
        

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
        

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        

        public String Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }



    }
}
