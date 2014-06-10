using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SI.DataContract
{
    public class AdministradorDC
    {
        String CodAdmin;
        String NomAdmin;
        String ApeAdmin;
        String Usuario;
        String Contrasena;


        [DataMember]
        public String CodAdmin1
        {
            get { return CodAdmin; }
            set { CodAdmin = value; }
        }

        [DataMember]
        public String NomAdmin1
        {
            get { return NomAdmin; }
            set { NomAdmin = value; }
        }

        [DataMember]
        public String ApeAdmin1
        {
            get { return ApeAdmin; }
            set { ApeAdmin = value; }
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
       
        

        
    
    }
}
