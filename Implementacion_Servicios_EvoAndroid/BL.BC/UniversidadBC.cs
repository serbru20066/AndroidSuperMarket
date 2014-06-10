using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BL.BE;
using DL.DataModel;
using DL.Dalc;

namespace BL.BC
{
    public class UniversidadBC
    {
        public List<ClienteBE> ObtenerClientes()
        {
            try
            {
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();
                return objServiciosDALC.ObtenerClientes();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<SupermercadoBE> ObtenerSuperMercados()
        {
            try
            {
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();
                return objServiciosDALC.ObtenerSupermercados();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int Loguin(ClienteBE objClienteBE)
        {
            try
            {
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();

                return objServiciosDALC.Loguin(objClienteBE);
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
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();

                return objServiciosDALC.LoguinAdmin(objAdminBE);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<ProductoBE> ObtenerProductosFiltro1(String codSupermercado, String marca, String categoria, String oferta)
        {

            try
            {
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();

                return objServiciosDALC.ObtenerProductosFiltro1(codSupermercado, marca, categoria, oferta);  
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
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();

                return objServiciosDALC.ObtenerProductosFiltro2(nomSupermercado);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ProductoBE ObtenerProductosFiltro3(String codSupermercado,String codProducto)
        {

            try
            {
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();

                return objServiciosDALC.ObtenerProductosFiltro3(codSupermercado,codProducto);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Compra_Producto_SuperMercadoBE> ObtenerDetallesCompra(String codCompra, String codSupermer)
        {

            try
            {
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();

                return objServiciosDALC.ObtenerDetallesCompra(codCompra,codSupermer );  
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
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();

                return objServiciosDALC.RegistroCompra(objCompraBE);
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
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();

                return objServiciosDALC.RegistroDetalleCompra(objDetalleBE);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int ActualizaCompra(String codCompra, String subtotal)
        {
            try
            {
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();

                return objServiciosDALC.ActualizaCompra(codCompra, subtotal);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public ProductoBE ActualizaPrecioProducto(String codproducto, String codsupermercado, String precio)
        {
            try
            {
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();

                return objServiciosDALC.ActualizaPrecioProducto(codproducto, codsupermercado, precio);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
     

        /*public List<UniversidadBE> ObtenerUniversidades()
        {
            try
            {
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();
                return objServiciosDALC.ObtenerUniversidades();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public UniversidadBE ObtenerUniversidadPorCodigo(int codigo)
        {
            try
            {
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();
                return objServiciosDALC.ObtenerUniversidadPorCodigo(codigo);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int RegistroUniversidad(UniversidadBE objUniversidadBE)
        {
            try
            {
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();

                return objServiciosDALC.RegistroUniversidad(objUniversidadBE);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int ActualizacionUniversidad(int codigo,UniversidadBE objUniversidadBE)
        {
            try
            {
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();

                return objServiciosDALC.ActualizacionUniversidad(codigo,objUniversidadBE);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int Loguin(UsuarioBE objUsuarioBE)
        {
            try
            {
                ServiciosDALC objServiciosDALC;
                objServiciosDALC = new ServiciosDALC();

                return objServiciosDALC.Loguin(objUsuarioBE);
            }
            catch (Exception ex)
            {
                throw;
            }
        }*/

    }
}
