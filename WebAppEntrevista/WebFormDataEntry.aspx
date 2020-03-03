<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormDataEntry.aspx.cs" Inherits="WebAppEntrevista.WebFormDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label>Set Data for Cube A:</label><br />
        <label>Position:</label><br />
        X: <asp:TextBox ID="txtCoordXCubeA" runat="server"></asp:TextBox>
        Y: <asp:TextBox ID="txtCoordYCubeA" runat="server"></asp:TextBox>
        Z: <asp:TextBox ID="txtCoordZCubeA" runat="server"></asp:TextBox>
        <label>Dimension:</label><br />
        Height: <asp:TextBox ID="txtHeightCubeA" runat="server"></asp:TextBox>
        Length: <asp:TextBox ID="txtLengthCubeA" runat="server"></asp:TextBox>
        Width: <asp:TextBox ID="txtWidthCubeA" runat="server"></asp:TextBox><br />
        <label>Set Data for Cube B:</label><br />
        <label>Position:</label><br />
        X: <asp:TextBox ID="txtCoordXCubeB" runat="server"></asp:TextBox>
        Y: <asp:TextBox ID="txtCoordYCubeB" runat="server"></asp:TextBox>
        Z: <asp:TextBox ID="txtCoordZCubeB" runat="server"></asp:TextBox>
        <label>Dimension:</label><br />
        Height: <asp:TextBox ID="txtHeightCubeB" runat="server"></asp:TextBox>
        Length: <asp:TextBox ID="txtLengthCubeB" runat="server"></asp:TextBox>
        Width: <asp:TextBox ID="txtWidthCubeB" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
    </div>
    </form>
</body>
</html>
