<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Historial de pacientes.aspx.cs" Inherits="ProyectoFinalConsultas.Historial_de_pacientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Historial del Paciente</h1>
    <h4>ID de la consulta:<br />
        <asp:TextBox ID="TextBoxID" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>NIT del paciente:<br />
        <asp:DropDownList ID="DropDownNITs" runat="server" Width="250px">
        </asp:DropDownList>
    </h4>
    <h4>fecha y hora de la consulta:<asp:Calendar ID="CalendarDateInquiry" runat="server"></asp:Calendar>
        <br /></h4>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <h4>Temperatura:<br />
        <asp:TextBox ID="TextBoxTemperature" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>Presión:<br />
        <asp:TextBox ID="TextBoxPressure" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>Síntomas:<br />
        <asp:DropDownList ID="DropDownSymptoms" runat="server" Width="250px">
        </asp:DropDownList>
    </h4>
    <h4>Diagnóstico:<br />
        <asp:TextBox ID="TextBoxDiagnosis" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>Tratamiento:<br />
        <asp:TextBox ID="TextBoxTreatment" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>Receta:<br />
        <asp:DropDownList ID="DropDownRecipe" runat="server" Width="250px">
        </asp:DropDownList>
    </h4>
    <h4>Próxima visita:<br />
        <asp:TextBox ID="TextBoxNextVisit" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>Costo de la consulta:<br />
        <asp:TextBox ID="TextBoxConsultationCost" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>imágenes varias:<br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="151px">
            <Columns>
                <asp:TemplateField HeaderText="Imagenes">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("Imagenes") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Imagenes") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </h4>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <h4>
        <asp:Image ID="Image2" runat="server" DescriptionUrl="~/HistorialPaciente.cs" Height="150px" Width="150px" />
    </h4>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <h3>
        <asp:Button ID="ButtonAddData" runat="server" OnClick="ButtonAddData_Click" Text="Ingrasar Historial del Paciente" Width="350px" />
    </h3>
    <p>
        &nbsp;</p>
</asp:Content>
