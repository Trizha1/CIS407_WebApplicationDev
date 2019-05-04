<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPersonnel.aspx.cs" Inherits="Lab1_AnnualSalaryCalculator.frmPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="frmMain.aspx">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/CIS407A_iLab_ACITLogo.jpg" />
        </asp:HyperLink>
        <div>
            <asp:Panel ID="Panel1" runat="server" Height="250px" HorizontalAlign="Left" Width="500px">
                <asp:Label ID="Label1" runat="server" Text="First Name:" width="102px"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtFirstName" runat="server" ValidationGroup="val"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="First name cannot be blank" ValidationGroup="val"></asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Last Name:" width="101px"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtLastName" runat="server" ValidationGroup="val"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last name cannot be blank" ValidationGroup="val"></asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Pay Rate:" width="101px"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label4" runat="server" Text="Start Date:" width="101px"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label5" runat="server" Text="End Date:" width="101px"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="btnSubmit" runat="server" PostBackUrl="" Text="Submit" OnClick="btnSubmit_Click" />
                &nbsp; &nbsp;
                <br />
                <br />
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
