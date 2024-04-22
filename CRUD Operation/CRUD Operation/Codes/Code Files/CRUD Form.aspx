<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUD Form.aspx.cs" Inherits="CRUD_Operation.CRUD_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            
            <table style="width:100%" >
                <tr>
                    <th >Student Details Form</th>
                </tr>
                <tr>
                    <td>First Name</td>
                   <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    <td>Last Name</td>
                   <td> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Email Address</td>
                    <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                    <td>Phone Number</td>
                    <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Teacher</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">

                        </asp:DropDownList></td>
                    <td>Date Of Birth</td>
                    <td><asp:Calendar ID="Calendar1" runat="server"></asp:Calendar></td>
               </tr>
               <tr>
                    <td>Is Pass</td>
                    <td></td>
                    <td>Grade</td>
                   <td>
                       <asp:RadioButton ID="RadioButton1" runat="server" Text="A" GroupName="Grade" />
                       <asp:RadioButton ID="RadioButton2" runat="server" Text="B" GroupName="Grade" />
                       <asp:RadioButton ID="RadioButton3" runat="server" Text="C" GroupName="Grade" />
                       <asp:RadioButton ID="RadioButton4" runat="server" Text="D" GroupName="Grade"/>
                   </td>
               </tr>
              <tr>
                     <td>Favourite Book</td>
                     <td>
                         <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
                         <asp:ListItem Value="ENG">English</asp:ListItem>
                         <asp:ListItem Value="HIN">Hindi</asp:ListItem>
                         <asp:ListItem Value="SST">Social Studies</asp:ListItem>
                         <asp:ListItem vale="SKT">Sanskrit</asp:ListItem>
                         </asp:CheckBoxList>

                     </td>
                     <td>Favourite Website</td>
                     <td><asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink></td>
              </tr>
            </table>
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>            

        </div>
    </form>
    
</body>
</html>
