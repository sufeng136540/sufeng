<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gongchangdanjuselect.aspx.cs" Inherits="Maticsoft.Web.danju.kufangdanjuselect" %>

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
   <div id="popDiv3" class="mydiv" style="display:none;">
		  <div class="biaot">
		  <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;技术人员</h1><h2><a href="javascript:closeDiv3()"><img src="../images/fenlei/dialog_closebtn.gif" alt="CPU"  onmouseover="this.src='../images/fenlei/dialog_closebtn_over.gif'" onmouseout="this.src='../images/fenlei/dialog_closebtn.gif'" align="right" /></a>&nbsp;&nbsp;&nbsp;</h2>
		  <div class="js1 zhong">
		    <table width="100%" border="0" align="left" cellpadding="0" cellspacing="0">
		 
		 <tr class="a2875d3">
		 <td width="5%">&nbsp;</td>
		 <td width="15%">职员编号</td>
		 <td width="15%">姓名</td>
		 <td width="20%">联系方式</td>
	     <td width="20%">所属部门</td>
		 <td width="20%">职务</td>
		 </tr>
		  <tr>
		 <td width="5%" align="center"><input name="" type="radio" value="" /></td>
		 <td width="15%" align="center">123456789</td>
		 <td width="15%" align="center">王某某</td>
		 <td width="20%" align="center">13999999999</td>
		 <td width="20%" align="center">技术部</td>
		 <td width="20%" align="center">安装工人</td>
		 </tr>
		  
		<tr>
		 <td width="5%" align="center"><input name="" type="radio" value="" /></td>
		 <td width="15%" align="center">123456789</td>
		 <td width="15%" align="center">王某某</td>
		 <td width="20%" align="center">13999999999</td>
		 <td width="20%" align="center">技术部</td>
		 <td width="20%" align="center">安装工人</td>
		 </tr>
		 <tr>
		 <td width="5%" align="center"><input name="" type="radio" value="" /></td>
		 <td width="15%" align="center">123456789</td>
		 <td width="15%" align="center">王某某</td>
		 <td width="20%" align="center">13999999999</td>
		 <td width="20%" align="center">技术部</td>
		 <td width="20%" align="center">安装工人</td>
		 </tr>  
		 </table>
		  </div>
		  <p><a href="javascript:closeDiv3()"><img src="images/fenlei/queren.jpg" /></a></p>
		  </div>
</div>

<div id="popDiv1" class="mydiv" style="display:none;">
		  <div class="biaot">
		  <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;选择客户</h1><h2><a href="javascript:closeDiv1()"><img src="../images/fenlei/dialog_closebtn.gif" alt="CPU"  onmouseover="this.src='images/fenlei/dialog_closebtn_over.gif'" onmouseout="this.src='images/fenlei/dialog_closebtn.gif'" align="right" /></a>&nbsp;&nbsp;&nbsp;</h2>
		  <div class="js1 zhong">
		   <table width="100%" border="0"  cellpadding="0" cellspacing="0">
		   <tr><td><input type="text" value="查找客户" onfocus="if (value =='查找客户'){value =''}"onblur="if (value ==''){value='查找客户'}" />&nbsp;&nbsp;<input name="" type="submit" value="搜索" /></td></tr>
		   </table>
		 <table width="100%" border="0" cellpadding="0" cellspacing="1">
		 <tr class="a2875d3">
		 <td width="10%">&nbsp;</td>
		 <td width="20%">姓名</td>
		 <td width="20%">电话1</td>
		  <td width="20%">电话2</td>
		
		 </tr>
		  <tr>
		 <td width="10%" align="center"><input name="" type="radio" value="" /></td>
		 <td  align="center">王某某</td>
		 <td width="20%" align="center">0421978888</td>
<td width="20%" align="center">0421978888</td>
		 </tr>
		   <tr>
		 <td  colspan="5" width="10%">&nbsp;&nbsp;吉林省长春市二十家子大枣真好吃5段141号</td>
		 </tr>
		 </table>
		  </div>
		  <p><a href="javascript:closeDiv1()"><img src="../images/fenlei/queren.jpg" /></a></p>
		  </div>
</div>

<!--客户详细资料 -->
<%--<div id="popDiv2" class="mydiv" style="display:none;">
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
</div>--%>
<div id="popDiv5" class="mydiv" style="display:none;">
		  <div class="biaot">
		  <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;延时申请详情</h1><h2><a href="javascript:closeDiv5()"><img src="../images/fenlei/dialog_closebtn.gif" alt="CPU"  onmouseover="this.src='images/fenlei/dialog_closebtn_over.gif'" onmouseout="this.src='../images/fenlei/dialog_closebtn.gif'" align="right" /></a>&nbsp;&nbsp;&nbsp;</h2>
		  <div class="js1 zhong">
		   <table width="100%" border="0" align="left" cellpadding="5" cellspacing="0">
		   <tr><td style="padding:5px;">
		   延时理由：<br />
		   因为客户不在家出门去很多很远的撒带回来卡萨丁爱睡懒觉肯定会卢卡斯，阿萨德离开就好了阿萨德离开就好了卡萨奥斯卡接电话阿萨德哈伦裤个有SEI噢去我去哦无儿请我IE尀
		   </td></tr>
            <tr><td style="padding:5px;">
		   延时时长（小时）：<br />
		   <span style="color:#FF0000;">3 小时</span>
		   </td></tr>
		   </table>
		
		  </div>
		  <p><a href="javascript:closeDiv5()"><img src="../images/ty.png" /></a>&nbsp;&nbsp;&nbsp;&nbsp;<a href="javascript:closeDiv5()"><img src="../images/jj.png" /></a></p>
		  </div>
</div>

	<div id="tt" class="easyui-tabs" >
    
<table width="96%"  align="left" cellpadding="0" cellspacing="1">
  <tr>
    <td height="33" colspan="2" class="tabaa"><img src="../images/bianti_jiao.jpg" alt="CPU" width="34" height="33" align="left" /><span class="biaoti1">工厂单据详情</span></td>
  </tr>
   <tr>
    <td height="50" colspan="2" align="left" valign="middle" ><span class="y" style="padding-right:20px;">定单编号：<asp:Label ID="Label1" runat="server" Text=""></asp:Label></span></td>
  </tr>
 <tr>
     <td width="60%" style="padding:10px;">
     <asp:ImageButton ID="ImageButton1" runat="server" Height="180" Width="20%" />&nbsp;
     <asp:ImageButton ID="ImageButton2" runat="server" Height="180" Width="20%" />&nbsp;
     <asp:ImageButton ID="ImageButton3" runat="server" Height="180" Width="20%" />&nbsp;
     <asp:ImageButton ID="ImageButton4" runat="server" Height="180" Width="20%" /><br />
     </td>
     <td width="15%" valign="middle" >
      &nbsp;选择型号：<asp:ImageButton ID="ImageButton5" runat="server" Height="100px" Width="160px" /><br />
    &nbsp;总&nbsp;&nbsp;长：&nbsp; 
         <asp:Label ID="Label3" runat="server"></asp:Label>
         <br /><br />
    &nbsp;妃&nbsp;&nbsp;长：&nbsp; 
         <asp:Label ID="Label4" runat="server"></asp:Label><br /><br />
    &nbsp;前 后 宽：&nbsp; 
         <asp:Label ID="Label5" runat="server"></asp:Label></td>
 </tr>
 <tr><td style="padding:10px;" >
     自制商品备注：<br />
<br />
     <asp:Label ID="Label6" runat="server" Height="150px"></asp:Label>
 </td>
 <td  style="padding:10px;">
     赠品：<br />
     <br />
     <asp:Label ID="Label7" runat="server" Height="150px"></asp:Label>
<br />
 </td>
 </tr>
 <tr>
    <td colspan="2" style="padding:10px;">客户姓名：&nbsp;<asp:Label ID="Label8" 
            runat="server"></asp:Label>
&nbsp;电话1：<asp:Label ID="Label9" runat="server"></asp:Label>
        &nbsp; 电话2：<asp:Label ID="Label10" runat="server"></asp:Label>
        <br /><br />客户地址：<asp:Label ID="Label11" runat="server"></asp:Label>
     </td>
 </tr>
 <tr>
 <td colspan="2" style="padding:10px;">送货日期：<asp:Label ID="Label12" runat="server"></asp:Label>
     &nbsp;总金额：<asp:Label ID="Label13" runat="server"></asp:Label>
     &nbsp;
     已付款：<asp:Label ID="Label14" runat="server"></asp:Label>
     &nbsp; 付款状态：<asp:Label ID="Label15" runat="server"></asp:Label>
     </td>
 </tr>
  <tr class="a2875d3">
    <td height="50" colspan="2"align="center" valign="middle" style=" padding:5px;" >
        <asp:Button ID="Button1" runat="server" Text="返  回" onclick="Button1_Click" /></td>
  </tr>
  </table>
	</div>

    </form>
</body>
</html>
