using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalConsultas
{
    public class HistorialPaciente
    {
        public int IDInquiry { get; set; } //ID de la consulta
        public int NITPatient { get; set; } //NIT del paciente  
        public DateTime DateHourInquiry { get; set; } //fecha y hora de la consulta
        public int Temperature { get; set; } //temperatura
        public int Pressure { get; set; } //presión
        public List<Sintoma> Symptoms { get; set; } //síntomas
        public string Diagnosis { get; set; } //diagnóstico
        public string Treatment { get; set; } //tratamiento
        public List<Medicamento> Recipe { get; set; } //receta
        public string NextVisit { get; set; } //próxima visita
        public List<int> ConsultationCost { get; set; } //costo de la consulta
        public int Images { get; set; } //imágenes varias

    }
}