<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMain.aspx.cs" Inherits="Lab1_AnnualSalaryCalculator.frmMain" %>

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
            <asp:Panel ID="Panel1" runat="server" Height="350px" Width="500px">
                <asp:ImageButton ID="ImageButton1" runat="server" Height="150px" ImageUrl="~/Images/SalaryCalculatorScreen.jpg" PostBackUrl="~/frmSalaryCalculator.aspx" />
                &nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/frmSalaryCalculator.aspx">Annual Salary Calculator</asp:LinkButton>
                <br />
                <br />
                <asp:ImageButton ID="ImageButton2" runat="server" Height="150px" ImageUrl="~/Images/welcome-new-employee-clipart-1 (1).jpg" PostBackUrl="~/frmPersonnel.aspx" Width="220px" />
                &nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/frmPersonnel.aspx">Add New Employee</asp:LinkButton>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
