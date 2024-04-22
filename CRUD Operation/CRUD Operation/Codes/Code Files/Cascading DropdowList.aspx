 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cascading DropdowList.aspx.cs" Inherits="CRUD_Operation.Codes.Code_Files.Cascading_DropdowList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <asp:DropDownList ID="DropDownList3" runat="server" ></asp:DropDownList>
            <br />
            <br />

            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Value="A">A</asp:ListItem>
                <asp:ListItem Value="B">B</asp:ListItem>
                <asp:ListItem Value="C">C</asp:ListItem>
                <asp:ListItem Value="D">D</asp:ListItem>
            </asp:CheckBoxList>

            <asp:ListBox ID="ListBox1" runat="server" Width="150px" SelectionMode="Multiple"></asp:ListBox>
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>

            <br />
            <br />

            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label2" Font-Bold="true" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>