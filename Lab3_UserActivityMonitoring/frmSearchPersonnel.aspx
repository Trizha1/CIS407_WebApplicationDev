<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSearchPersonnel.aspx.cs" Inherits="Lab1_AnnualSalaryCalculator.frmSearchPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/CIS407A_iLab_ACITLogo.jpg" PostBackUrl="~/frmMain.aspx" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Search for employee by last Name:"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtSearch" runat="server" Width="183px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" PostBackUrl="~/frmViewPersonnel.aspx" Text="Search" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
