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

        string SearchDrug;
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
            medicina.DrugCode = TextBoxDrugCode.Text;
            medicina.NameDrug = TextBoxNameDrug.Text;
            medicina.GenericIngredient = TextBoxGenericIngredient.Text;
            medicina.Laboratory = TextBoxLaboratory.Text;
            medicina.ListOfDiseases = enfermedades.ToArray().ToList();

            medicamentos.Add(medicina);
            SaveJsonMedicamento();
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchDrug = TextBoxSearchDrugCode.Text;           

            var found = medicamentos.FirstOrDefault(m => m.DrugCode == SearchDrug);

            if (found == null)
            {
                Response.Write("<script>alert('no se encontró el Medicamento')</script>");
                SearchDrug = "";
                TextBoxModify.Text = "";

            }
            else
            {
                TextBoxModify.Text = found.NameDrug;
            }

        }

        protected void ButtonModify_Click(object sender, EventArgs e)
        {

            SearchDrug = TextBoxSearchDrugCode.Text;

            foreach (var drug in medicamentos)
            {
                if (drug.DrugCode == SearchDrug)
                {
                    drug.NameDrug = TextBoxModify.Text;
                    SaveJsonMedicamento();
                }
            }
        }
    }
}