<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zhiyuandanjulist.aspx.cs" Inherits="Maticsoft.Web.danju.zhiyuandanju" %>
<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>
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
    <script type="text/javascript">
        function showDiv1() {
            document.getElementById('popDiv1').style.display = 'block';
            document.getElementById('bg1').style.display = 'block';
        }

        function closeDiv1() {
            document.getElementById('popDiv1').style.display = 'none';
            document.getElementById('bg1').style.display = 'none';
        }
</script>
    <script type="text/javascript">
     function showDiv2() {
         document.getElementById('popDiv2').style.display = 'block';
         document.getElementById('bg1').style.display = 'block';
     }

     function closeDiv2() {
         document.getElementById('popDiv2').style.display = 'none';
         document.getElementById('bg1').style.display = 'none';
     }
</script>
    </head>
<body>
    <form id="form1" runat="server">
    <div id="popDiv1" class="mydiv" style="display:none;">
		  <div class="biaot">
		  <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;二维码<asp:Label ID="Label2" runat="server" Text=""></asp:Label></h1><h2><a href="javascript:closeDiv1()"><img src="../images/fenlei/dialog_closebtn.gif" alt="CPU"  onmouseover="this.src='../images/fenlei/dialog_closebtn_over.gif'" onmouseout="this.src='images/fenlei/dialog_closebtn.gif'" align="right" /></a>&nbsp;&nbsp;&nbsp;</h2>
		  <div class="js1 zhong" style="padding-left:200px; padding-top:100px">
		     <asp:Image ID="Image2" runat="server" Width="200px" Height="200px"  />
		  </div>
		  </div>
</div>
    <div id="popDiv2" class="mydiv" style="display:none;">
		  <div class="biaot">
		  <h1>&nbsp;&nbsp;&nbsp;&nbsp;收款<asp:Label ID="Label1" runat="server" Text=""></asp:Label></h1><h2><a href="javascript:closeDiv2()"><img src="../images/fenlei/dialog_closebtn.gif" alt="CPU"  onmouseover="this.src='../images/fenlei/dialog_closebtn_over.gif'" onmouseout="this.src='../images/fenlei/dialog_closebtn.gif'" align="right" /></a>&nbsp;&nbsp;&nbsp;</h2>
		  <div class="js1 zhong11">
		   <table width="100%" border="0" align="left" cellpadding="5" cellspacing="1">
		   <tr>
		       <td align="center" style="padding:5px;">单据编号：</td>
               <td align="left" style="padding:5px;"><asp:Label ID="Label3" runat="server"></asp:Label></td>
           </tr>
            <tr>
		       <td align="center" style="padding:5px;">总款金额：</td>
               <td align="left" style="padding:5px;"><asp:Label ID="Label4" runat="server"></asp:Label></td>
           </tr>
            <tr>
		       <td align="center" style="padding:5px;">已付款金额：</td>
               <td align="left" style="padding:5px;"><asp:Label ID="Label5" runat="server"></asp:Label></td>
           </tr>
             <tr>
		       <td align="center" style="padding:5px;">收款状况：</td>
               <td align="left" style="padding:5px;">
                  <asp:DropDownList ID="DropDownList8" runat="server" >
                        <asp:ListItem Value="0" Text="0">选择付款状况</asp:ListItem>
                        <asp:ListItem Value="1" Text="1">未付全款</asp:ListItem>
                        <asp:ListItem Value="2" Text="2">已付全款</asp:ListItem>
                    </asp:DropDownList>
               </td>
           </tr>
            <tr>
		       <td align="center" style="padding:5px;">本次收款金额：</td>
               <td align="left" style="padding:5px;"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
           </tr>
		   </table>
		  </div>
            <p><a href="javascript:closeDiv2()">
          <asp:ImageButton ID="ImageButton1" runat="server" onclick="ImageButton1_Click" src="../images/fenlei/queren.jpg" />
          </a></p>
		  </div>
</div>
	<div id="tt" class="easyui-tabs" >
    <div id="container">
<table width="98%" border="0" align="left" cellpadding="0" cellspacing="1">
  <tr>
    <td colspan="12" class="tabaa"><asp:Image ID="Image1" runat="server" src="../images/bianti_jiao.jpg" width="34" height="33" align="left" /><span class="biaoti1">职员单据列表</span></td>
  </tr>
    
  <tr>
  <td height="33" colspan="12" align="left"  > &nbsp;&nbsp; 单据编号：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>&nbsp;销售员：&nbsp;<asp:DropDownList 
          ID="DropDownList1" runat="server" Width="120px">
      </asp:DropDownList>
      &nbsp; 送货日期：<asp:TextBox ID="TextBox11" runat="server" onClick="laydate()"></asp:TextBox>
      ---<asp:TextBox ID="TextBox12" runat="server" onClick="laydate()"></asp:TextBox>
  <asp:Button ID="Button1" runat="server" Text="查  询" onclick="Button1_Click" /></td>
  </tr>
  <tr class="a2875d3">
    <td width="10%" height="30" align="center">单据编号</td>
    <td width="8%" align="center">客户姓名</td>
    <td width="10%" align="center">客户电话1</td>
    <td width="10%" align="center">客户电话2</td>
	<td width="8%" align="center">销售员</td>
    <td width="10%" align="center">送货日期</td>
    <td width="6%" align="center">总金额</td>
    <td width="6%" align="center" >未付款</td>
    <td width="6%" align="center">进度</td>
    <td align="center" width="15%">操作</td>
    <td align="center" width="5%">收款</td>
    <td align="center" width="5%">二维码</td>
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
                    <asp:LinkButton ID="LinkButton1" runat="server"  CommandArgument='<%# Eval("id") %>' onclick="LinkButton1_Click" ForeColor="#0066FF">详情</asp:LinkButton>&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton2" runat="server"  CommandArgument='<%# Eval("id") %>' onclick="LinkButton2_Click" ForeColor="#0066FF">修改</asp:LinkButton>&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton3" runat="server"  CommandArgument='<%# Eval("id") %>' onclick="LinkButton3_Click" ForeColor="#0066FF" OnInit="lbtnDelete_Init">删除</asp:LinkButton>
            </td>
            <td  align="center"><asp:LinkButton ID="LinkButton5" runat="server"  CommandArgument='<%# Eval("id") %>' onclick="LinkButton5_Click" ForeColor="#0066FF">收款</asp:LinkButton></td>
            <td  align="center"><asp:LinkButton ID="LinkButton4" runat="server"  CommandArgument='<%# Eval("id") %>' onclick="LinkButton4_Click" ForeColor="#0066FF">二维码</asp:LinkButton></td>
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
