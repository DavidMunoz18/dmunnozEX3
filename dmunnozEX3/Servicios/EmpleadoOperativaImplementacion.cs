using dmunnozEX3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace dmunnozEX3.Servicios
{
    /// <summary>
    /// Clase que implementa los metodos relacionados con el empleado.
    /// <author>dmp - 04/03/24</author>
    /// </summary>
    internal class EmpleadoOperativaImplementacion : EmpleadoOperativaInterfaz
    {
        public void aniadirVenta(List<VentasDto> listaVentas)
        {
            VentasDto ventas = darAltaVentas(listaVentas);
            
            listaVentas.Add(ventas);

        }
        private VentasDto darAltaVentas(List<VentasDto> listaVentas)
        {
            VentasDto ventas = new VentasDto();

            ventas.Id = idIterativo(listaVentas);
            Console.WriteLine("ID: " + ventas.Id);

            Console.WriteLine("Introduzca el importe de la venta");
            ventas.ImporteVenta = Console.ReadLine();
            string importe;
            importe = ventas.ImporteVenta;

            DateTime fechaHoy = DateTime.Today;
            fechaHoy = ventas.FechaPrimeraVenta;
            Console.WriteLine("fechaPrimeraVenta: " + ventas.FechaPrimeraVenta);

            DateTime fechaInstante = DateTime.Now;
            fechaInstante = ventas.InstanteVenta1;
            Console.WriteLine("Fecha instante de la venta: " + ventas.InstanteVenta1);

            

            return ventas;
        }

        public void calculoTotalVentas(List<VentasDto> listaVentas)
        {
            foreach(VentasDto ventas in listaVentas)
            {
                Console.WriteLine("Introduzca una fecha en formato dd-MM-yyyy");
                DateTime fechaCliente = Convert.ToDateTime(Console.ReadLine());

                if (ventas.FechaPrimeraVenta.Equals(fechaCliente))
                {
                    
                    Console.WriteLine("Importe ventas separado: " + ventas.ImporteVenta);
                    TimeSpan duracion =ventas.InstanteVenta1 - ventas.FechaPrimeraVenta ;
                    Console.WriteLine("Tiempo transcurrido: " + duracion);


                }
            }
        }

        private long idIterativo(List<VentasDto> listaVentas)
        {
            long id;
            int tamanioLista = listaVentas.Count;

            if(tamanioLista == 0)
            {
                id = 1;
            }
            else
            {
                id = listaVentas[tamanioLista - 1].Id + 1;
            }
            return id;
        }
    }
}
