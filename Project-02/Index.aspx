<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Project_02.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

             <asp:Label ID="LabelHeading" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#333333" Text="My Exterminator Website"></asp:Label>
            <br />
            <br />
            <br />
            <asp:ListBox ID="ListBoxCustomers" runat="server" Height="250px" Width="700px"></asp:ListBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="LabelSubheading" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#333333" Text="Add new customer"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelFirstname" runat="server" Text="Firstname:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBoxFirstname" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelLastname" runat="server" Text="Lastname:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxLastname" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelAge" runat="server" Text="Age:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxAge" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelZipcode" runat="server" Text="Zipcode:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxZipcode" runat="server"></asp:TextBox>
            <!--<br />
            <br />
            <asp:Label ID="LabelCountry" runat="server" Text="Country:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxCountry" runat="server"></asp:TextBox> -->
            <br />
            <br />
            <asp:Label ID="LabelPassword" runat="server" Text="Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="ButtonCreate" runat="server" OnClick="ButtonCreate_Click" Text="Create customer" />

            <br />
            <br />
            <br />

        </div>
    </form>
</body>
</html>
