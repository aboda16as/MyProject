<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="page1.page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Abd Alrhman</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
       <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Text1"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                 &nbsp;
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Text2"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
      </tr>
      <tr>
            <td>
               <asp:Label ID="Label3" runat="server" Text="click Of Transfer"></asp:Label>    
            </td>
            <td>
               <asp:Button ID="Button1" runat="server" Text="Transfer" OnClick="Button1_Click" />
            </td>
      </tr>
    </table></div></form>
</body>
</html>
