using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalConsultas
{
    public class Paciente : HistorialPaciente
    {
        public int NIT { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime Birth { get; set; }
        public int Phone { get; set; }

    }
}