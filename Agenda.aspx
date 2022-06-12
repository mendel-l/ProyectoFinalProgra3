<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Agenda.aspx.cs" Inherits="ProyectoFinalConsultas.Agenda1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Agendar Citas</h1>
    <h4>Ingrese NIT del paciente:<br />
        <asp:TextBox ID="TextBoxNIT" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>Ingrese Fecha de la Consulta:<br />
        <asp:Calendar ID="CalendarConsulta" runat="server"></asp:Calendar>
    </h4>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
    <h4>ingrese hora de inicio de la consulta:<br />
        <asp:TextBox ID="TextBoxInicioConsulta" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>ingrese hora de fin de la consulta:<br />
        <asp:TextBox ID="TextBoxFinalConsulta" runat="server" Width="250px"></asp:TextBox>
    </h4>
<h3>
    <asp:Button ID="ButtonAddQuery" runat="server" Text="Agregar Consulta" Width="275px" OnClick="ButtonAddQuery_Click" />
    </h3>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <h1>Editar Sintoma</h1>
    <h4>Ingrese NIT del paciente:<br />
        <asp:TextBox ID="TextBoxSearchPatientNIT" runat="server" Width="250px"></asp:TextBox>
        <asp:Button ID="ButtonSearchPatientNIT" runat="server" Text="Buscar Consulta Paciente" Width="215px" OnClick="ButtonSearchPatientNIT_Click" />
    </h4>
    <h4>modifique la fecha de la consulta:<br />
        <asp:Calendar ID="CalendarModify" runat="server"></asp:Calendar>
    </h4>
    <h4>&nbsp;</h4>
    <h4>&nbsp;</h4>
    <h4>
        <asp:Button ID="ButtonModifyDate" runat="server" Text="Modificar Fecha" Width="215px" OnClick="ButtonModifyDate_Click" />
    </h4>
    <p>
        &nbsp;</p>
</asp:Content>
