using RepasoMenu.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoMenu.Servicios
{
    internal class CuentaImplementacion: CuentaInterfaz
    {
        public void crearCuenta(List<CuentaDto> listaAntiguaC)
        {
            listaAntiguaC.Add(nuevaCuenta());
        }
        private CuentaDto nuevaCuenta()
        {
            string numISBAN;
            string dniCliente;
            string fechaAlta;
            string fechaBaja = "9999/12/31";
            string idBanco = "sssss";
            long idCliente;

            Console.WriteLine("Introduzca ISBAN: ");
            numISBAN = Console.ReadLine();
            Console.WriteLine("Introduzca DNI");
            dniCliente = Console.ReadLine();
            Console.WriteLine("Introduzca fecha actual: ");
            fechaAlta = Console.ReadLine();
            Console.WriteLine("fecha baja: " + fechaBaja);
            Console.WriteLine("iNTRODUZCA ID");
            idCliente = Convert.ToInt64(Console.ReadLine());
            CuentaDto cuenta= new CuentaDto(numISBAN, dniCliente, fechaAlta, fechaBaja, idBanco, idCliente);
            return cuenta; 

        }
    }
}
