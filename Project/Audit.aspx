<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Audit.aspx.cs" Inherits="Project.Audit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">





        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            background-color: #0066FF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <p>
                    &nbsp;</p>
                <p class="auto-style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="Image2" runat="server" Height="118px" ImageUrl="~/images-2.jpg" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Times New Roman" Font-Size="XX-Large" Font-Underline="True" ForeColor="#FF3300" Text="ARMED FORCES INITIAL TESTS"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="Image1" runat="server" Height="118px" ImageUrl="~/ezgif.com-resize.gif" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </p>
                <div class="auto-style1">
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style2" Height="16px" style="background-color: #000000" Width="1282px" />
                </div>
            </div>
            <p>
                &nbsp; </p>
            <p class="auto-style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Font-Underline="True" ForeColor="Red" Text="AUDIT TEAM"></asp:Label>
                </p>
        </div>
        <p class="auto-style1">
            <asp:Button ID="Button4" runat="server" CssClass="auto-style2" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large" Height="76px" OnClick="Button4_Click" Text="REGISTRATION RECORDS" Width="303px" />
            <asp:Button ID="Button5" runat="server" CssClass="auto-style2" Font-Bold="True" Font-Italic="False" Font-Names="Times New Roman" Font-Size="Large" Height="79px" OnClick="Button5_Click" Text="CLEAR COMPUTERIED TEST RECORD" Width="471px" />
            <asp:Button ID="Button6" runat="server" CssClass="auto-style2" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large" Height="79px" Text="MEDICAL RECORD" Width="277px" OnClick="Button6_Click" />
            <asp:Button ID="Button8" runat="server" CssClass="auto-style2" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large" Height="79px" Text="FINAL RECORD" Width="301px" OnClick="Button8_Click" />
            <asp:Button ID="Button7" runat="server" CssClass="auto-style2" Font-Bold="True" Font-Names="Times New Roman" Font-Size="Large" Height="79px" Text="BACK TO HOME" Width="202px" OnClick="Button7_Click" />
            <br />
            </p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
