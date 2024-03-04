using dmunnozEX3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnozEX3.Servicios
{
    /// <summary>
    /// Clase que implementa los metodos relacionados con la gerencia.
    /// <author>dmp - 04/03/2024</author>
    /// </summary>
    internal class GerenciaOperativaImplementacion : GerenciaOperativaInterfaz
    {
        public void crearPedidoProveedores(List<PedidosDto> listaPedidos)
        {
            PedidosDto pedidos = darAltaPedidos(listaPedidos);
            listaPedidos.Add(pedidos);
        }
        private PedidosDto darAltaPedidos(List<PedidosDto> listaPedidos)
        {
            Console.WriteLine("¿Desea introducir otro producto? (s/n)");
            string s = "s";
            PedidosDto pedidos = new PedidosDto();
            if (s.Equals(Console.ReadLine()))
            {
            

            Console.WriteLine("Introduzca el nombre del producto");
            pedidos.NombreProducto = Console.ReadLine();

            Console.WriteLine("Introduzca la cantidad deseada");
            pedidos.CantidadProducto = Console.ReadLine();

            Console.WriteLine("Introduzca la fecha deseada de entrega");
            pedidos.FechaDeseada = Convert.ToDateTime(Console.ReadLine());
                DateTime fecha;
                fecha = pedidos.FechaDeseada;

                foreach (PedidosDto pedidos2 in listaPedidos)
                {
                    Console.WriteLine("PRODUCTO: " + pedidos2.NombreProducto);
                    Console.WriteLine("CANTIDAD: " + pedidos2.CantidadProducto);
                    Console.WriteLine("FECHA ENTREGA: " + pedidos2.FechaDeseada);
                }
            }
            else
            {
                foreach(PedidosDto pedidos2 in listaPedidos)
                {
                    Console.WriteLine("PRODUCTO: " + pedidos2.NombreProducto);
                    Console.WriteLine("CANTIDAD: " + pedidos2.CantidadProducto);
                    Console.WriteLine("FECHA ENTREGA: " + pedidos2.FechaDeseada);
                }
            }
            return pedidos;
        }

        public void mostrarVentasDia(List<VentasDto> listaVentas)
        {
           foreach(VentasDto ventas in listaVentas)
            {
                Console.WriteLine("Introduzca una fecha");
                DateTime fecha = Convert.ToDateTime(Console.ReadLine());

                
                string ruta = "ddMMyyyy.txt";
                if (fecha.Equals(ventas.FechaPrimeraVenta))
                {
                    using (StreamWriter sw = new StreamWriter(ruta))
                    {
                        sw.WriteLine("------------------------------------------------------");
                        sw.WriteLine("VENTA NUMERO: " + ventas.Id);
                        sw.WriteLine("Euros: " + ventas.ImporteVenta);
                        sw.WriteLine("Instante ventas " + ventas.InstanteVenta1);
                        sw.WriteLine("------------------------------------------------------");
                    }
                }
            }
        }

        private long idIterativo(List<VentasDto> listaVentas)
        {
            long id;
            int tamanioLista = listaVentas.Count;

            if (tamanioLista == 0)
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
