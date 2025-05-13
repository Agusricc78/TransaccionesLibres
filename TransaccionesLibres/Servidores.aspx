<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Servidores.aspx.cs" Inherits="TransaccionesLibres.Servidores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
      <form method="post" action="Cliente"   id="form1" runat="server">
      <div>
          <h1>Frecuencia Libra</h1>
          <h2>Capital</h2>
          <asp:TextBox ID="txtcapita" Text="Text" runat="server"/>
          <h2>Tasa</h2>
          <asp:TextBox ID="txttasa" Text="Text" runat="server"/>
          <h2>Plazo</h2>
           <asp:TextBox ID="txtplazo" Text="Text" runat="server"/>
          <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />


      </div>
    </form>
</body>
</html>
