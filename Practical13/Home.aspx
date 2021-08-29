<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Practical13.Home" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #008080;
        }
        .auto-style2 {
            width: 180px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style8 {
            width: 201px;
            height: 26px;
        }
        .auto-style9 {
            width: 201px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <div>
            <h1 style="background-color: #CC99FF">Registration Page</h1>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style9" style="background-color: #00FF99">
                        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td class="auto-style2" style="background-color: #00FF99">
                        <asp:TextBox ID="txt_fn" runat="server" BorderStyle="Groove"></asp:TextBox>
                    </td>
                    <td style="background-color: #00FF99">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter The First Name" ForeColor="Green" ControlToValidate="txt_fn"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="background-color: #00FF99">
                        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
                    </td>
                    <td class="auto-style2" style="background-color: #00FF99">
                        <asp:TextBox ID="txt_ln" runat="server" BorderStyle="Groove"></asp:TextBox>
                    </td>
                    <td style="background-color: #00FF99">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter The Last Name" ForeColor="Green" ControlToValidate="txt_ln"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="background-color: #00FF99">
                        <asp:Label ID="Label3" runat="server" Text="Username"></asp:Label>
                    </td>
                    <td class="auto-style2" style="background-color: #00FF99">
                        <asp:TextBox ID="txt_un" runat="server" BorderStyle="Groove"></asp:TextBox>
                    </td>
                    <td style="background-color: #00FF99">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Enter The User Name" ForeColor="Green" ControlToValidate="txt_un"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_un" ErrorMessage="username must contain upper case, lower case, digits and text will be in between 7-20" ForeColor="Red" ValidationExpression="^[A-Z]{1,5}[a-z]{1,5}[0-9]{1,5}$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="background-color: #00FF99">
                        <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td class="auto-style2" style="background-color: #00FF99">
                        <asp:TextBox ID="txt_p" runat="server" BorderStyle="Groove" TextMode="Password">txt_fn</asp:TextBox>
                    </td>
                    <td style="background-color: #00FF99">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Enter The Password" ForeColor="Green" ControlToValidate="txt_p"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style9" style="background-color: #00FF99">
                        <asp:Label ID="Label12" runat="server" Text="Confirm Password"></asp:Label>
                     </td>
                    <td class="auto-style2" style="background-color: #00FF99">
                        <asp:TextBox ID="txt_cp" runat="server" BorderStyle="Groove" TextMode="Password"></asp:TextBox>
                     </td>
                    <td style="background-color: #00FF99">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please Confirm Password" ForeColor="Green" ControlToValidate="txt_cp"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt_p" ControlToValidate="txt_cp" ErrorMessage="It should be same" ForeColor="Red"></asp:CompareValidator>
                     </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="background-color: #00FF99">
                        <asp:Label ID="Label6" runat="server" Text="Contact No."></asp:Label>
                    </td>
                    <td class="auto-style2" style="background-color: #00FF99">
                        <asp:TextBox ID="txt_cn" runat="server" BorderStyle="Groove"></asp:TextBox>
                    </td>
                    <td style="background-color: #00FF99">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please Enter The Contact Number" ForeColor="Green" ControlToValidate="txt_cn"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please enter 10 digit number" ForeColor="Red" ValidationExpression="^[7-9][0-9]{9}$" ControlToValidate="txt_cn"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="background-color: #00FF99">
                        <asp:Label ID="Label7" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td class="auto-style2" style="background-color: #00FF99">
                        <asp:TextBox ID="txt_e" runat="server" BorderStyle="Groove"></asp:TextBox>
                    </td>
                    <td style="background-color: #00FF99">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Please Enter The Email" ForeColor="Green" ControlToValidate="txt_e"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Please enter valid email-id" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txt_e"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="background-color: #00FF99">
                        <asp:Label ID="Label8" runat="server" Text="Country"></asp:Label>
                    </td>
                    <td class="auto-style2" style="background-color: #00FF99">
                        <asp:TextBox ID="txt_c" runat="server" BorderStyle="Groove"></asp:TextBox>
                    </td>
                    <td style="background-color: #00FF99">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Please Enter The Country" ForeColor="Green" ControlToValidate="txt_c"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="background-color: #00FF99">
                        <asp:Label ID="Label9" runat="server" Text="State"></asp:Label>
                    </td>
                    <td class="auto-style2" style="background-color: #00FF99">
                        <asp:TextBox ID="txt_s" runat="server" BorderStyle="Groove"></asp:TextBox>
                    </td>
                    <td style="background-color: #00FF99">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Please Enter The State" ForeColor="Green" ControlToValidate="txt_s"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="background-color: #00FF99">
                        <asp:Label ID="Label10" runat="server" Text="City"></asp:Label>
                    </td>
                    <td class="auto-style2" style="background-color: #00FF99">
                        <asp:TextBox ID="txt_ct" runat="server" BorderStyle="Groove"></asp:TextBox>
                    </td>
                    <td style="background-color: #00FF99">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Please Enter The City" ForeColor="Green" ControlToValidate="txt_ct"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="background-color: #00FF99">
                        <asp:Label ID="Label11" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td class="auto-style2" style="background-color: #00FF99">
                        <asp:TextBox ID="txt_a" runat="server" BorderStyle="Groove" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td style="background-color: #00FF99">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="Please Enter The Address" ForeColor="Green" ControlToValidate="txt_a"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="background-color: #00FF99">
                        <asp:Label ID="Label5" runat="server" Text="D.O.B"></asp:Label>
                    </td>
                    <td class="auto-style2" style="background-color: #00FF99">
                        <asp:TextBox ID="txt_dob" runat="server" BorderStyle="Groove"></asp:TextBox>
                    </td>
                    <td style="background-color: #00FF99">
                        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                        </cc1:ToolkitScriptManager>
                    </td>
                    <td>
                        <cc1:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txt_dob" Format="yyyy/MM/dd"></cc1:CalendarExtender>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8" style="background-color: #00FF99">
                        <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />
                    </td>
                    <td class="auto-style6" colspan="2" style="background-color: #00FF99">
                    </td>
                </tr>
            </table>
        </div>
        </center>
    </form>
</body>
</html>
