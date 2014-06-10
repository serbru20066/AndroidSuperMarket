using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.BE
{
    public class UsuarioBE
    {
        String usuario;
        String contrasena;

        public UsuarioBE(String usu, String contra)
        {
            Usuario = usu;
            Contrasena = contra;
        }

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public String Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
    }
}
