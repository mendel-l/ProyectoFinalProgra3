<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Síntomas.aspx.cs" Inherits="ProyectoFinalConsultas.Síntomas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Mantenimiento de Síntomas</h1>
    <h4>Ingrese codigo del sintoma:<br />
        <asp:TextBox ID="TextBox2" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>Ingrese una descripcion del sintoma:<br />
        <asp:TextBox ID="TextBox3" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h3>
        <asp:Button ID="ButtonAddSymptom" runat="server" Text="Ingresar Sintoma" Width="275px" />
    </h3>
</asp:Content>
