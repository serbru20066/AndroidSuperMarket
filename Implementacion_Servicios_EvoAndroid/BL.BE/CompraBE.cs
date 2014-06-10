using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.BE
{
    public class CompraBE
    {

        String codCompra;
        String codCliente;
        String fechacompra;
        String total;

        public CompraBE(String codcompr, String codCli, String fecCompra, String tot)
        {
            codCompra = codcompr;
            codCliente = codCli;
            fechacompra = fecCompra;
            total = tot;
        
        }


        public String CodCompra
        {
            get { return codCompra; }
            set { codCompra = value; }
        }
       

        public String CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }
       

        public String Fechacompra
        {
            get { return fechacompra; }
            set { fechacompra = value; }
        }
        

        public String Total
        {
            get { return total; }
            set { total = value; }
        }


    }
}
