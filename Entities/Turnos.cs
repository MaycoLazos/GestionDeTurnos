using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Turnos
    {
        public int Id { get; set; }
        public string Horario { get; set; }
        public bool Disponible { get; set; }
        public int IdCliente { get; set; }

    }
}
