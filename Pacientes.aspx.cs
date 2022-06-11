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
    public partial class Pacientes : System.Web.UI.Page
    {
        static List<Paciente> pacientes = new List<Paciente>();

        string SearchPaciente;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReadJsonPaciente();
            }
        }
        private void SaveJsonPaciente()
        {
            string json = JsonConvert.SerializeObject(pacientes);
            string archivo = Server.MapPath("zPacientes.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        private void ReadJsonPaciente()
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
        protected void ButtonAddPatient_Click(object sender, EventArgs e)
        {
            Paciente persona = new Paciente();
            persona.NITPatient = TextBoxNIT.Text;
            persona.Name = TextBoxName.Text;
            persona.LastName = TextBoxLastName.Text;
            persona.Address = TextBoxAddress.Text;
            persona.Birth = CalendarBirth.SelectedDate;
            persona.Phone = TextBoxPhone.Text;

            pacientes.Add(persona);
            SaveJsonPaciente();
        }

        protected void ButtonSearchPatientNIT_Click(object sender, EventArgs e)
        {
            SearchPaciente = TextBoxSearchPatientNIT.Text;

            var found = pacientes.FirstOrDefault(m => m.NITPatient == SearchPaciente);

            if (found == null)
            {
                Response.Write("<script>alert('no se encontró al paciente')</script>");
                SearchPaciente = "";
                TextBoxModify.Text = "";
            }
            else
            {
                TextBoxModify.Text = found.Name;
            }
        }

        protected void ButtonModifyPatientName_Click(object sender, EventArgs e)
        {
            SearchPaciente = TextBoxSearchPatientNIT.Text;

            foreach (var persona in pacientes)
            {
                if (persona.NITPatient == SearchPaciente)
                {
                    persona.Name = TextBoxModify.Text;
                    SaveJsonPaciente();
                }
            }
        }
    }
}