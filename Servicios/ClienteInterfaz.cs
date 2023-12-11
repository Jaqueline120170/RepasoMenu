using RepasoMenu.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoMenu.Servicios
{
    internal interface ClienteInterfaz
    {
        public void borrarCliente(List<ClienteDto> listaAntgua);
        public void darAlta(List<ClienteDto> listaAntigua);
    }
}
