using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnozEX3.Servicios
{
    /// <summary>
    /// Clase que contiene los metodos relacionados con el menú.
    /// <author>dmp - 04/03/2024</author>
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menú principal.
        /// <author> dmp - 04/03/24</author>
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuPrincipal();

        /// <summary>
        /// Metodo que muestra dentro del menu principal el menú empleado.
        /// <author>dmp - 04/03/24</author>
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuEmpleado();

        /// <summary>
        /// Metodo que muestra dentro del menu principal el menú gerencia.
        /// <author>dmp - 04/03/2024</author>
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuGerencia();
    }
}
