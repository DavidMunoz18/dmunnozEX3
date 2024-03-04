using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnozEX3.Dtos
{
    /// <summary>
    /// Clase que contiene los atributos, getter y setter y constructores de los pedidos.
    /// <author>dmp - 04/03/2024</author>
    /// </summary>
    internal class PedidosDto
    {
        long id;
        string nombreProducto = "aaaaa";
        string importeProducto = "aaaaa";
        DateTime instanteProducto = DateTime.Now;
        string cantidadProducto = "aaaaa";
        DateTime fechaDeseada;

        public long Id { get => id; set => id = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string ImporteProducto { get => importeProducto; set => importeProducto = value; }
        public DateTime InstanteProducto { get => instanteProducto; set => instanteProducto = value; }
        public string CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public DateTime FechaDeseada { get => fechaDeseada; set => fechaDeseada = value;}

        public PedidosDto()
        {
        }

        public PedidosDto(long id, string nombreProducto, string importeProducto, DateTime instanteProducto, string cantidadProducto, DateTime fechaDeseada)
        {
            this.id = id;
            this.nombreProducto = nombreProducto;
            this.importeProducto = importeProducto;
            this.instanteProducto = instanteProducto;
            this.cantidadProducto = cantidadProducto;
            this.fechaDeseada = fechaDeseada;
        }
    }
}
