<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.OrderTab.Show" Title="显示页" %>
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
		MemberID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMemberID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MemberName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMemberName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MemberPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMemberPhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MemberPhone1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMemberPhone1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MemberAdd
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMemberAdd" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Orderdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOrderdate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OrderNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOrderNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StaffmemberID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStaffmemberID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Staffmembername
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStaffmembername" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserTabID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUserTabID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PhotoID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPhotoID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		validity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblvalidity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		progress
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblprogress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Deposit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDeposit" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AllMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAllMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		alllength
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblalllength" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Imperial
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblImperial" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QhWidth
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQhWidth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Beizhuwg
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBeizhuwg" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Beizhuzz
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBeizhuzz" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Zengsong
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblZengsong" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Zhuangtai1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblZhuangtai1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Zhuangtai2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblZhuangtai2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		By1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBy1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		By2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBy2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		By3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBy3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		By4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBy4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		By5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBy5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		By6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBy6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		By7
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBy7" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




