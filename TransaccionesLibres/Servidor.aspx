<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Servidor.aspx.cs" Inherits="TransaccionesLibres.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <h1>Frecuencia Libra</h1>
            <h2>Capital</h2>
            <asp:TextBox ID="txtcapita" Text="" runat="server"/>
            <h2>Tasa</h2>
            <asp:TextBox ID="txttasa" Text="" runat="server"/>
            <h2>Plazo</h2>
             <asp:TextBox ID="txtplazo" Text="" runat="server"/>
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />


        </div>
    </form>
</body>
</html>
