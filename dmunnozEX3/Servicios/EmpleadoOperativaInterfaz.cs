using dmunnozEX3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnozEX3.Servicios
{
    /// <summary>
    /// Clase que contiene los metodos relacionados con el empleado.
    /// <author>dmp - 04/03/2024</author>
    /// </summary>
    internal interface EmpleadoOperativaInterfaz
    {
        /// <summary>
        /// Metodo que añade las ventas.
        /// <author>dmp - 04/03/2024</author>
        /// </summary>
        /// <param name="listaVentas"></param>
        public void aniadirVenta(List<VentasDto> listaVentas);

        /// <summary>
        /// Metodo que realiza el calculo total de las ventas.
        /// <author>dmp - 04/03/2024</author>
        /// </summary>
        /// <param name="listaVentas"></param>
        public void calculoTotalVentas(List<VentasDto> listaVentas);

    }
}
