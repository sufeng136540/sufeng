<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Maticsoft.Web.OrderTab.Modify" Title="修改页" %>
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
		<asp:label id="lblid" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MemberID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMemberID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MemberName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMemberName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MemberPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMemberPhone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MemberPhone1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMemberPhone1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MemberAdd
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMemberAdd" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Orderdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtOrderdate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OrderNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOrderNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StaffmemberID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStaffmemberID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Staffmembername
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStaffmembername" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserTabID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUserTabID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PhotoID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPhotoID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		validity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtvalidity" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		progress
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtprogress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Deposit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDeposit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AllMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAllMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		alllength
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtalllength" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Imperial
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtImperial" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QhWidth
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtQhWidth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Beizhuwg
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBeizhuwg" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Beizhuzz
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBeizhuzz" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Zengsong
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZengsong" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Zhuangtai1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZhuangtai1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Zhuangtai2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZhuangtai2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		By1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBy1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		By2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBy2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		By3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBy3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		By4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBy4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		By5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBy5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		By6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBy6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		By7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBy7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

