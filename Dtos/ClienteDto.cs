using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoMenu.Dtos
{
    internal class ClienteDto
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

        public ClienteDto()
        {
        }

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public string FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public long Id { get => id; set => id = value; }

        public ClienteDto(string nombreCliente, string apellidoCliente, string fechaNac, string dniCliente, string emailCliente, string fechaAlta, string fechaBaja, int telefono, long id)
        {
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.fechaNac = fechaNac;
            this.dniCliente = dniCliente;
            this.emailCliente = emailCliente;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
            this.telefono = telefono;
            this.id = id;
        }

        public string ToString()
        {
           string clienteString= "Nombre: " + this.nombreCliente +
                "Apellido: " + this.apellidoCliente +
                "Fecha Nacimiento: " + this.fechaNac +
                "DNI Cliente: " + this.dniCliente +
                "Email Cliente: " + this.emailCliente +
                "Fecha Alta: " + this.fechaAlta +
                "Fecha Baja: " + this.fechaBaja +
                "Telefono: " + this.telefono +
                "ID cliente: " + this.id;
            return clienteString;
        }
    }
}
