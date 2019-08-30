<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wanchengdanju.aspx.cs" Inherits="Maticsoft.Web.danju.wanchengdanju" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>职员单据列表</title>
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
    <td colspan="10" class="tabaa"><asp:Image ID="Image1" runat="server" src="../images/bianti_jiao.jpg" width="34" height="33" align="left" /><span class="biaoti1">职员单据列表</span></td>
  </tr>
    
  <tr>
  <td height="33" colspan="10" align="left"  > &nbsp;&nbsp; 单据编号：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>&nbsp;销售员：&nbsp;<asp:DropDownList 
          ID="DropDownList1" runat="server" Width="120px">
      </asp:DropDownList>
      &nbsp; 送货日期：<asp:TextBox ID="TextBox11" runat="server" onClick="laydate()"></asp:TextBox>
      ---<asp:TextBox ID="TextBox12" runat="server" onClick="laydate()"></asp:TextBox>
  <asp:Button ID="Button1" runat="server" Text="查  询" onclick="Button1_Click" /></td>
  </tr>
  <tr class="a2875d3">
    <td width="10%" height="30" align="center">单据编号</td>
    <td width="8%" align="center">客户姓名</td>
    <td width="12%" align="center">客户电话1</td>
    <td width="12%" align="center">客户电话2</td>
	<td width="8%" align="center">销售员</td>
    <td width="15%" align="center">送货日期</td>
    <td width="10%" align="center">总金额</td>
    <td width="10%" align="center" >未付款</td>
    <td width="8%" align="center">进度</td>
    <td align="center" width="12%">操作</td>
	 </tr>
        <asp:Repeater ID="Repeater1" runat="server" >
            <ItemTemplate>
	  <tr runat="server" id="trbs">
            <td  align="center" height="30"><%# Eval("OrderNumber")%></td>
            <td  align="center"><%# Eval("MemberName")%></td>
            <td  align="center"><%# Eval("MemberPhone")%></td>
            <td  align="center"><%# Eval("MemberPhone1")%></td>
	        <td  align="center"><%# Eval("Staffname")%></td>
            <td  align="center"><%#Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "validity")).ToShortDateString()%></td>
            <td  align="center"><%# Eval("AllMoney")%></td>
            <td  align="center"><%# Eval("wfk")%></td>
            <td  align="center"><%# Eval("progress")%></td>
            <td  align="center" >
                    <asp:LinkButton ID="LinkButton1" runat="server"  CommandArgument='<%# Eval("id") %>' onclick="LinkButton1_Click" ForeColor="#0066FF">详情</asp:LinkButton>
</td>
        </tr>
        </ItemTemplate>
     </asp:Repeater>
  </table>
	</div>
	</div>
    </form>
</body>
</html>
