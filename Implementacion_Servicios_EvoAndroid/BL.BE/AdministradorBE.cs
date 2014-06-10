using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.BE
{
    public class AdministradorBE
    {
        String CodAdmin;
        String NomAdmin;
        String ApeAdmin;
        String Usuario;
        String Contrasena;

        public AdministradorBE(String cod, String nom, String ape, String usu, String contras) {
            CodAdmin1 = cod;
            NomAdmin1 = nom;
            ApeAdmin1 = ape;
            Usuario1 = usu;
            Contrasena1 = contras;
        }


        public String CodAdmin1
        {
            get { return CodAdmin; }
            set { CodAdmin = value; }
        }
        

        public String NomAdmin1
        {
            get { return NomAdmin; }
            set { NomAdmin = value; }
        }
        

        public String ApeAdmin1
        {
            get { return ApeAdmin; }
            set { ApeAdmin = value; }
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
       
        

        
    }
}
