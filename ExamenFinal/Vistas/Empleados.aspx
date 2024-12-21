<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="ExamenFinal.Empleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Empleados</h2>
            <br />
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
            <br />

            Codigo:
            <asp:TextBox ID="Tcodigo" type="number" runat="server"></asp:TextBox>
            <br />
            Numero de Carnet:
            <asp:TextBox ID="TNumeroCarnet" runat="server"></asp:TextBox>
             Nombre:
            <asp:TextBox ID="TNombre" runat="server"></asp:TextBox>
             Fecha de Nacimiento:
            <asp:TextBox ID="TFechaNacimiento" runat="server"></asp:TextBox>
             Categoria:
<asp:TextBox ID="TCategoria" runat="server"></asp:TextBox>
            <br />
             Salario:
<asp:TextBox ID="TSalario" runat="server"></asp:TextBox>
            <br />
             Direccion:
<asp:TextBox ID="TDireccion" runat="server"></asp:TextBox>
            <br />
             Telefono:
<asp:TextBox ID="TTelefono" runat="server"></asp:TextBox>
             Correo:
<asp:TextBox ID="TCorreo" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />

            <asp:Button ID="Bagregar" runat="server" Text="Agregar" OnClick="Bagregar_Click" />
            <asp:Button ID="Beliminar" runat="server" Text="Eliminar" OnClick="Beliminar_Click" />
            


        </div>
    </form>
</body>
</html>
