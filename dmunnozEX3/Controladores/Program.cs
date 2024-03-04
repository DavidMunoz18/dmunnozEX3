using dmunnozEX3.Dtos;
using dmunnozEX3.Servicios;

namespace dmunnozEX3.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// <author>dmp - 04/03/24</author>
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo de entrada y salida de la aplicación
        /// <author>dmp - 04/03/24</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            List<PedidosDto> listaPedidos = new List<PedidosDto>();
            List<VentasDto> listaVentas = new List<VentasDto>();
            MenuInterfaz mi = new MenuImplementacion();
            EmpleadoOperativaInterfaz oi = new EmpleadoOperativaImplementacion();
            GerenciaOperativaInterfaz gi = new GerenciaOperativaImplementacion();

            bool cerrarMenu = false;

            int opcionMenu;

            while(!cerrarMenu)
            {
                opcionMenu = mi.mostrarMenuPrincipal();

                switch (opcionMenu)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        int opcionEmpleado = mi.mostrarMenuEmpleado();
                        switch (opcionEmpleado)
                        {
                            case 1:
                                oi.calculoTotalVentas(listaVentas);
                                break;
                            case 2:
                                oi.aniadirVenta(listaVentas);
                                break;
                        }
                        break;
                    case 2:
                        int opcionGerencia = mi.mostrarMenuGerencia();
                        switch (opcionGerencia)
                        {
                            case 1:
                                gi.mostrarVentasDia(listaVentas);
                                break;
                            case 2:
                                gi.crearPedidoProveedores(listaPedidos);
                                break;
                        }
                        break;

                }
            }
        }
    }
}