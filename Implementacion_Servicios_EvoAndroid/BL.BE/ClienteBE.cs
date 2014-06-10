using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.BE
{
    public class ClienteBE
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

        public ClienteBE(String codcliente, String nomcliente, String apecliente, String telefono
                        , String direccion, String correo, String usuario,
                         String contrasena, String rutaimg)
        {

                              CodCliente1=codcliente;
                              NomCliente1=nomcliente;
                              ApeCliente1=apecliente;
                              Telefono1=telefono;
                              Direccion1=direccion;
                              RutaIMG1=rutaimg;
                              Correo1=correo;
                              Usuario1=usuario;
                              Contrasena1 = contrasena;
        
        }

        public ClienteBE(String cod,String usu, String contra)
        {
            CodCliente1 = cod;
            Usuario1 = usu;
            Contrasena1 = contra;
        }

        public String CodCliente1
        {
            get { return CodCliente; }
            set { CodCliente = value; }
        }
        

        public String NomCliente1
        {
            get { return NomCliente; }
            set { NomCliente = value; }
        }
        

        public String ApeCliente1
        {
            get { return ApeCliente; }
            set { ApeCliente = value; }
        }
        

        public String Telefono1
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        

        public String Direccion1
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        

        public String Correo1
        {
            get { return Correo; }
            set { Correo = value; }
        }
        

        public String Usuario1
        {
            get { return Usuario; }
            set { Usuario = value; }
        }
        

        public String Contrasena1
        {
            get { return Contrasena; }
            set { Contrasena = value; }
        }
        

        public String RutaIMG1
        {
            get { return RutaIMG; }
            set { RutaIMG = value; }
        }
    }
}
