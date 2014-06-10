using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SI.DataContract
{
    [DataContract]
    public class CelularDC
    {
        private String _imei;
        private String _marca;
        private String _modelo;
        private int _numCores;

        [DataMember]
        public String Imei
        {
            get { return _imei; }
            set { _imei = value; }
        }
        
        [DataMember]
        public String Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

         [DataMember]
        public String Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

         [DataMember]
        public int NumCores
        {
            get { return _numCores; }
            set { _numCores = value; }
        }
        

    }
}
