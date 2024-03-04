using dmunnozEX3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnozEX3.Servicios
{
    /// <summary>
    /// Clase que contiene los metodos relacionados con la gerencia.
    /// <author>dmp - 04/03/2024</author>
    /// </summary>
    internal interface GerenciaOperativaInterfaz
    {
        /// <summary>
        /// Metodo que crea el pedido a los proveedores
        /// </summary>
        /// <param name="listaPedidos"></param>
        public void crearPedidoProveedores(List<PedidosDto> listaPedidos);

        /// <summary>
        /// Metodo que muestra las ventas del día.
        /// <author>dmp - 04/03/2024</author>
        /// </summary>
        /// <param name="listaVentas"></param>
        public void mostrarVentasDia(List<VentasDto> listaVentas);
    }
}
