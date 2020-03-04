<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Fibs.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
        
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="輸入"></asp:Label>&nbsp;&nbsp;
        
        <asp:TextBox ID="TextBox1" runat="server" Text="" ></asp:TextBox>
                <p>
        <asp:Button ID="Button1" runat="server" Text="費式數列" OnClick="Button1_Click" />
                <p>
        <asp:Label ID="Label2" runat="server" Text="輸出"></asp:Label>
    </form>
        
</body>
</html>
