using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;
using SI.DataContract;
using SI.ServiceContracts;
using BL.BC;
using BL.BE;


namespace SI.ServiceImplementation
{
    public class BrunoSI : IBrunoSC
    {
        CelularCollectionDC objCelularCollectionDC = new CelularCollectionDC();

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GET/ObtenerBruno")]
        BrunoDC IBrunoSC.obtenerBruno()
        {
            BrunoDC objBrunoDC = new BrunoDC();
            objBrunoDC.Apellido = "Cardenas Torres";
            objBrunoDC.Nombre = "Bruno Sergio";
            objBrunoDC.Edad = 25;

            return objBrunoDC;
        }
        
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GET/ObtenerCelulares")]
        CelularCollectionDC IBrunoSC.obtenerCelulares()
        {
            
            CelularDC objCelularDC = new CelularDC();
            objCelularDC.NumCores = 1;
            objCelularDC.Modelo = "Galaxy S1";
            objCelularDC.Marca = "Samsung";
            objCelularDC.Imei = "123";

            objCelularCollectionDC.Add(objCelularDC);

            objCelularDC = new CelularDC();
            objCelularDC.NumCores = 2;
            objCelularDC.Modelo = "Galaxy S2";
            objCelularDC.Marca = "Samsung";
            objCelularDC.Imei = "124";

            objCelularCollectionDC.Add(objCelularDC);

            objCelularDC = new CelularDC();
            objCelularDC.NumCores = 4;
            objCelularDC.Modelo = "Galaxy S3";
            objCelularDC.Marca = "Samsung";
            objCelularDC.Imei = "125";

            objCelularCollectionDC.Add(objCelularDC);

            objCelularDC = new CelularDC();
            objCelularDC.NumCores = 1;
            objCelularDC.Modelo = "N8";
            objCelularDC.Marca = "Nokia";
            objCelularDC.Imei = "126";

            objCelularCollectionDC.Add(objCelularDC);

            return objCelularCollectionDC;
        }

        
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GET/ObtenerCelularPorImei?Imei={Imei}")]
        CelularDC IBrunoSC.obtenerCelularPorImei(String Imei)
        {
           
            CelularDC objCelularDC = new CelularDC();
            objCelularDC.NumCores = 1;
            objCelularDC.Modelo = "Galaxy S1";
            objCelularDC.Marca = "Samsung";
            objCelularDC.Imei = "123";

            objCelularCollectionDC.Add(objCelularDC);

            objCelularDC = new CelularDC();
            objCelularDC.NumCores = 2;
            objCelularDC.Modelo = "Galaxy S2";
            objCelularDC.Marca = "Samsung";
            objCelularDC.Imei = "124";

            objCelularCollectionDC.Add(objCelularDC);

            objCelularDC = new CelularDC();
            objCelularDC.NumCores = 4;
            objCelularDC.Modelo = "Galaxy S3";
            objCelularDC.Marca = "Samsung";
            objCelularDC.Imei = "125";

            objCelularCollectionDC.Add(objCelularDC);

            objCelularDC = new CelularDC();
            objCelularDC.NumCores = 1;
            objCelularDC.Modelo = "N8";
            objCelularDC.Marca = "Nokia";
            objCelularDC.Imei = "126";

            objCelularCollectionDC.Add(objCelularDC);


            for (int i = 0; i < objCelularCollectionDC.Count; i++)
            {
                if (objCelularCollectionDC[i].Imei.Equals(Imei))
                    return objCelularCollectionDC[i];
            
            }

            CelularDC objCelularDC2 = new CelularDC();
            return objCelularDC2;
            
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GET/ObtenerBrunoCelulares")]
        BrunoCelularesDC IBrunoSC.obtenerBrunoCelulares()
        {
            BrunoCelularesDC objBrunoCelularesDC = new BrunoCelularesDC();
            objBrunoCelularesDC.Apellido = "Cardenas Torres";
            objBrunoCelularesDC.Nombre = "Bruno Sergio";
            objBrunoCelularesDC.Edad = 25;

            objBrunoCelularesDC.LstCelularDC = new System.Collections.ObjectModel.Collection<CelularDC>();
            CelularDC objCelularDC = new CelularDC();
            objCelularDC.NumCores = 1;
            objCelularDC.Modelo = "Galaxy S1";
            objCelularDC.Marca = "Samsung";
            objCelularDC.Imei = "123";

            objBrunoCelularesDC.LstCelularDC.Add(objCelularDC);

            objCelularDC = new CelularDC();
            objCelularDC.NumCores = 2;
            objCelularDC.Modelo = "Galaxy S2";
            objCelularDC.Marca = "Samsung";
            objCelularDC.Imei = "124";

            objBrunoCelularesDC.LstCelularDC.Add(objCelularDC);

            objCelularDC = new CelularDC();
            objCelularDC.NumCores = 4;
            objCelularDC.Modelo = "Galaxy S3";
            objCelularDC.Marca = "Samsung";
            objCelularDC.Imei = "125";

            objBrunoCelularesDC.LstCelularDC.Add(objCelularDC);

            objCelularDC = new CelularDC();
            objCelularDC.NumCores = 1;
            objCelularDC.Modelo = "N8";
            objCelularDC.Marca = "Nokia";
            objCelularDC.Imei = "126";

            objBrunoCelularesDC.LstCelularDC.Add(objCelularDC);

            return objBrunoCelularesDC;
        }


        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GET/AgregarCelular?Imei={Imei}&Modelo={Modelo}&Marca={Marca}&NumCores={NumCores}")]
        void IBrunoSC.agregarCelular(String Imei, String Marca, String Modelo, int NumCores)
        {

            CelularDC objCelularDC = new CelularDC();
            objCelularDC.Imei = Imei;
            objCelularDC.Marca = Marca;
            objCelularDC.Modelo = Modelo;
            objCelularDC.NumCores = NumCores;

            objCelularCollectionDC.Add(objCelularDC);

        }


        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GET/ObtenerClientes")]
        ClienteCollectionDC IBrunoSC.ObtenerClientes()
        {

            try
            {
                UniversidadBC objUniversidadBC;//aca estan todos los business contracts de todas las entidades
                objUniversidadBC = new UniversidadBC();

                return TranslatorHelper.TranslateBetweenListaClienteBEToClienteCollectionDC(objUniversidadBC.ObtenerClientes());
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrió una excepción");

            }
        }


        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetSuperMercados")]
        SuperMercadoCollectionDC IBrunoSC.ObtenerSuperMercados()
        {

            try
            {
                UniversidadBC objUniversidadBC;//aca estan todos los business contracts de todas las entidades
                objUniversidadBC = new UniversidadBC();

                return TranslatorHelper.TranslateBetweenListaSuperMercadoBEToSuperMercadoCollectionDC(objUniversidadBC.ObtenerSuperMercados());
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrió una excepción");

            }
        }


        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetProductosFiltro1?codsupermercado={codsupermercado}&marca={marca}&categoria={categoria}&oferta={oferta}")]
        ProductoCollectionDC  IBrunoSC.ObtenerProductosFiltro1(String codsupermercado,String marca,String categoria, String oferta)
        {

            try
            {
                UniversidadBC objUniversidadBC;//aca estan todos los business contracts de todas las entidades
                objUniversidadBC = new UniversidadBC();

                return TranslatorHelper.TranslateBetweenListaProductoBEToProductoCollectionDC(objUniversidadBC.ObtenerProductosFiltro1(codsupermercado, marca, categoria, oferta));
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrió una excepción");

            }
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetProductosFiltro2?nomsupermercado={nomSupermercado}")]
        ProductoCollectionDC IBrunoSC.ObtenerProductosFiltro2(String nomSupermercado)
        {

            try
            {
                UniversidadBC objUniversidadBC;//aca estan todos los business contracts de todas las entidades
                objUniversidadBC = new UniversidadBC();

                return TranslatorHelper.TranslateBetweenListaProductoBEToProductoCollectionDC(objUniversidadBC.ObtenerProductosFiltro2(nomSupermercado));
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrió una excepción");

            }
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetProductosFiltro3?codsupermercado={codSupermercado}&codproducto={codProducto}")]
        ProductoDC IBrunoSC.ObtenerProductosFiltro3(String codSupermercado,String codProducto)
        {

            try
            {
                UniversidadBC objUniversidadBC;//aca estan todos los business contracts de todas las entidades
                objUniversidadBC = new UniversidadBC();

                return TranslatorHelper.TranslateBetweenProductoBEToProductoDC(objUniversidadBC.ObtenerProductosFiltro3(codSupermercado, codProducto));
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrió una excepción");

            }
        }


        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ActualizaPrecioProducto?codProducto={codproducto}&codSupermercado={codsupermercado}&Precio={precio}")]
        ProductoDC IBrunoSC.ActualizaPrecioProducto(String codproducto, String codsupermercado, String precio)
        {

            try
            {
                UniversidadBC objUniversidadBC;//aca estan todos los business contracts de todas las entidades
                objUniversidadBC = new UniversidadBC();

                return TranslatorHelper.TranslateBetweenProductoBEToProductoDC(objUniversidadBC.ActualizaPrecioProducto(codproducto, codsupermercado, precio));
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrió una excepción");

            }
        }


        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetDetallesCompra?codcompra={codCompra}&codSupermer={codSupermer}")]
        DetallesCollectionDC IBrunoSC.ObtenerDetallesCompra(String codCompra, String codSupermer)
        {

            try
            {
                UniversidadBC objUniversidadBC;//aca estan todos los business contracts de todas las entidades
                objUniversidadBC = new UniversidadBC();

                return TranslatorHelper.TranslateBetweenListaDetalleCOmpraBEToDetalleCompraDC(objUniversidadBC.ObtenerDetallesCompra(codCompra,codSupermer ));
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrió una excepción");

            }
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetRegistraCompra?codcompra={codcompra}&codcliente={codcliente}&fechacompra={fechacompra}&total={total}")]
        int IBrunoSC.RegistroCompra(String codcompra, String codcliente, String fechacompra, String total)
        {

            CompraDC objCompraDC = new CompraDC();
            objCompraDC.CodCompra = codcompra;
            objCompraDC.CodCliente = codcliente;
            objCompraDC.Fechacompra = fechacompra;
            objCompraDC.Total = total ;

           
            UniversidadBC objUniversidadBC;
            objUniversidadBC = new UniversidadBC();




            return objUniversidadBC.RegistroCompra(TranslatorHelper.TranslateBetweenRegistroCompraDCToRegistroCompraBE(objCompraDC ));

        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetRegistraDetalleCompra?codcomp={codcomp}&codCli={codCli}&codpro={codpro}&codsuperm={codsuperm}&canti={canti}&subtot={subtot}")]
        int IBrunoSC.RegistroDetalleCompra(String codcomp, String codCli, String codpro, String codsuperm, int canti, String subtot)
        {

            Compra_Producto_SuperMercadoDC objCompraDetalleDC = new Compra_Producto_SuperMercadoDC();
            objCompraDetalleDC.CodCompra = codcomp;
            objCompraDetalleDC.CodCliente = codCli;
            objCompraDetalleDC.CodProducto = codpro;
            objCompraDetalleDC.CodSupermercado = codsuperm;
            objCompraDetalleDC.Cantidad = canti;
            objCompraDetalleDC.Subtotal = subtot;



            UniversidadBC objUniversidadBC;
            objUniversidadBC = new UniversidadBC();

            return objUniversidadBC.RegistroDetalleCompra(TranslatorHelper.TranslateBetweenRegistroCompraDetalleDCToRegistroCompraDetalleBE(objCompraDetalleDC));

        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetActualizaCompra?codcomp={codcomp}&subtot={subtot}")]
        int IBrunoSC.ActualizaCompra(String codcomp, String subtot)
        {
            UniversidadBC objUniversidadBC;
            objUniversidadBC = new UniversidadBC();

            return objUniversidadBC.ActualizaCompra(codcomp, subtot);
        
        }

        /*[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GET/ObtenerUniversidades")]
        UniversidadCollectionDC IBrunoSC.ObtenerUniversidades()
        {

            try
            {
                UniversidadBC objUniversidadBC;
                objUniversidadBC = new UniversidadBC();

                return TranslatorHelper.TranslateBetweenUniversidadBEToUniversidadCollectionDC(objUniversidadBC.ObtenerUniversidades());
            }
            catch (Exception ex)
            {
                
                throw new Exception("Ocurrió una excepción");

            }
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GET/ObtenerUniversidporCodigo?Codigo={codigo}")]
        UniversidadDC IBrunoSC.ObtenerUniversidadPorCodigo(int codigo)
        {

            try
            {
                UniversidadBC objUniversidadBC;
                objUniversidadBC = new UniversidadBC();

                return TranslatorHelper.TranslateBetweenUniversidadBEToUniversidadDC(objUniversidadBC.ObtenerUniversidadPorCodigo(codigo));
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrió una excepción");

            }
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GET/AgregarUniversidad?nombre={nombre}&siglas={siglas}&direccion={direccion}&distrito={distrito}&correo={correo}&ranking={ranking}")]
        int IBrunoSC.RegistroUniversidad(String nombre,String siglas,String direccion,String distrito,String correo,int ranking)
        {

            UniversidadDC objUniversidadDC = new UniversidadDC();
            objUniversidadDC.Correo = correo;
            objUniversidadDC.Direccion = direccion;
            objUniversidadDC.Distrito = distrito;
            objUniversidadDC.Nombre = nombre;
            objUniversidadDC.Ranking = ranking;
            objUniversidadDC.Siglas = siglas;

            UniversidadBC objUniversidadBC;
            objUniversidadBC = new UniversidadBC();

            return objUniversidadBC.RegistroUniversidad(TranslatorHelper.TranslateBetweenRegistroUniversidadDCToRegistroUniversidadBE(objUniversidadDC));

        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GET/ActualizarUniversidad?codigo={codigo}&nombre={nombre}&siglas={siglas}&direccion={direccion}&distrito={distrito}&correo={correo}&ranking={ranking}")]
        int IBrunoSC.ActualizacionUniversidad(int codigo,String nombre, String siglas, String direccion, String distrito, String correo, int ranking)
        {

            UniversidadDC objUniversidadDC = new UniversidadDC();
            objUniversidadDC.Correo = correo;
            objUniversidadDC.Direccion = direccion;
            objUniversidadDC.Distrito = distrito;
            objUniversidadDC.Nombre = nombre;
            objUniversidadDC.Ranking = ranking;
            objUniversidadDC.Siglas = siglas;

            UniversidadBC objUniversidadBC;
            objUniversidadBC = new UniversidadBC();

            return objUniversidadBC.ActualizacionUniversidad(codigo,TranslatorHelper.TranslateBetweenRegistroUniversidadDCToRegistroUniversidadBE(objUniversidadDC));

        }
        */

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GET/Loguin?usuario={usuario}&contrasena={contrasena}")]
        int IBrunoSC.Loguin( String usuario, String contrasena)
        {

            ClienteDC objClienteDC = new ClienteDC();
            objClienteDC.Usuario1 = usuario;
            objClienteDC.Contrasena1 = contrasena;

            UniversidadBC objUniversidadBC;
            objUniversidadBC = new UniversidadBC();

            return objUniversidadBC.Loguin(TranslatorHelper.TranslateBetweenClienteDCToRegistroClienteBE(objClienteDC));

        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GET/LoguinAdmin?usuario={usuario}&contrasena={contrasena}")]
        AdministradorDC IBrunoSC.LoguinAdmin(String usuario, String contrasena)
        {

            AdministradorDC objAdminDC = new AdministradorDC();
            objAdminDC.Usuario1 = usuario;
            objAdminDC.Contrasena1 = contrasena;

            UniversidadBC objUniversidadBC;
            objUniversidadBC = new UniversidadBC();

            return TranslatorHelper.TranslateBetweenAdminBEToRegistroAdminDC(objUniversidadBC.LoguinAdmin(TranslatorHelper.TranslateBetweenAdminDCToRegistroAdminBE(objAdminDC)));

        }


      
    }

        
}
