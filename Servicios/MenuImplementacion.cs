using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoMenu.Servicios
{
    
    internal class MenuImplementacion : MenuInterfaz
    {

        /// <summary>
        /// Clase que implementa la interfaz del menu
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion()
        {
            int opcionSeleccionada;
            Console.WriteLine("#################################################");
            Console.WriteLine("Introduzca la opcion que desee ejecutar");
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Dar alta");
            Console.WriteLine("2. Crear cuenta");
            Console.WriteLine("3. Modificar datos");
            Console.WriteLine("4. Ver lista Clientes (prueba)");
            Console.WriteLine("5. Eliminar Cliente");
            Console.WriteLine("#################################################");
            opcionSeleccionada = Console.ReadKey(true).KeyChar - ('0');
            return opcionSeleccionada;
        }
        public string pedirDni()
        {
            string dniC;
            Console.WriteLine("Introduzca su dni");
            dniC = Console.ReadLine();
            return dniC;

        }
    }
}
