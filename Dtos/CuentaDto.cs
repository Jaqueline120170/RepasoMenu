using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoMenu.Dtos
{
    internal class CuentaDto
    {
        string numISBAN;
        string dniCliente;
        string fechaAlta;
        string fechaBaja = "9999/12/31";
        string idBanco = "sssss";
        long idCliente;

        public CuentaDto()
        {
        }

        public string NumISBAN { get => numISBAN; set => numISBAN = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public string FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public string IdBanco { get => idBanco; set => idBanco = value; }
        public long IdCliente { get => idCliente; set => idCliente = value; }

        public CuentaDto(string numISBAN, string dniCliente, string fechaAlta, string fechaBaja, string idBanco, long idCliente)
        {
            this.numISBAN = numISBAN;
            this.dniCliente = dniCliente;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
            this.idBanco = idBanco;
            this.idCliente = idCliente;
        }
        public string ToString()
        {
            string clienteString = "Numero ISBAN: " + this.numISBAN +
                "DNI cliente: " + this.dniCliente +
                "Fecha Alta: " + this.fechaAlta +
                "Fecha Baja: " + this.fechaBaja +
                "Id Banco: " + this.idBanco +
                "ID Cliente: " + this.idCliente;
            return clienteString;

        }
    }
}
