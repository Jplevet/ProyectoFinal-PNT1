using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_PNT1
{
    class Ticket
    {
        public int id { get; set; }
        public String nombreCliente { get; set; }

        public String dniCliente { get; set; }

        public List<Recital> recitales { get; set; }
    }
}
