using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.BE
{
    public class UniversidadBE
    {
        Int32 codigo;
        String nombre;
        String siglas; 
        String direccion;
        String distrito;
        String correo;
        Int32 ranking;


        public UniversidadBE(Int32 codigo, String nombre, String siglas, String direccion, String distrito, String correo, Int32 ranking)
        {
            Codigo = codigo;
            Nombre = nombre;
            Siglas = siglas;
            Direccion = direccion;
            Distrito = distrito;
            Correo = correo;
            Ranking = ranking;
        
        }

        public Int32 Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        

        public String Siglas
        {
            get { return siglas; }
            set { siglas = value; }
        }
        

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        

        public String Distrito
        {
            get { return distrito; }
            set { distrito = value; }
        }
        

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        

        public Int32 Ranking
        {
            get { return ranking; }
            set { ranking = value; }
        }

    }
}
