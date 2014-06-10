using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SI.DataContract
{
    [DataContract]
    public class ClienteDC
    {
        String CodCliente;
        String NomCliente;
        String ApeCliente;
        String Telefono;
        String Direccion;
        String RutaIMG;
        String Correo;
        String Usuario;
        String Contrasena;


        [DataMember]
        public String CodCliente1
        {
            get { return CodCliente; }
            set { CodCliente = value; }
        }

        [DataMember]
        public String NomCliente1
        {
            get { return NomCliente; }
            set { NomCliente = value; }
        }

        [DataMember]
        public String ApeCliente1
        {
            get { return ApeCliente; }
            set { ApeCliente = value; }
        }

        [DataMember]
        public String Telefono1
        {
            get { return Telefono; }
            set { Telefono = value; }
        }

        [DataMember]
        public String Direccion1
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

        [DataMember]
        public String Correo1
        {
            get { return Correo; }
            set { Correo = value; }
        }

        [DataMember]
        public String Usuario1
        {
            get { return Usuario; }
            set { Usuario = value; }
        }

        [DataMember]
        public String Contrasena1
        {
            get { return Contrasena; }
            set { Contrasena = value; }
        }

        [DataMember]
        public String RutaIMG1
        {
            get { return RutaIMG; }
            set { RutaIMG = value; }
        }
    }
}
