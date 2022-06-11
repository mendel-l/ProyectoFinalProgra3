<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pacientes.aspx.cs" Inherits="ProyectoFinalConsultas.Pacientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Mantenimiento de pacientes</h1>
    <h4>Ingrese NIT del paciente:<br />
        <asp:TextBox ID="TextBoxNIT" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>Ingrese Nombre del paciente:<br />
        <asp:TextBox ID="TextBoxName" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>Ingrese Apellido del paciente:<br />
        <asp:TextBox ID="TextBoxLastName" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>Ingrese Dirección del paciente:<br />
        <asp:TextBox ID="TextBoxAddress" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h4>Ingrese Fecha de nacimiento del paciete:<asp:Calendar ID="CalendarBirth" runat="server"></asp:Calendar>
    </h4>
    <h4>&nbsp;</h4>
    <h4>
        <br /></h4>
    <h4>Ingrese Telefono del paciete:<br />
        <asp:TextBox ID="TextBoxPhone" runat="server" Width="250px"></asp:TextBox>
    </h4>
    <h3>
        <asp:Button ID="ButtonAddPatient" runat="server" Text="Ingresar Paciente" Width="275px" OnClick="ButtonAddPatient_Click" />
    </h3>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <h1>Editar Sintoma</h1>
    <h4>Ingrese NIT del paciente:<br />
        <asp:TextBox ID="TextBoxSearchPatientNIT" runat="server" Width="250px"></asp:TextBox>
        <asp:Button ID="ButtonSearchPatientNIT" runat="server" Text="Buscar Paciente" Width="215px" OnClick="ButtonSearchPatientNIT_Click" />
    </h4>
    <h4>modifique el nombre del paciente:<br />
        <asp:TextBox ID="TextBoxModify" runat="server" Width="250px"></asp:TextBox>
        <asp:Button ID="ButtonModifyPatientName" runat="server" Text="Modificar Paciente" Width="215px" OnClick="ButtonModifyPatientName_Click" />
    </h4>
</asp:Content>
