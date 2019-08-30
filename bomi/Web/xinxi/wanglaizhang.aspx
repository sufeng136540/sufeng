<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wanglaizhang.aspx.cs" Inherits="Maticsoft.Web.xinxi.wanglaizhang" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>工厂单据列表</title>
    <link href="../css/css.css" rel="stylesheet" type="text/css" />
	<script type="text/javascript" src="../js/jquery-1.4.4.min.js"></script>
	<script type="text/javascript" src="../js/jquery.easyui.min.js"></script>
	<script type="text/javascript" src="../js/a.js"></script>
	<script type="text/javascript" src="../laydate/laydate.js"></script>
    </head>
<body>
    <form id="form1" runat="server">
	<div id="tt" class="easyui-tabs" >
    <div id="container">
<table width="98%" border="0" align="left" cellpadding="0" cellspacing="1">
  <tr>
    <td colspan="10" class="tabaa"><asp:Image ID="Image1" runat="server" src="../images/bianti_jiao.jpg" width="34" height="33" align="left" /><span class="biaoti1">工厂单据列表</span></td>
  </tr>
    
  <tr>
  <td height="33" colspan="10" align="left"  > &nbsp;单据编号：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
      客户名称：<asp:TextBox ID="TextBox13" runat="server" Width="80px"></asp:TextBox>
      &nbsp;销售员：&nbsp;<asp:DropDownList 
          ID="DropDownList1" runat="server" Width="120px">
      </asp:DropDownList>
      &nbsp; 收款日期：<asp:TextBox ID="TextBox11" runat="server" onClick="laydate()" 
          Width="100px"></asp:TextBox>
      ---<asp:TextBox ID="TextBox12" runat="server" onClick="laydate()" Width="100px"></asp:TextBox>
  <asp:Button ID="Button1" runat="server" Text="查  询" onclick="Button1_Click" /></td>
  </tr>
  <tr class="a2875d3">
    <td width="7%" height="30" align="center">单据编号</td>
    <td width="5%" align="center">客户姓名</td>
    <td width="8%" align="center">客户电话1</td>
    <td width="8%" align="center">客户电话2</td>
	<td width="5%" align="center">销售员</td>
    <td width="8%" align="center">送货日期</td>
    <td width="5%" align="center">总金额</td>
    <td width="8%" align="center" >往来类型</td>
    <td width="5%" align="center" >收款金额</td>
    <td width="8%" align="center">收款时间</td>

	 </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
	  <tr runat="server" id="trbs">
            <td  align="center" height="30"><%# Eval("billnumber")%></td>
            <td  align="center"><%# Eval("MemberName")%></td>
            <td  align="center"><%# Eval("MemberPhone")%></td>
            <td  align="center"><%# Eval("MemberPhone1")%></td>
	        <td  align="center"><%# Eval("Staffname")%></td>
            <td  align="center"><%#Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "validity")).ToShortDateString()%></td>
            <td  align="center"><%# Eval("AllMoney")%></td>
            <td  align="center"><%# Eval("sk")%></td>
            <td  align="center"><%# Eval("money")%></td>
            <td  align="center"><%# Eval("receipt")%></td>
        </tr>
        </ItemTemplate>
     </asp:Repeater>
  </table>
	</div>
	</div>
    </form>
</body>
</html>