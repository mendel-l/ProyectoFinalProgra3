using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalConsultas
{
    public class Agenda : HistorialPaciente
    {
        //public int NITPatient { get; set; }
        public DateTime Date { get; set; }
        public DateTime HourStart { get; set; }
        public DateTime HourFinish { get; set; }
    }
}