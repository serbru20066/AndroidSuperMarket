using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SI.DataContract
{
    [DataContract]
    public class BrunoDC
    {
        private String _Nombre;
        private String _Apellido;
        private Int32 _Edad;

        [DataMember]
        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        [DataMember]
        public String Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        [DataMember]
        public Int32 Edad
        {
            get { return _Edad; }
            set { _Edad = value; }
        }
    }
}
