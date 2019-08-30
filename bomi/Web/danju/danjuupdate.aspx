<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="danjuupdate.aspx.cs" Inherits="Maticsoft.Web.danju.danjuupdate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>单据录入</title>
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
<script type="text/javascript">
    function showDiv3() {
        document.getElementById('popDiv3').style.display = 'block';
        document.getElementById('bg1').style.display = 'block';
    }

    function closeDiv3() {
        document.getElementById('popDiv3').style.display = 'none';
        document.getElementById('bg1').style.display = 'none';
    }

</script>
<script type="text/javascript">
    function showDiv5() {
        document.getElementById('popDiv5').style.display = 'block';
        document.getElementById('bg1').style.display = 'block';
    }

    function closeDiv5() {
        document.getElementById('popDiv5').style.display = 'none';
        document.getElementById('bg1').style.display = 'none';
    }

</script>
</head>
<body>
    <form id="form1" runat="server">
 
 <%--自制商品--%>
    <div id="popDiv1" class="mydiv" style="display:none;">
		  <div class="biaot">
		  <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;选择自制商品</h1><h2><a href="javascript:closeDiv1()"><img src="../images/fenlei/dialog_closebtn.gif" alt="CPU"  onmouseover="this.src='images/fenlei/dialog_closebtn_over.gif'" onmouseout="this.src='images/fenlei/dialog_closebtn.gif'" align="right" /></a>&nbsp;&nbsp;&nbsp;</h2>
		  <div class="js1 zhong">
		 <table width="100%" border="0" align="left" cellpadding="5" cellspacing="1">
		 <tr class="a2875d3">
		 <td align="center" style="padding:5px;">选择商品图片</td>
		 <td width="20%">商品名称</td>
         </tr>
		  <asp:Repeater ID="Repeater2" runat="server" onitemcommand="Repeater2_ItemCommand">
             <ItemTemplate>
			<tr>
			<td align="center"><asp:LinkButton ID="LinkButton1" CommandName="adds" CommandArgument='<%#Eval("id") %>' runat="server"><img width="160" height="90" src="<%# Eval("Photourl") %>" alt=""  style=" margin:5px;"/></asp:LinkButton></td>
            <td align="center"><%# Eval("Name")%></td>
            			</tr>
             </ItemTemplate>
            </asp:Repeater>
		 </table>
		  </div>
		  </div>
</div>

<!--形状选择 -->
<div id="popDiv2" class="mydiv" style="display:none;">
		  <div class="biaot">
		  <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;选择图片<asp:Label ID="Label2" runat="server" Text=""></asp:Label></h1><h2><a href="javascript:closeDiv2()"><img src="../images/fenlei/dialog_closebtn.gif" alt="CPU"  onmouseover="this.src='../images/fenlei/dialog_closebtn_over.gif'" onmouseout="this.src='images/fenlei/dialog_closebtn.gif'" align="right" /></a>&nbsp;&nbsp;&nbsp;</h2>
		  <div class="js1 zhong">
		   <table width="100%" border="0" align="left" cellpadding="5" cellspacing="1">
		   <tr>
		       <td align="center" style="padding:5px;">选择商品图片</td>
           </tr>
            <asp:Repeater ID="Repeater1" runat="server" onitemcommand="Repeater1_ItemCommand">
             <ItemTemplate>
			<tr>

			<td align="center"><asp:LinkButton ID="LinkButton1" CommandName="add" CommandArgument='<%#Eval("id") %>' runat="server"><img width="160" height="90" src="<%# Eval("Photourl") %>" alt=""  style=" margin:5px;"/></asp:LinkButton></td>
  
            			</tr>
             </ItemTemplate>
            </asp:Repeater>
		   </table>
		
		  </div>
		  </div>
</div>
 <%--  外购商品--%>
   <div id="popDiv3" class="mydiv" style="display:none;">
		  <div class="biaot">
		  <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;选择外购商品<asp:Label ID="Label3" runat="server" Text=""></asp:Label></h1><h2><a href="javascript:closeDiv3()"><img src="../images/fenlei/dialog_closebtn.gif" alt="CPU"  onmouseover="this.src='../images/fenlei/dialog_closebtn_over.gif'" onmouseout="this.src='../images/fenlei/dialog_closebtn.gif'" align="right" /></a>&nbsp;&nbsp;&nbsp;</h2>
		  <div class="js1 zhong">
		    <table width="100%" border="0" align="left" cellpadding="0" cellspacing="0">
		 
		 <tr class="a2875d3">
		        <td width="15%">商品型号</td>
		 </tr>
		 <asp:Repeater ID="Repeater3" runat="server" onitemcommand="Repeater3_ItemCommand">
             <ItemTemplate>
			<tr>
			<td align="center"><asp:LinkButton ID="LinkButton1" CommandName="add" CommandArgument='<%#Eval("id") %>' runat="server"><%#Eval("Name")%></asp:LinkButton></td>
            			</tr>
             </ItemTemplate>
            </asp:Repeater>
		 </table>
		  </div>
		  </div>
</div>

	<div id="tt" class="easyui-tabs" >
    
<table width="96%"  align="left" cellpadding="0" cellspacing="1">
  <tr>
    <td height="33" colspan="3" class="tabaa"><img src="../images/bianti_jiao.jpg" alt="CPU" width="34" height="33" align="left" /><span class="biaoti1">单据修改</span></td>
  </tr>
   <tr>
    <td height="50" colspan="3" align="left" valign="middle" ><span class="y" style="padding-right:20px;">定单编号：<asp:Label ID="Label1" runat="server" Text=""></asp:Label></span></td>
  </tr>
 <tr>
 <td width="60%" style="padding:10px;">
 <asp:ImageButton ID="ImageButton1" runat="server" Height="180" Width="20%" onclick="ImageButton1_Click" />&nbsp;
 <asp:ImageButton ID="ImageButton2" runat="server" Height="180" Width="20%" onclick="ImageButton2_Click"/>&nbsp;
 <asp:ImageButton ID="ImageButton3" runat="server" Height="180" Width="20%" onclick="ImageButton3_Click"/>&nbsp;
 <asp:ImageButton ID="ImageButton4" runat="server" Height="180" Width="20%" onclick="ImageButton4_Click"/><br />
 </td>
<td width="15%" valign="middle" >
     &nbsp;选择型号：<asp:ImageButton ID="ImageButton5" runat="server" Height="80px" Width="120px" onclick="ImageButton5_Click" /><br />
&nbsp;总&nbsp;&nbsp;长：<asp:TextBox ID="TextBox1" runat="server" Width="120px"></asp:TextBox><br /><br />
&nbsp;妃&nbsp;&nbsp;长：<asp:TextBox ID="TextBox2" runat="server" Width="120px"></asp:TextBox><br /><br />
&nbsp;前 后 宽：<asp:TextBox ID="TextBox3" runat="server" Width="120px"></asp:TextBox></td>
 <td width="25%" valign="middle" >
&nbsp;餐&nbsp;&nbsp;桌：&nbsp; <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
     <asp:LinkButton ID="LinkButton2" runat="server" ForeColor="#0066FF"  onclick="LinkButton2_Click">选择弹框</asp:LinkButton><br /><br />
&nbsp;餐&nbsp;&nbsp;椅：&nbsp; <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
     <asp:LinkButton ID="LinkButton3" runat="server" ForeColor="#0066FF"  onclick="LinkButton3_Click">选择弹框</asp:LinkButton><br /><br />
&nbsp;茶&nbsp;&nbsp;几：&nbsp; <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
     <asp:LinkButton ID="LinkButton4" runat="server" ForeColor="#0066FF"  onclick="LinkButton4_Click">选择弹框</asp:LinkButton><br /><br />
&nbsp;电 视 柜：&nbsp; <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
     <asp:LinkButton ID="LinkButton5" runat="server" ForeColor="#0066FF"  onclick="LinkButton5_Click">选择弹框</asp:LinkButton><br /><br />
&nbsp;&nbsp; 床&nbsp; ：&nbsp; <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
     <asp:LinkButton ID="LinkButton6" runat="server" ForeColor="#0066FF"  onclick="LinkButton6_Click">选择弹框</asp:LinkButton><br /><br />
&nbsp;床&nbsp;&nbsp;垫：&nbsp; <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
     <asp:LinkButton ID="LinkButton7" runat="server" ForeColor="#0066FF"  onclick="LinkButton7_Click">选择弹框</asp:LinkButton><br /><br />
&nbsp;床 头 柜：&nbsp; <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
     <asp:LinkButton ID="LinkButton8" runat="server" ForeColor="#0066FF"  onclick="LinkButton8_Click">选择弹框</asp:LinkButton><br /><br />
</td>
 </tr>
 <tr><td style="padding:10px;">
     自制商品备注：<br />
<br />
     <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine" Width="95%" Height="150px"></asp:TextBox>
 </td>
 <td colspan="2" style="padding:10px;">
     外购商品备注：<br />
<br />
<asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine" Width="95%" Height="150px"></asp:TextBox>
 </td>
 </tr>
 <tr>
    <td colspan="2" style="padding:10px;">客户姓名：<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>&nbsp; 电话1：<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>&nbsp; 电话2：<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox><br /><br />客户地址：<asp:TextBox ID="TextBox10" runat="server" Width="60%"></asp:TextBox></td>
    <td rowspan="2" style="padding:10px;">&nbsp;赠品：<asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine" Width="95%" Height="150px"></asp:TextBox></td>
 </tr>
 <tr>
 <td colspan="2" style="padding:10px;">送货日期：<asp:TextBox ID="TextBox11" runat="server" onClick="laydate()" ></asp:TextBox>&nbsp;总金额：<asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>&nbsp;
     已付款：<asp:Label ID="Label4" runat="server" Text=""></asp:Label>&nbsp;</td>
 </tr>
  <tr class="a2875d3">
    <td height="50" colspan="3"align="center" valign="middle" style=" padding:5px;" >
        <asp:Button ID="Button1" runat="server" Text="修改单据" onclick="Button1_Click" /></td>
  </tr>
  </table>
	</div>

    </form>
</body>
</html>