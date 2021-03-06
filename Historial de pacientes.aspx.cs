using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinalConsultas
{
    public partial class Historial_de_pacientes : System.Web.UI.Page
    {
        static List<Paciente> pacientes = new List<Paciente>();
        //static List<Agenda> consultas = new List<Agenda>();
        static List<Medicamento> medicamentos = new List<Medicamento>();
        static List<Sintoma> sintomas = new List<Sintoma>();
        static List<HistorialPaciente> Hpacientes = new List<HistorialPaciente>();

        protected void Page_Load(object sender, EventArgs e)
        {
            var identidad = (FormsIdentity)Context.User.Identity;
            if (identidad.Ticket.UserData != "1")
            {
                Response.Redirect("Contact", true);
            }

            if (!IsPostBack)
            {
                ReadJsonHistorialPacientes();

            }
            NITPatient();
            Symptoms();
            Drug();
        }
        private void SaveJsonHistorialPacientes()
        {
            string json = JsonConvert.SerializeObject(Hpacientes);
            string archivo = Server.MapPath("zHistorialpaciente.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        private void ReadJsonHistorialPacientes()
        {
            string archivo = Server.MapPath("zHistorialpaciente.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            Hpacientes = JsonConvert.DeserializeObject<List<HistorialPaciente>>(json);

            if (Hpacientes == null)
            {
                Hpacientes = new List<HistorialPaciente>();
            }
        }

        void NITPatient()
        {
            string archivo = Server.MapPath("zPacientes.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(json);

            if (pacientes == null)
            {
                pacientes = new List<Paciente>();
            }
        }
        void Symptoms()
        {
            string archivo = Server.MapPath("zSintomas.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            sintomas = JsonConvert.DeserializeObject<List<Sintoma>>(json);

            if (sintomas == null)
            {
                sintomas = new List<Sintoma>();
            }
        }
        void Drug()
        {
            string archivo = Server.MapPath("zMedicamentos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            medicamentos = JsonConvert.DeserializeObject<List<Medicamento>>(json);

            if (medicamentos == null)
            {
                medicamentos = new List<Medicamento>();
            }
        }
        protected void ButtonAddData_Click(object sender, EventArgs e)
        {
            HistorialPaciente historial = new HistorialPaciente();
            historial.IDInquiry = Convert.ToInt16(TextBoxID.Text);
            historial.NITPatient = DropDownNITs.Text;
            historial.DateHourInquiry = CalendarDateInquiry.SelectedDate;
            historial.Temperature = Convert.ToInt16(TextBoxTemperature.Text);
            historial.Pressure = Convert.ToInt16(TextBoxPressure.Text);
            historial.Symptoms = null; //DropDownSymptoms.ToString().ToList();
            historial.Diagnosis = TextBoxDiagnosis.Text;
            historial.Treatment = TextBoxTreatment.Text;
            historial.Recipe = null; // DropDownRecipe.ToString.ToList();
            historial.NextVisit = TextBoxNextVisit.Text;
            historial.ConsultationCost = TextBoxConsultationCost.Text;
            historial.Images = null;


            Hpacientes.Add(historial);
            SaveJsonHistorialPacientes();
        }
    }
}