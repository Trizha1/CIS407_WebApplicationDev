<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPersonnelVerified.aspx.cs" Inherits="Lab1_AnnualSalaryCalculator.frmPersonnelVerified" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="frmMain.aspx">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/CIS407A_iLab_ACITLogo.jpg" />
            </asp:HyperLink>
            <br />
            <asp:Panel ID="Panel1" runat="server" Height="250px" Width="650px">
                <asp:Label ID="Label1" runat="server" Text="Information to submit"></asp:Label>
                &nbsp;<asp:TextBox ID="txtVerifiedInfo" runat="server" Height="80px" TextMode="MultiLine" Width="400px" OnTextChanged="txtVerifiedInfo_TextChanged"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnViewPersonnel" runat="server" PostBackUrl="~/frmViewPersonnel.aspx" Text="View Personnel" OnClick="btnViewPersonnel_Click" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
