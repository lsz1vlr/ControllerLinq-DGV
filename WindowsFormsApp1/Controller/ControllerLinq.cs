using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Controller
{
    internal class ControllerLinq
    {
        public List<Cliente> clientes = new List<Cliente>() {
        new Cliente{Id=1, Nome="Jeff", Email="jeffemail.com" },
        new Cliente{Id=2, Nome="Arthur", Email="arthuremail.com" },
        new Cliente{Id=3, Nome="Ygor", Email="ygoremail.com" },
        new Cliente{Id=4, Nome="Leo", Email="leoemail.com" },
        new Cliente{Id=5, Nome="Lessa", Email="lessaemail.com" },
        };


        public List<Cliente> FiltroCliente(string filtro)
        {
            if (string.IsNullOrEmpty(filtro) || filtro.Length > 1){
                return null;
            }
            var filtrados = clientes.Where(c => c.Nome.StartsWith(filtro, StringComparison.OrdinalIgnoreCase)).ToList();
            return filtrados;
        }
    }


}
