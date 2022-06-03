using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalConsultas
{
    public class Medicamento
    {
        public int DrugCode { get; set; } //Código del medicamento
        public string GenericIngredient { get; set; } //Ingrediente genérico
        public string Laboratory { get; set; } //Laboratorio (Marca comercial)
        public List<string> ListOfDiseases { get; set; } //Listado de enfermedades para las que puede ser recetado
    }
}