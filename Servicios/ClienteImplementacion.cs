using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepasoMenu.Dtos;


namespace RepasoMenu.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz

    {
        MenuInterfaz mei= new MenuImplementacion();
        public void modificarCliente(List<ClienteDto> listaAntigua)
        {
            string buscarDni = mei.pedirDni();
            foreach(ClienteDto cliente in  listaAntigua)
            {
                if (cliente.DniCliente.Equals(buscarDni))
                {
                    int opcionCampo = mostrarCampos();
                    bool control = true;
                    while (control)
                    {
                        control = campoModificar(cliente, opcionCampo);
                    }
                }
                
            }
        }

       public void borrarCliente(List<ClienteDto> listaAntigua)
        {
            string buscarDni = mei.pedirDni();
            ClienteDto clienteaBorrar= new ClienteDto();
            foreach(ClienteDto cliente in listaAntigua)
            {
                if (clienteaBorrar.DniCliente.Equals(buscarDni))
                {
                    clienteaBorrar = cliente;
                    break;
                }
            }
            listaAntigua.Remove(clienteaBorrar);
        }
      public void darAlta(List<ClienteDto> listaAntigua)
        {
            listaAntigua.Add(crearCliente());
        }

        private ClienteDto crearCliente()
        {
            string nombreCliente;
            string apellidoCliente;
            string fechaNac;
            string dniCliente;
            string emailCliente;
            string fechaAlta;
            string fechaBaja = "9999/12/31";
            int telefono;
            long id;

            Console.WriteLine("Introduzca Nombre");
            nombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca apellido");
            apellidoCliente = Console.ReadLine();
            Console.WriteLine("Introduzca fecha de Nacimiento");
            fechaNac = Console.ReadLine();
            Console.WriteLine("Introduzca dni");
            dniCliente = Console.ReadLine();
            Console.WriteLine("Introduzca email");
            emailCliente = Console.ReadLine();
            Console.WriteLine("Introduzca fecha actual");
            fechaAlta = Console.ReadLine();
            Console.WriteLine("Fecha baja: " + fechaBaja);
            Console.WriteLine("Introduzca telefono");
            telefono=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca id");
            id=Convert.ToInt64(Console.ReadLine());
            ClienteDto cliente = new ClienteDto(nombreCliente, apellidoCliente, fechaNac, dniCliente, emailCliente, fechaAlta,fechaBaja,telefono, id);
            return cliente;


        }
        private int mostrarCampos()
        {
            int opcionCampo;
            Console.WriteLine("Introduzca la opcion del campo que desee modificar");
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. Apellido");
            Console.WriteLine("3. Fecha de Nacimiento");
            Console.WriteLine("4. DNI");
            Console.WriteLine("5.Email");
            Console.WriteLine("6.telefono");
            opcionCampo = Convert.ToInt32(Console.ReadLine());
            return opcionCampo;

        }
        private bool campoModificar(ClienteDto clienteaModificar, int opcionCampo)
        {
            bool abrirMenu = true;
            switch(opcionCampo)
            {
                case 0:
                    abrirMenu=false;
                    break;
                case 1:
                    Console.WriteLine("Introduzca nuevo nombre");
                    clienteaModificar.NombreCliente = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Introduzca nuevo apellido");
                    break;

            }
            return abrirMenu;
        }
    }
}
