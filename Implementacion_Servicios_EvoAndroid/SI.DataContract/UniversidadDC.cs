using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SI.DataContract
{
    [DataContract]
    public class UniversidadDC
    {
        Int32 codigo;
        String nombre;
        String siglas;
        String direccion;
        String distrito;
        String correo;
        Int32 ranking;


       
        [DataMember]
        public Int32 Codigo
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
        public String Siglas
        {
            get { return siglas; }
            set { siglas = value; }
        }

         [DataMember]
        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

         [DataMember]
        public String Distrito
        {
            get { return distrito; }
            set { distrito = value; }
        }

         [DataMember]
        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }

         [DataMember]
        public Int32 Ranking
        {
            get { return ranking; }
            set { ranking = value; }
        }

    }
}
