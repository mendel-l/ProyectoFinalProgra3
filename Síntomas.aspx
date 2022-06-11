<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Síntomas.aspx.cs" Inherits="ProyectoFinalConsultas.Síntomas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Mantenimiento de Síntomas</h1>
    <h4>Ingrese codigo del sintoma:<br />
        <asp:TextBox ID="TextBoxGetSymptomCode" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>Ingrese una descripcion del sintoma:<br />
        <asp:TextBox ID="TextBoxAddDescriptionSymptom" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h3>
        <asp:Button ID="ButtonAddSymptom" runat="server" Text="Ingresar Sintoma" Width="275px" OnClick="ButtonAddSymptom_Click" />
    </h3>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <h1>
        Editar Sintoma</h1>
    <h4>
        Ingrese codigo del sintoma a buscar:<br />
        <asp:TextBox ID="TextBoxSearchSymptomCode" runat="server" Width="250px"></asp:TextBox>
        <asp:Button ID="ButtonSearch" runat="server" OnClick="ButtonSearch_Click" Text="Buscar Sintoma" Width="215px" />
    </h4>
    <h4>
        modifique la descripcion del sintoma:<br />
        <asp:TextBox ID="TextBoxModify" runat="server" Width="250px"></asp:TextBox>
        <asp:Button ID="ButtonModify" runat="server" OnClick="ButtonModify_Click" Text="Editar Descripcion" Width="215px" />
    </h4>
</asp:Content>
