using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SI.DataContract
{
    [DataContract]
    public class UsuarioDC
    {
        String usuario;
        String contrasena;

        [DataMember]
        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        [DataMember]
        public String Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
    }
}
