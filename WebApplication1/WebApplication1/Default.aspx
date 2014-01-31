<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur många versaler?</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
    </div>
        <asp:Button ID="Button" runat="server" Text="Skicka" OnClick="Button_Click" />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server" Visible="false">
            <asp:Button ID="Clear" runat="server" Text="Rensa" OnClick="Clear_Click" />
            <asp:Label ID="Result" runat="server" Text=""></asp:Label>
        </asp:PlaceHolder>
    </form>
</body>
</html>
