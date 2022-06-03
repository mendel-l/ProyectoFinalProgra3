<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Medicamentos.aspx.cs" Inherits="ProyectoFinalConsultas.Medicamentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Mantenimiento de Medicamentos</h1>
    <h4>Ingrese codigo del medicamento:<br />
        <asp:TextBox ID="TextBoxDrugCode" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>Ingrese nombre del medicamento:<br />
        <asp:TextBox ID="TextBoxNameDrug" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>Ingrediente Generico:<br />
        <asp:TextBox ID="TextBoxGenericIngredient" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>Laboratorio:<br />
        <asp:TextBox ID="TextBoxLaboratory" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>enfermedades para las que puede ser recetado:<br />
        <asp:TextBox ID="TextBoxListOfDiseases" runat="server" Width="250px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="ButtonAddIllness" runat="server" OnClick="ButtonAddIllness_Click" Text="ingresar enfermedades" Width="215px" />
    </h4>
    <h3>
        <asp:Button ID="ButtonAddMedicine" runat="server" OnClick="ButtonAddMedicine_Click" Text="Ingresar Medicamento" Width="260px" />
    </h3>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <h1>Editar Medicamento</h1>
    <h4>Ingrese codigo del medicamento:<br />
        <asp:TextBox ID="TextBoxSearchDrugCode" runat="server" Width="250px"></asp:TextBox>
        <asp:Button ID="ButtonSearch" runat="server" OnClick="ButtonSearch_Click" Text="Buscar Medicamento" Width="215px" />
    </h4>
    <h4>Ingrese codigo del medicamento:<br />
        <asp:TextBox ID="TextBoxModify" runat="server" Width="250px"></asp:TextBox>
        <asp:Button ID="ButtonModify" runat="server" OnClick="ButtonModify_Click" Text="Modificar Medicamento" Width="215px" />
    </h4>
</asp:Content>
