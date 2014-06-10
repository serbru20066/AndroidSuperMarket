using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Linq;
using System.Configuration;

using BL.BE;

using DL.DataModel;



namespace DL.Dalc
{
    public class ServiciosDALC
    {
       public List<ClienteBE>  ObtenerClientes()
        {

           BrunoModelDataContext objModel;
           objModel = new BrunoModelDataContext();

           IQueryable<ClienteBE> lstClientesBE = (from objbruno in objModel.Clientes select new ClienteBE(objbruno.CodCliente, objbruno.NomCliente, objbruno.ApeCliente, objbruno.Telefono, objbruno.Direccion, objbruno.Correo, objbruno.Usuario, objbruno.Contrasena, objbruno.RutaIMG));

           return lstClientesBE.ToList();

        }

       public List<SupermercadoBE> ObtenerSupermercados()
       {

           BrunoModelDataContext objModel;
           objModel = new BrunoModelDataContext();

           IQueryable<SupermercadoBE> lstSuperMercadosBE = (from objbruno in objModel.SuperMercados select new 
               SupermercadoBE(objbruno.CodSuperMercado, objbruno.NomSuperMercado, objbruno.Ruc, objbruno.Telefono, objbruno.PaginaWeb, objbruno.RutaIMG));

           return lstSuperMercadosBE.ToList();

       }

       public int Loguin(ClienteBE objClienteBE)
       {
           try
           {
               BrunoModelDataContext objModel;
               objModel = new BrunoModelDataContext();//ConfigurationManager.ConnectionStrings["BrunoConnectionString"].ToString());

               ClienteBE objcli = (from objbruno in objModel.Clientes where objbruno.Usuario.Equals(objClienteBE.Usuario1) &&  
                                       objbruno.Contrasena.Equals(objClienteBE.Contrasena1) 
                                   select new ClienteBE(objbruno.CodCliente,objbruno.Usuario, objbruno.Contrasena)).SingleOrDefault();

          
               if (objcli==null)
               {
                   return 0;
               }
               else
               {
                   return Int32.Parse(objcli.CodCliente1);
               }

           }
           catch (Exception ex)
           {
               throw;
           }
       }

       public AdministradorBE LoguinAdmin(AdministradorBE objAdminBE)
       {
           try
           {
               BrunoModelDataContext objModel;
               objModel = new BrunoModelDataContext();//ConfigurationManager.ConnectionStrings["BrunoConnectionString"].ToString());

               AdministradorBE objcli = (from objbruno in objModel.Administradors
                                         where objbruno.Usuario.Equals(objAdminBE.Usuario1) &&
                                       objbruno.Contrasena.Equals(objAdminBE.Contrasena1)
                                         select new AdministradorBE(objbruno.CodAdministrador, objbruno.NomAdministrador, objbruno.ApeAdministrados, objbruno.Usuario, objbruno.Contrasena)).SingleOrDefault();


               if (objcli == null)
               {
                   return null;
               }
               else
               {
                   return objcli;
               }

           }
           catch (Exception ex)
           {
               throw;
           }
       }


       public List<ProductoBE> ObtenerProductosFiltro1(String codSupermercado,String marca,String categoria, String oferta)
       {
           try
           {
               BrunoModelDataContext objModel;
               objModel = new BrunoModelDataContext();

               List<ProductoBE> lstProductos = (from objProducto in objModel.Productos
                                                join objProductoxSuperMercado in objModel.Producto_SuperMercados on objProducto.CodProducto equals objProductoxSuperMercado.CodProducto
                                                where objProductoxSuperMercado.CodSuperMercado.Equals(codSupermercado) &&
                                                objProducto.Marca.Equals(marca) && objProducto.Categoria.Equals(categoria) && objProductoxSuperMercado.Oferta.Equals(oferta)
                                                select new ProductoBE(objProducto.CodProducto, objProducto.NomProducto, objProducto.Categoria, objProducto.Marca, objProducto.FecVencimiento, objProductoxSuperMercado.Precio, objProducto.RutaIMG)).ToList();

               if (lstProductos == null)
               {
                   List<ProductoBE> lstProductosAux = null;
                   return lstProductosAux;
               }

               else
                   return lstProductos;



               int x;

           }
           catch (Exception ex)
           {
               throw;
           }
       }

       public List<ProductoBE> ObtenerProductosFiltro2(String nomSupermercado)
       {
           try
           {
               BrunoModelDataContext objModel;
               objModel = new BrunoModelDataContext();

               List<ProductoBE> lstProductos = (from objProducto in objModel.Productos
                                                join objProductoxSuperMercado in objModel.Producto_SuperMercados on objProducto.CodProducto equals objProductoxSuperMercado.CodProducto
                                                join objSupermercado in objModel.SuperMercados on objProductoxSuperMercado.CodSuperMercado equals objSupermercado.CodSuperMercado
                                                where objSupermercado.NomSuperMercado.Equals(nomSupermercado)
                                                select new ProductoBE(objProducto.CodProducto, objProducto.NomProducto, objSupermercado.NomSuperMercado, objSupermercado.CodSuperMercado, objProducto.Categoria, objProducto.Marca, objProducto.FecVencimiento, objProductoxSuperMercado.Precio, objProducto.RutaIMG)).ToList();

               if (lstProductos == null)
               {
                   List<ProductoBE> lstProductosAux = null;
                   return lstProductosAux;
               }

               else
                   return lstProductos;             

           }
           catch (Exception ex)
           {
               throw;
           }
       }

       public ProductoBE ObtenerProductosFiltro3(String codSupermercado,String codproducto)
       {
           try
           {
               BrunoModelDataContext objModel;
               objModel = new BrunoModelDataContext();

               ProductoBE lstProductos = (from objProducto in objModel.Productos
                                          join objProductoxSuperMercado in objModel.Producto_SuperMercados on objProducto.CodProducto equals objProductoxSuperMercado.CodProducto
                                          join objSupermercado in objModel.SuperMercados on objProductoxSuperMercado.CodSuperMercado equals objSupermercado.CodSuperMercado
                                          where objSupermercado.CodSuperMercado.Equals(codSupermercado) && objProducto.CodProducto.Equals(codproducto)
                                          select new ProductoBE(objProducto.CodProducto, objProducto.NomProducto, objSupermercado.NomSuperMercado, objSupermercado.CodSuperMercado, objProducto.Categoria, objProducto.Marca, objProducto.FecVencimiento, objProductoxSuperMercado.Precio, objProducto.RutaIMG)).SingleOrDefault();

               if (lstProductos == null)
               {
                   ProductoBE lstProductosAux = null;
                   return lstProductosAux;
               }

               else
                   return lstProductos;

           }
           catch (Exception ex)
           {
               throw;
           }
       }

      public ProductoBE ActualizaPrecioProducto(String codproducto, String codsupermercado, String precio)
      {
       

        BrunoModelDataContext objModel;
        objModel = new BrunoModelDataContext();

        var query =
         from prodsuper in objModel.Producto_SuperMercados
         where prodsuper.CodProducto.Equals(codproducto) && prodsuper.CodSuperMercado.Equals(codsupermercado)  
         select prodsuper;

        if (query == null)
        {
            ProductoBE prodobjAux = null;
            return prodobjAux;
        }

        foreach (Producto_SuperMercado compr in query)
        {
            compr.Precio  = precio;
        }

       
        try
        {
            objModel.SubmitChanges();          

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
           
        }

        ProductoBE objproducto = new ProductoBE(codproducto,codsupermercado,precio );
        return objproducto;
      }
       



       public List<Compra_Producto_SuperMercadoBE > ObtenerDetallesCompra(String codCompra,String codSupermer)
       {
           try
           {
               BrunoModelDataContext objModel;
               objModel = new BrunoModelDataContext();

               List<Compra_Producto_SuperMercadoBE> lstProductos = (
                   from objproducto in objModel.Productos 
                   join objProdSuper in objModel.Producto_SuperMercados on objproducto.CodProducto equals objProdSuper.CodProducto
                                                                    join objdetalle in objModel.Compra_Producto_SuperMercados on objProdSuper.CodProducto equals objdetalle.CodProducto
                                                                    join objsuper in objModel.SuperMercados on objdetalle.CodSuperMercado equals objsuper.CodSuperMercado 

                                                                    join objCompra in objModel.Compras on objdetalle.CodCompra equals objCompra.CodCompra



                                                                    where objdetalle.CodCompra.Equals(codCompra) && objCompra.CodCompra.Equals(codCompra) && objdetalle.CodSuperMercado.Equals(codSupermer)
                   select new Compra_Producto_SuperMercadoBE(objproducto.NomProducto, int.Parse(objdetalle.Cantidad.ToString()), objdetalle.SubTotal)).ToList();
               
               if (lstProductos == null)
               {
                   List<Compra_Producto_SuperMercadoBE> lstProductosAux = null;
                   return lstProductosAux;
               }

               else
                   return lstProductos;



               int x;

           }
           catch (Exception ex)
           {
               throw;
           }
       }


    public int RegistroCompra(CompraBE  objCompraBE)
    {
        try
        {
            BrunoModelDataContext objModel;
            objModel = new BrunoModelDataContext();


            //revizar si ya existe la compra para ese cliente
            CompraBE objcli = (from objbruno in objModel.Compras
                               where objbruno.CodCompra.Equals(objCompraBE.CodCompra) &&
                                    objbruno.CodCliente.Equals(objCompraBE.CodCliente)
                                      select new CompraBE(objbruno.CodCompra, objbruno.CodCliente,
                                      objbruno.FecCompra, objbruno.total)).SingleOrDefault();

            if (objcli != null)
                return int.Parse(objcli.CodCompra);




            Compra  objnuevo;
            objnuevo = new Compra();


            objnuevo.CodCompra = objCompraBE.CodCompra; 
            objnuevo.CodCliente = objCompraBE.CodCliente ;
            objnuevo.FecCompra = objCompraBE.Fechacompra;
            objnuevo.total = objCompraBE.Total;


            objModel.Compras.InsertOnSubmit(objnuevo);
            objModel.SubmitChanges();

            return Convert.ToInt32(objnuevo.CodCompra);
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public int RegistroDetalleCompra(Compra_Producto_SuperMercadoBE  objDetalleBE)
    {
        try
        {
            BrunoModelDataContext objModel;
            objModel = new BrunoModelDataContext();


            //revizar si ya existe el detalle
            Compra_Producto_SuperMercadoBE objdetalle = (from objbruno in objModel.Compra_Producto_SuperMercados
                               where objbruno.CodCompra.Equals(objDetalleBE.CodCompra) &&
                                    objbruno.CodCliente.Equals(objDetalleBE.CodCliente) &&
                                    objbruno.CodProducto.Equals(objDetalleBE.CodProducto) &&
                                    objbruno.CodSuperMercado.Equals(objDetalleBE.CodSupermercado)
                               select new Compra_Producto_SuperMercadoBE(objbruno.CodCompra, objbruno.CodCliente,
                               objbruno.CodProducto, objbruno.CodSuperMercado, int.Parse(objbruno.Cantidad.ToString()), objbruno.SubTotal)).SingleOrDefault();

            if (objdetalle != null)
                return int.Parse(objdetalle.CodCompra);


            Compra_Producto_SuperMercado  objnuevo;
            objnuevo = new Compra_Producto_SuperMercado();



            objnuevo.CodCompra = objDetalleBE.CodCompra;
            objnuevo.CodCliente = objDetalleBE.CodCliente;
            objnuevo.CodSuperMercado = objDetalleBE.CodSupermercado;
            objnuevo.CodProducto = objDetalleBE.CodProducto;
            objnuevo.Cantidad = objDetalleBE.Cantidad;
            objnuevo.SubTotal = objDetalleBE.Subtotal;


            objModel.Compra_Producto_SuperMercados.InsertOnSubmit(objnuevo);  
            objModel.SubmitChanges();

            return Convert.ToInt32(objnuevo.CodCompra);
        }
        catch (Exception ex)
        {
            throw;
        }
    }


    public int ActualizaCompra(String codCompra,String subtotal)
      {
        int compraEncontrada = 0;

        BrunoModelDataContext objModel;
        objModel = new BrunoModelDataContext();

        String totalActual =
        (from compra in objModel.Compras
        where compra.CodCompra.Equals(codCompra)
        select compra.total).SingleOrDefault();

       

        double totalActualint = double.Parse(totalActual);

        double totalNuevo = totalActualint + double.Parse(subtotal);

        String totalNuevoString = totalNuevo.ToString();


        var query =
        from compr in objModel.Compras
        where compr.CodCompra.Equals(codCompra)
        select compr;

       
        foreach (Compra compr in query)
        {
            compr.total = totalNuevoString;
        }

       
        try
        {
            objModel.SubmitChanges();

            if (query != null)
                compraEncontrada= 1;
            else
                compraEncontrada= 0;

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
           
        }

               
        return  compraEncontrada;


      }
       
    }
}
