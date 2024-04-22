<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ViewState_and_Events.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table">
                <tr>
                    <th colspan="2">Employee Details</th>
                </tr>
                <tr>
                    <td>First Name</td>
                    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name</td>
                    <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                </tr>
                <tr colspan="2">
                    <td>City</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" ></asp:DropDownList></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td><asp:Button ID="Button1" runat="server" Text="Button" /></td>
                </tr>
            </table>


        </div>
    </form>
</body>
</html>
