using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BL.BE;
using SI.DataContract; 

namespace SI.ServiceImplementation
{
    public sealed class TranslatorHelper
    {

        public static ClienteCollectionDC TranslateBetweenListaClienteBEToClienteCollectionDC(List<ClienteBE> lstClienteBE)
        {
           

            int i;
            ClienteDC objClienteDC;
            ClienteCollectionDC lstClienteDC;
            lstClienteDC = new ClienteCollectionDC();

           

            for (i = 0; i < lstClienteBE.Count; i++)
            {
                objClienteDC = TranslateBetweenClienteBEToClienteDC(lstClienteBE[i]);
                lstClienteDC.Add(objClienteDC);
            }

            return lstClienteDC;
        }

        public static ClienteDC TranslateBetweenClienteBEToClienteDC(ClienteBE objClienteBE)
        {

            ClienteDC objClienteDC = new ClienteDC();

            objClienteDC.CodCliente1 = objClienteBE.CodCliente1;
            objClienteDC.NomCliente1 = objClienteBE.NomCliente1;
            objClienteDC.ApeCliente1 = objClienteBE.ApeCliente1;
            objClienteDC.Direccion1 = objClienteBE.Direccion1;
            objClienteDC.Telefono1 = objClienteBE.Telefono1;
            objClienteDC.Correo1 = objClienteBE.Correo1;
            objClienteDC.Usuario1 = objClienteBE.Usuario1;
            objClienteDC.Contrasena1 = objClienteBE.Contrasena1;
            objClienteDC.RutaIMG1 = objClienteBE.RutaIMG1;

            return objClienteDC;
        }

        public static SuperMercadoCollectionDC TranslateBetweenListaSuperMercadoBEToSuperMercadoCollectionDC(List<SupermercadoBE> lstSuperMercadoBE)
        {


            int i;
            SuperMercadoDC objSuperMercadoDC;
            SuperMercadoCollectionDC lstSuperMercadoDC;
            lstSuperMercadoDC = new SuperMercadoCollectionDC();



            for (i = 0; i < lstSuperMercadoBE .Count; i++)
            {
                objSuperMercadoDC = TranslateBetweenSuperMercadoBEToSuperMercadoDC(lstSuperMercadoBE[i]);
                lstSuperMercadoDC.Add(objSuperMercadoDC);
            }

            return lstSuperMercadoDC;
        }

        public static SuperMercadoDC TranslateBetweenSuperMercadoBEToSuperMercadoDC(SupermercadoBE objSuperMercadoBE)
        {

            SuperMercadoDC objSuperMercadoDC = new SuperMercadoDC();
            objSuperMercadoDC.Codigo = objSuperMercadoBE.Codigo;
            objSuperMercadoDC.Nombre = objSuperMercadoBE.Nombre;
            objSuperMercadoDC.Ruc = objSuperMercadoBE.Ruc;
            objSuperMercadoDC.Telefono = objSuperMercadoBE.Telefono;
            objSuperMercadoDC.Paginaweb = objSuperMercadoBE.Paginaweb;
            objSuperMercadoDC.Rutaimg = objSuperMercadoBE.Rutaimg;

            return objSuperMercadoDC;
        }


        public static ProductoCollectionDC  TranslateBetweenListaProductoBEToProductoCollectionDC(List<ProductoBE > lstProductoBE)
        {


            int i;
            ProductoDC objProductoDC;
            ProductoCollectionDC  lstProductoDC;
            lstProductoDC = new ProductoCollectionDC();



            for (i = 0; i < lstProductoBE.Count; i++)
            {
                objProductoDC = TranslateBetweenProductoBEToProductoDC(lstProductoBE[i]);
                lstProductoDC.Add(objProductoDC);
            }

            return lstProductoDC;
        }


        public static ProductoDC TranslateBetweenProductoBEToProductoDC(ProductoBE objProductoBE)
        {

            if (objProductoBE == null)
                return null;

            ProductoDC objProductoDC = new ProductoDC();
            objProductoDC.Codigo = objProductoBE.Codigo;
            objProductoDC.Nombre = objProductoBE.Nombre;
            objProductoDC.Marca = objProductoBE.Marca;
            objProductoDC.Categoria = objProductoBE.Categoria;
            objProductoDC.Fecvencimiento = objProductoBE.Fecvencimiento;
            objProductoDC.Rutaimg = objProductoBE.Rutaimg;
            objProductoDC.Precio = objProductoBE.Precio;
            objProductoDC.Cantidad = objProductoBE.Cantidad;
            objProductoDC.Subtotal= objProductoBE.Subtotal;
            objProductoDC.NomSupermercado = objProductoBE.NomSupermercado;
            objProductoDC.CodSupermer = objProductoBE.CodSupermer;


            return objProductoDC;
  
           
        }

        public static Compra_Producto_SuperMercadoDC  TranslateBetweenDetalleCompraBEToDetalleCompraDC(Compra_Producto_SuperMercadoBE  objDetalleCompraBE)
        {

            Compra_Producto_SuperMercadoDC objDetalleCompraDC = new Compra_Producto_SuperMercadoDC();
            
                objDetalleCompraDC.CodProducto=objDetalleCompraBE.CodProducto;
                objDetalleCompraDC.CodSupermercado=objDetalleCompraBE.CodSupermercado;
                objDetalleCompraDC.CodCompra=objDetalleCompraBE.CodCompra;
                objDetalleCompraDC.Cantidad =objDetalleCompraBE.Cantidad;
                objDetalleCompraDC.Subtotal = objDetalleCompraBE.Subtotal;

            objDetalleCompraDC.Nombre =objDetalleCompraBE.Nombre ;

            objDetalleCompraDC.Precio = objDetalleCompraBE.Precio;

                return objDetalleCompraDC;


        }

        public static DetallesCollectionDC  TranslateBetweenListaDetalleCOmpraBEToDetalleCompraDC(List<Compra_Producto_SuperMercadoBE > lstDetalleCompraBE)
        {


            int i;
            Compra_Producto_SuperMercadoDC  objDetalleCompraDC;
            DetallesCollectionDC lstDetalleCompraDC;
            lstDetalleCompraDC = new DetallesCollectionDC();



            for (i = 0; i < lstDetalleCompraBE.Count; i++)
            {
                objDetalleCompraDC = TranslateBetweenDetalleCompraBEToDetalleCompraDC(lstDetalleCompraBE[i]);
                lstDetalleCompraDC.Add(objDetalleCompraDC);
            }

            return lstDetalleCompraDC;
        }



        public static CompraBE TranslateBetweenRegistroCompraDCToRegistroCompraBE(CompraDC objCompraDC)
        {
            CompraBE  objRegistroBE;
            objRegistroBE = new CompraBE(objCompraDC.CodCompra, objCompraDC.CodCliente, objCompraDC.Fechacompra, objCompraDC.Total);

            return objRegistroBE;
        }


        public static Compra_Producto_SuperMercadoBE  TranslateBetweenRegistroCompraDetalleDCToRegistroCompraDetalleBE(Compra_Producto_SuperMercadoDC  objDetalleCompraDC)
        {
            Compra_Producto_SuperMercadoBE objDetalleRegistroBE;
            objDetalleRegistroBE = new Compra_Producto_SuperMercadoBE(objDetalleCompraDC.CodCompra, objDetalleCompraDC.CodCliente, objDetalleCompraDC.CodProducto, objDetalleCompraDC.CodSupermercado, objDetalleCompraDC.Cantidad, objDetalleCompraDC.Subtotal );

            return objDetalleRegistroBE;
        }

        /* public static UniversidadCollectionDC TranslateBetweenUniversidadBEToUniversidadCollectionDC(List<UniversidadBE> lstUniversidadBE)
         {


             int i;
             UniversidadDC objUniversidadDC;
             UniversidadCollectionDC lstUniversidadDC;
             lstUniversidadDC = new UniversidadCollectionDC();

             for (i = 0; i < lstUniversidadBE.Count; i++)
             {
                 objUniversidadDC = TranslateBetweenUniversidadBEToUniversidadDC(lstUniversidadBE[i]);
                 lstUniversidadDC.Add(objUniversidadDC);
             }

             return lstUniversidadDC;
         }
         public static UniversidadDC TranslateBetweenUniversidadBEToUniversidadDC(UniversidadBE objUniversidadBE)
         {

             UniversidadDC objUniversidadDC = new UniversidadDC();

             objUniversidadDC.Codigo = objUniversidadBE.Codigo;
             objUniversidadDC.Correo = objUniversidadBE.Correo;
             objUniversidadDC.Direccion = objUniversidadBE.Direccion;
             objUniversidadDC.Distrito = objUniversidadBE.Distrito;
             objUniversidadDC.Nombre = objUniversidadBE.Nombre;
             objUniversidadDC.Ranking = objUniversidadBE.Ranking;
             objUniversidadDC.Siglas = objUniversidadBE.Siglas;

             return objUniversidadDC;
         }
       


         public static UniversidadBE TranslateBetweenRegistroUniversidadDCToRegistroUniversidadBE(UniversidadDC objUniversidadDC)
         {
             UniversidadBE objRegistroBE;
             objRegistroBE = new UniversidadBE(Convert.ToInt32(objUniversidadDC.Codigo), objUniversidadDC.Nombre, objUniversidadDC.Siglas, objUniversidadDC.Direccion, objUniversidadDC.Distrito, objUniversidadDC.Correo, Convert.ToInt32(objUniversidadDC.Ranking));

             return objRegistroBE;
         }
         */
        public static ClienteBE TranslateBetweenClienteDCToRegistroClienteBE(ClienteDC objClienteDC)
        {
            ClienteBE objClienteBE;

            objClienteBE = new ClienteBE(objClienteDC.CodCliente1, objClienteDC.Usuario1, objClienteDC.Contrasena1);

            return objClienteBE;
        }


        public static AdministradorBE TranslateBetweenAdminDCToRegistroAdminBE(AdministradorDC objAdminDC)
        {
            AdministradorBE objAdminBE;

            objAdminBE = new AdministradorBE(objAdminDC.CodAdmin1, objAdminDC.NomAdmin1, objAdminDC.ApeAdmin1, objAdminDC.Usuario1 , objAdminDC.Contrasena1);

            return objAdminBE;
        }

        public static AdministradorDC TranslateBetweenAdminBEToRegistroAdminDC(AdministradorBE objAdminBE)
        {
            



            AdministradorDC objAdministradorDC = new AdministradorDC();


            if (objAdminBE == null)
                return null;

            objAdministradorDC.CodAdmin1 = objAdminBE.CodAdmin1;
            objAdministradorDC.NomAdmin1 = objAdminBE.NomAdmin1;
            objAdministradorDC.ApeAdmin1 = objAdminBE.ApeAdmin1;
            objAdministradorDC.Usuario1 = objAdminBE.Usuario1;
            objAdministradorDC.Contrasena1 = objAdminBE.Contrasena1;




            return objAdministradorDC;


        }

       

    }
}
