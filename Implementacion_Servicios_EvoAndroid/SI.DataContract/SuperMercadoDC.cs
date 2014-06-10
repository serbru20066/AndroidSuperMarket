using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SI.DataContract
{
    [DataContract]
    public class SuperMercadoDC
    {
        String codigo;
        String nombre;
        String ruc;
        String telefono;
        String paginaweb;
        String rutaimg;


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
        public String Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }

        [DataMember]
        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        [DataMember]
        public String Paginaweb
        {
            get { return paginaweb; }
            set { paginaweb = value; }
        }

        [DataMember]
        public String Rutaimg
        {
            get { return rutaimg; }
            set { rutaimg = value; }
        }

    }
}
