using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnozEX3.Servicios
{
    /// <summary>
    /// Clase que implementa los metodos relacionados con el menu del menuInterfaz
    /// <author>dmp - 04/03/24</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuEmpleado()
        {
            int opcion;
            Console.WriteLine("######################################");
            Console.WriteLine("1. Cálculo total de ventas diario");
            Console.WriteLine("2. Añadir venta");
            Console.WriteLine("######################################");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        public int mostrarMenuGerencia()
        {
          
            int opcion;
            Console.WriteLine("######################################");
            Console.WriteLine("1. Escribir en un fichero todas las ventas del día");
            Console.WriteLine("2. Crear un nuevo pedido para proveedores");
            Console.WriteLine("######################################");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        public int mostrarMenuPrincipal()
        {

            int opcion;
            Console.WriteLine("####################################");
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Menu empleado");
            Console.WriteLine("2. Menu gerencia");
            Console.WriteLine("####################################");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
