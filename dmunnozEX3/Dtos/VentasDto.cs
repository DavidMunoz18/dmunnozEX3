using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnozEX3.Dtos
{
    /// <summary>
    /// Clase que contiene los atributos, getter y setter y constructores de las ventas.
    /// <author>dmp - 04/03/2024</author>
    /// </summary>
    internal class VentasDto
    {
        long id;
        string importeVenta = "aaaaa";
        DateTime fechaPrimeraVenta = DateTime.Today;
        DateTime fechaUltimaVenta;
        DateTime InstanteVenta = DateTime.Now;

        public long Id { get => id; set => id = value; }
        public string ImporteVenta { get => importeVenta; set => importeVenta = value; }
        public DateTime FechaPrimeraVenta { get => fechaPrimeraVenta; set => fechaPrimeraVenta = value; }
        public DateTime FechaUltimaVenta { get => fechaUltimaVenta; set => fechaUltimaVenta = value; }
        public DateTime InstanteVenta1 { get => InstanteVenta; set => InstanteVenta = value; }

        public VentasDto()
        {
        }

        public VentasDto(long id, string importeVenta, DateTime fechaPrimeraVenta, DateTime fechaUltimaVenta, DateTime instanteVenta)
        {
            this.id = id;
            this.importeVenta = importeVenta;
            this.fechaPrimeraVenta = fechaPrimeraVenta;
            this.fechaUltimaVenta = fechaUltimaVenta;
            InstanteVenta = instanteVenta;
        }
    }
}
