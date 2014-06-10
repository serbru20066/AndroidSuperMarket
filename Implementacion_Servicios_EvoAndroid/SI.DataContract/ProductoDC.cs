using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SI.DataContract
{
     [DataContract]
    public class ProductoDC
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

        [DataMember]
        public String CodSupermer
        {
            get { return codSupermer; }
            set { codSupermer = value; }
        }

        String nomSupermercado;

        [DataMember]
        public String NomSupermercado
        {
            get { return nomSupermercado; }
            set { nomSupermercado = value; }
        }

        [DataMember]
        public String Cantidad
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

         
       

       
        [DataMember]
        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        [DataMember]
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [DataMember]
        public String Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        [DataMember]
        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        [DataMember]
        public String Fecvencimiento
        {
            get { return fecvencimiento; }
            set { fecvencimiento = value; }
        }

        [DataMember]
        public String Rutaimg
        {
            get { return rutaimg; }
            set { rutaimg = value; }
        }

        [DataMember]
        public String Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
