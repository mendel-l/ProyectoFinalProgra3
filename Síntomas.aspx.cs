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
    public partial class Síntomas : System.Web.UI.Page
    {
        static List<Sintoma> sintomas = new List<Sintoma>();

        string SearchSymptom;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReadJsonSintoma();
            }
        }
        private void SaveJsonSintoma()
        {
            string json = JsonConvert.SerializeObject(sintomas);
            string archivo = Server.MapPath("zSintomas.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        private void ReadJsonSintoma()
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
        protected void ButtonAddSymptom_Click(object sender, EventArgs e)
        {
            Sintoma symptom = new Sintoma();
            symptom.SymptomCode = TextBoxGetSymptomCode.Text;
            symptom.SymptomDescription = TextBoxAddDescriptionSymptom.Text;

            sintomas.Add(symptom);
            SaveJsonSintoma();
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchSymptom = TextBoxSearchSymptomCode.Text;

            var found = sintomas.FirstOrDefault(m => m.SymptomCode == SearchSymptom);

            if (found == null)
            {
                Response.Write("<script>alert('no se encontró el Sintoma')</script>");
                SearchSymptom = "";
                TextBoxModify.Text = "";
            }
            else
            {
                TextBoxModify.Text = found.SymptomDescription;
            }
        }
        protected void ButtonModify_Click(object sender, EventArgs e)
        {
            SearchSymptom = TextBoxSearchSymptomCode.Text;

            foreach (var sin in sintomas)
            {
                if (sin.SymptomCode == SearchSymptom)
                {
                    sin.SymptomDescription = TextBoxModify.Text;
                    SaveJsonSintoma();
                }
            }
        }
    }
}