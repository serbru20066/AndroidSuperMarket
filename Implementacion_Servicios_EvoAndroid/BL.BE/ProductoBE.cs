using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BL.BE
{
    public class ProductoBE
    {
        String codigo;
        String nombre;
        String categoria;
        String marca;
        String fecvencimiento;
        String rutaimg;
        String precio;
        String subtotal;
        String cantidad;

        String codSupermer;

        public String CodSupermer
        {
            get { return codSupermer; }
            set { codSupermer = value; }
        }

        String nomSupermercado;

        public String NomSupermercado
        {
            get { return nomSupermercado; }
            set { nomSupermercado = value; }
        }

public String Cantidad
{
  get { return cantidad; }
  set { cantidad = value; }
}

        public String Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public String Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public ProductoBE(String codig,String nom,String categ,String marc,String fecvenc, String prec, String rutimg)
        {
            codigo = codig;
            categoria = categ;
            marca = marc;
            fecvencimiento = fecvenc;

            nombre = nom;
            rutaimg = rutimg;
            precio = prec;
        
        }

        public ProductoBE(String codig, String nom,String nomSupermerc,String codSuperm, String categ, String marc, String fecvenc, String prec, String rutimg)
        {
            codigo = codig;
            categoria = categ;
            marca = marc;
            fecvencimiento = fecvenc;

            nombre = nom;
            nomSupermercado = nomSupermerc;
            codSupermer = codSuperm; 

            rutaimg = rutimg;
            precio = prec;

        }
       

        public ProductoBE( String nom, String prec,String cant , String subt)
        {
           
            nombre = nom;
            precio = prec;
            cantidad = cant;
            subtotal =subt;

        }

        public ProductoBE(String codig, String codSuperm, String prec)
        {
            codigo = codig;
           
            codSupermer = codSuperm;

           
            precio = prec;

        }
       
        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        

        public String Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        

        public String Fecvencimiento
        {
            get { return fecvencimiento; }
            set { fecvencimiento = value; }
        }

        public String Rutaimg
        {
            get { return rutaimg; }
            set { rutaimg = value; }
        }

      
    }
}
