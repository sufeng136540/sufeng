<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.Currentaccount.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltype" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MemberID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMemberID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OrderTabday
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOrderTabday" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OrderTabmoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOrderTabmoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		receipt
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblreceipt" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		money
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Beizhu
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBeizhu" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BY1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBY1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BY2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBY2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BY3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBY3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BY4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBY4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BY5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBY5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BY6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBY6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BY7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBY7" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




