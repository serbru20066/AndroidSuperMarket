using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SI.DataContract
{
    [DataContract]
    public class CompraDC
    {

        String codCompra;
        String codCliente;
        String fechacompra;
        String total;

       
        [DataMember]
        public String CodCompra
        {
            get { return codCompra; }
            set { codCompra = value; }
        }

        [DataMember]
        public String CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }

        [DataMember]
        public String Fechacompra
        {
            get { return fechacompra; }
            set { fechacompra = value; }
        }

        [DataMember]
        public String Total
        {
            get { return total; }
            set { total = value; }
        }


    }
}
