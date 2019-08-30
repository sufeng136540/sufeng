<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gongchangdanjulist.aspx.cs" Inherits="Maticsoft.Web.danju.danjulist" %>

<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>

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
    <td colspan="16" class="tabaa"><asp:Image ID="Image1" runat="server" src="../images/bianti_jiao.jpg" width="34" height="33" align="left" /><span class="biaoti1">工厂单据列表</span></td>
  </tr>
    
  <tr>
  <td height="33" colspan="16" align="left"  > &nbsp;&nbsp; 单据编号：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>&nbsp;销售员：&nbsp;<asp:DropDownList 
          ID="DropDownList1" runat="server" Width="120px">
      </asp:DropDownList>
      &nbsp; 送货日期：<asp:TextBox ID="TextBox11" runat="server" onClick="laydate()"></asp:TextBox>
      ---<asp:TextBox ID="TextBox12" runat="server" onClick="laydate()"></asp:TextBox>
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
    <td width="5%" align="center" >未付款</td>
    <td width="5%" align="center">进度</td>
    <td align="center" colspan="7">操作</td>
	 </tr>
        <asp:Repeater ID="Repeater1" runat="server" onitemdatabound="Repeater1_ItemDataBound">
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
            <td  align="center" ><asp:LinkButton ID="LinkButton3" runat="server"  CommandArgument='<%# Eval("id") %>' onclick="LinkButton3_Click" ForeColor="#0066FF" OnInit="lbtnDelete_Init3">下单</asp:LinkButton></td>
            <td  align="center" ><asp:LinkButton ID="LinkButton4" runat="server"  CommandArgument='<%# Eval("id") %>' onclick="LinkButton4_Click" ForeColor="#0066FF" OnInit="lbtnDelete_Init4">排产</asp:LinkButton></td>
            <td  align="center" ><asp:LinkButton ID="LinkButton5" runat="server"  CommandArgument='<%# Eval("id") %>' onclick="LinkButton5_Click" ForeColor="#0066FF" OnInit="lbtnDelete_Init5">生产中</asp:LinkButton></td>
            <td  align="center" ><asp:LinkButton ID="LinkButton6" runat="server"  CommandArgument='<%# Eval("id") %>' onclick="LinkButton6_Click" ForeColor="#0066FF" OnInit="lbtnDelete_Init6">入库</asp:LinkButton></td>
            <td  align="center" ><asp:LinkButton ID="LinkButton7" runat="server"  CommandArgument='<%# Eval("id") %>' onclick="LinkButton7_Click" ForeColor="#0066FF" OnInit="lbtnDelete_Init7">可送货</asp:LinkButton></td>
            <td  align="center" ><asp:LinkButton ID="LinkButton8" runat="server"  CommandArgument='<%# Eval("id") %>' onclick="LinkButton8_Click" ForeColor="#0066FF" OnInit="lbtnDelete_Init8">完成</asp:LinkButton></td>
            <td  align="center" ><asp:LinkButton ID="LinkButton1" runat="server"  CommandArgument='<%# Eval("id") %>' onclick="LinkButton1_Click" ForeColor="#0066FF">详情</asp:LinkButton></td>
        </tr>
        </ItemTemplate>
     </asp:Repeater>
  </table>
   <div class="Paging" style="height:35px; float:left; width:100%;">
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首页" 
            HorizontalAlign="Center" LastPageText="末页" NextPageText="下一页" 
            PagingButtonSpacing="10px" PrevPageText="上一页" ShowBoxThreshold="2" 
            onpagechanged="AspNetPager1_PageChanged" PageSize="10"  >
        </webdiyer:AspNetPager>   
    </div> 
	</div>
	</div>
    </form>
</body>
</html>