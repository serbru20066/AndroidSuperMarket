using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.BE
{
    public class SupermercadoBE
    {
        String codigo;
        String nombre;
        String ruc;
        String telefono;
        String paginaweb;
        String rutaimg;


        public SupermercadoBE(String cod, String nom, String rucs, String telf, String paginaw, String rimg)
        {
             codigo = cod;
             nombre=nom;
             ruc=rucs;
             telefono=telf;
             paginaweb=paginaw;
             rutaimg=rimg;
        }


        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }


        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public String Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }


        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


        public String Paginaweb
        {
            get { return paginaweb; }
            set { paginaweb = value; }
        }


        public String Rutaimg
        {
            get { return rutaimg; }
            set { rutaimg = value; }
        }


    }
}
