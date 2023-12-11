using RepasoMenu.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoMenu.Servicios
{
    internal interface CuentaInterfaz
    {
        public void crearCuenta(List<CuentaDto> listaAntigua);

        
    }
}
