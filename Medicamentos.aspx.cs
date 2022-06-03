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
    public partial class Medicamentos : System.Web.UI.Page
    {
        static List<Medicamento> medicamentos = new List<Medicamento>();
        static List<Enfermedad> enfermedades = new List<Enfermedad>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReadJsonMedicamentos();
            }
        }
        private void SaveJsonMedicamento()
        {
            string json = JsonConvert.SerializeObject(medicamentos);
            string archivo = Server.MapPath("zMedicamentos.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        private void ReadJsonMedicamentos()
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

        protected void ButtonAddIllness_Click(object sender, EventArgs e)
        {
            Enfermedad sick = new Enfermedad();
            sick.nombreEnfermedad = TextBoxListOfDiseases.Text;

            enfermedades.Add(sick);

        }

        protected void ButtonAddMedicine_Click(object sender, EventArgs e)
        {
            Medicamento medicina = new Medicamento();
            medicina.DrugCode = Convert.ToInt16(TextBoxDrugCode.Text);
            medicina.GenericIngredient = TextBoxGenericIngredient.Text;
            medicina.Laboratory = TextBoxLaboratory.Text;
            medicina.ListOfDiseases = enfermedades.ToArray().ToList();

            medicamentos.Add(medicina);
            SaveJsonMedicamento();
            //enfermedades.Clear();
        }
    }
}