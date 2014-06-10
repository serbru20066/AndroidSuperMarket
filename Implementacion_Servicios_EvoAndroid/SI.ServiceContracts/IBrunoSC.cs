using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using SI.DataContract;
using BL.BE;
namespace SI.ServiceContracts
{
    [ServiceContract]
    public interface IBrunoSC
    {
       [OperationContract]
        BrunoDC obtenerBruno();
      
      [OperationContract]
      CelularCollectionDC obtenerCelulares();

      [OperationContract]
      CelularDC obtenerCelularPorImei(String Imei);

      [OperationContract]
      void agregarCelular(String Imei,String Marca,String Modelo, int NumCores);

      [OperationContract]
      BrunoCelularesDC obtenerBrunoCelulares();

     // [OperationContract]
     // UniversidadCollectionDC ObtenerUniversidades();

     // [OperationContract]
     // UniversidadDC ObtenerUniversidadPorCodigo(int codigo);

     // [OperationContract]
     // int RegistroUniversidad(String nombre, String siglas, String direccion, String distrito, String correo, int ranking);
       
    // [OperationContract]
     // int ActualizacionUniversidad(int codigo, String nombre, String siglas, String direccion, String distrito, String correo, int ranking);
      
       
    [OperationContract]
    int Loguin(String usuario, String contrasena);

    [OperationContract]
    AdministradorDC LoguinAdmin(String usuario, String contrasena);

    [OperationContract]
    ClienteCollectionDC ObtenerClientes();

    [OperationContract]
    SuperMercadoCollectionDC ObtenerSuperMercados();

    [OperationContract]
    ProductoCollectionDC ObtenerProductosFiltro1(String codSupermercado, String marca, String categoria, String oferta);

    [OperationContract]
    ProductoCollectionDC ObtenerProductosFiltro2(String nomSupermercado);

    [OperationContract]
    ProductoDC ObtenerProductosFiltro3(String codSupermercado,String codProducto);

    [OperationContract]
    int RegistroCompra(String codcompra,String codcliente, String fechacompra, String total);

    [OperationContract]
    int RegistroDetalleCompra(String codcomp, String codCli, String codpro, String codsuperm, int canti, String subtot);

    [OperationContract]
    int ActualizaCompra(String codcomp,String subtot);

    [OperationContract]
    DetallesCollectionDC ObtenerDetallesCompra(String codCompra, String codSupermer);

    [OperationContract]
    ProductoDC ActualizaPrecioProducto(String codproducto, String codsupermercado, String precio);



    }
}
