﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Maticsoft.Web.Homemadetab.Modify" Title="修改页" %>
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
		Name
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Photourl
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPhotourl" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Comment
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtComment" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Beizhu
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBeizhu" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BY1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBY1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BY2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBY2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BY3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBY3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BY4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBY4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BY5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBY5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BY6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBY6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BY7
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBY7" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

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
