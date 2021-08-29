<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Example2.aspx.cs" Inherits="_19012011094_Practical16.Example2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 75%;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style2 {
            width: 79px;
        }
        .auto-style3 {
            width: 134px;
        }
        .auto-style4 {
            width: 215px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>CRUD OPERATIONS</h1>
                <div>

                    <table class="auto-style1">
                        <tr>
                            <td style="background-color: #00FF00" colspan="4">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style2" style="background-color: #99FFCC">&nbsp;</td>
                            <td class="auto-style3" style="background-color: #99FFCC">
                                <asp:Label ID="Label1" runat="server" Text="Roll Number:"></asp:Label>
                            </td>
                            <td class="auto-style4" style="background-color: #99FFCC">
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                            <td style="background-color: #99FFCC">
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2" style="background-color: #99FFCC">&nbsp;</td>
                            <td class="auto-style3" style="background-color: #99FFCC">
                                <asp:Label ID="Label2" runat="server" Text="Student Name:"></asp:Label>
                            </td>
                            <td class="auto-style4" style="background-color: #99FFCC">
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </td>
                            <td style="background-color: #99FFCC">
                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2" style="background-color: #99FFCC">&nbsp;</td>
                            <td class="auto-style3" style="background-color: #99FFCC">
                                <asp:Label ID="Label3" runat="server" Text="Father's Name:"></asp:Label>
                            </td>
                            <td class="auto-style4" style="background-color: #99FFCC">
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            </td>
                            <td style="background-color: #99FFCC">
                                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2" style="background-color: #99FFCC">&nbsp;</td>
                            <td class="auto-style3" style="background-color: #99FFCC">
                                <asp:Label ID="Label4" runat="server" Text="Mother's Name:"></asp:Label>
                            </td>
                            <td class="auto-style4" style="background-color: #99FFCC">
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                            </td>
                            <td style="background-color: #99FFCC">
                                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Show Data" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" style="background-color: #FF3300">&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="4" style="background-color: #FFFF00">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                                    <AlternatingRowStyle BackColor="#DCDCDC" />
                                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#000065" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td style="background-color: #00FF00" colspan="4">&nbsp;</td>
                        </tr>
                    </table>

                </div>
            </center>
        </div>
    </form>
</body>
</html>
