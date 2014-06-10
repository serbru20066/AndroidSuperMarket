using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;

namespace SI.DataContract
{
    [DataContract]
    public class BrunoCelularesDC
    {
        private String _Nombre;
        private String _Apellido;
        private Int32 _Edad;
        private Collection<CelularDC> _LstCelularDC;

        [DataMember]
        public Collection<CelularDC> LstCelularDC
        {
            get { return _LstCelularDC; }
            set { _LstCelularDC = value; }
        }

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
