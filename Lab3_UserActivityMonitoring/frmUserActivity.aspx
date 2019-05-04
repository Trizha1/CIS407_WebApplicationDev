<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmUserActivity.aspx.cs" Inherits="Lab1_AnnualSalaryCalculator.frmUserActivity" %>

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
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label1" runat="server" Text="User Activity"></asp:Label>
                <asp:GridView ID="grdUserActivity" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                </asp:GridView>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
