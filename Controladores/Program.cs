using RepasoMenu.Dtos;
using RepasoMenu.Servicios;

namespace ReasoMenu.Controladores;

/// <summary>
/// clase principal de la aplicacion
/// </summary>
class Program
{
    /// <summary>
    /// metodo principal de entrada a  la aplicacion 
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        CuentaInterfaz cui=new CuentaImplementacion();
        ClienteInterfaz ci= new ClienteImplementacion();
        MenuInterfaz mi = new MenuImplementacion();
        List<ClienteDto> listaClientes= new List<ClienteDto>();
        List<CuentaDto>listaCuentas=new List<CuentaDto>();
        int seleccionUsuario;
        bool cerrarMenu= false;

        while (!cerrarMenu)
        {
            seleccionUsuario = mi.mostrarMenuYSeleccion();

            switch(seleccionUsuario)
            {
                case 0:
                    Console.WriteLine("Se ejecuta caso 0");
                    cerrarMenu= true;
                    break;
                case 1:
                    Console.WriteLine("Se ejecuta caso 1");
                   
                    break;
                case 2:
                    Console.WriteLine("Se ejecuta caso 2");
                    cui.crearCuenta(listaCuentas);
                    foreach(CuentaDto cuenta in listaCuentas)
                    {
                        Console.WriteLine(cuenta.ToString());
                    }
                    break;
                case 3:
                    Console.WriteLine("Se ejecuta caso 3");
                    break;
                case 4:
                    Console.WriteLine("Se ejecuta caso 4");
                    foreach(ClienteDto cliente in listaClientes)
                    {
                        Console.WriteLine(cliente.ToString());
                    }
                    break;
                case 5:
                    Console.WriteLine("Se ejecuta caso 5");
                    ci.borrarCliente(listaClientes);
                   
                    break;
                default:
                    Console.WriteLine("Introduzca una opcion valida");
                    break;

            }
        }
    }
}