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
            <asp:Panel ID="Panel1" runat="server" Height="1400px" Width="500px">
                <asp:ImageButton ID="imgbtnCalculator" runat="server" Height="150px" ImageUrl="~/Images/SalaryCalculatorScreen.jpg" PostBackUrl="~/frmSalaryCalculator.aspx" />
                &nbsp;&nbsp;
                <asp:LinkButton ID="linkbtnCalculator" runat="server" PostBackUrl="~/frmSalaryCalculator.aspx">Annual Salary Calculator</asp:LinkButton>
                <br />
                <br />
                <asp:ImageButton ID="imgbtnNewEmployee" runat="server" Height="150px" ImageUrl="~/Images/welcome-new-employee-clipart-1 (1).jpg" PostBackUrl="~/frmPersonnel.aspx" Width="220px" />
                &nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="linkbtnNewEmployee" runat="server" PostBackUrl="~/frmPersonnel.aspx">Add New Employee</asp:LinkButton>
                <br />
                <br />
                <asp:ImageButton ID="imgbtnViewUserActivity" runat="server" Height="153px" ImageUrl="~/Images/userActivity.png" PostBackUrl="~/frmUserActivity.aspx" Width="217px" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="linkbtnViewUserActivity" runat="server" PostBackUrl="~/frmUserActivity.aspx">View User Activity</asp:LinkButton>
                <br />
                <br />
                <br />
                <asp:ImageButton ID="imgbtnViewPersonnel" runat="server" Height="169px" ImageUrl="~/Images/personnel.jpg" PostBackUrl="~/frmViewPersonnel.aspx" Width="185px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="linkbtnViewPersonnel" runat="server" PostBackUrl="~/frmViewPersonnel.aspx">View Personnel</asp:LinkButton>
                <br />
                <br />
                <br />
                <asp:ImageButton ID="imgbtnSearch" runat="server" Height="146px" ImageUrl="~/Images/viewPersonnel.png" PostBackUrl="~/frmSearchPersonnel.aspx" Width="178px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="linkbtnSearch" runat="server" PostBackUrl="~/frmSearchPersonnel.aspx">Search Personnel</asp:LinkButton>
                <br />
                <br />
                <br />
                <asp:ImageButton ID="imgbtnEditEmployees" runat="server" Height="148px" ImageUrl="~/Images/ediEmployee.png" PostBackUrl="~/frmEditPersonnel.aspx" Width="176px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="linkbtnEditEmployees" runat="server" PostBackUrl="~/frmEditPersonnel.aspx">Edit Employees</asp:LinkButton>
                <br />
                <br />
                <br />
                <br />
                <asp:ImageButton ID="imgbtnManageUsers" runat="server" Height="165px" ImageUrl="~/Images/manageUsers.png" PostBackUrl="~/frmManageUsers.aspx" Width="196px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="linkbtnManageUsers" runat="server" PostBackUrl="~/frmManageUsers.aspx">Manage Users</asp:LinkButton>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
