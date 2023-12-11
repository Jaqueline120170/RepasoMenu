using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoMenu.Servicios
{   
    /// <summary>
    /// Interfaz con la relacion de metodos y la funcionalidad del menu
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// interfaz que muestra el menu de opciones y recoge la seleccion del usuario
        /// </summary>
        /// <returns> un entero indicando la opcion seleccionada</returns>
        public int mostrarMenuYSeleccion();

        /// <summary>
        /// interfaz que solicita el dato identificador del usuario para poder localizarlo en la lista
        /// </summary>
        /// <returns> cadena de texto c0n el dni del usuario</returns>
        public string pedirDni();
    }
}
