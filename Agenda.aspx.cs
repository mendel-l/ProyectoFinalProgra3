using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalConsultas
{
    public partial class Agenda1 : System.Web.UI.Page
    {
        static List<Agenda> consultas = new List<Agenda>();

        string Searchconsultas;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReadJsonAgenda();
            }
        }
        private void SaveJsonAgenda()
        {
            string json = JsonConvert.SerializeObject(consultas);
            string archivo = Server.MapPath("zAgenda.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        private void ReadJsonAgenda()
        {
            string archivo = Server.MapPath("zAgenda.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            consultas = JsonConvert.DeserializeObject<List<Agenda>>(json);

            if (consultas == null)
            {
                consultas = new List<Agenda>();
            }
        }
        protected void ButtonAddQuery_Click(object sender, EventArgs e)
        {
            Agenda consulta = new Agenda();
            consulta.NITPatient = TextBoxNIT.Text;
            consulta.Date = CalendarConsulta.SelectedDate;
            consulta.HourStart = TextBoxInicioConsulta.Text;
            consulta.HourFinish = TextBoxFinalConsulta.Text;

            consultas.Add(consulta);
            SaveJsonAgenda();
        }

        protected void ButtonSearchPatientNIT_Click(object sender, EventArgs e)
        {
            Searchconsultas = TextBoxSearchPatientNIT.Text;

            var found = consultas.FirstOrDefault(m => m.NITPatient == Searchconsultas);

            if (found == null)
            {
                Response.Write("<script>alert('no se encontró la consulta del paciente')</script>");
                Searchconsultas = "";
            }
            else
            {
                CalendarConsulta.SelectedDate = found.Date;
            }
        }

        protected void ButtonModifyDate_Click(object sender, EventArgs e)
        {

            Searchconsultas = TextBoxSearchPatientNIT.Text;

            foreach (var consulta in consultas)
            {
                if (consulta.NITPatient == Searchconsultas)
                {
                    consulta.Date = CalendarConsulta.SelectedDate;
                    SaveJsonAgenda();
                }
            }
        }
    }
}