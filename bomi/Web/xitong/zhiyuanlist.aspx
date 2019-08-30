<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zhiyuanlist.aspx.cs" Inherits="Maticsoft.Web.xitong.zhiyuanlist" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>部门信息</title>
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
		  <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;添加职员</h1><h2><a href="javascript:closeDiv1()"><img src="../images/fenlei/dialog_closebtn.gif" alt="CPU"  onmouseover="this.src='../images/fenlei/dialog_closebtn_over.gif'" onmouseout="this.src='../images/fenlei/dialog_closebtn.gif'" align="right" /></a>&nbsp;&nbsp;&nbsp;</h2>
		  <div class="js1 zhong">
		 <table width="98%" border="0" cellpadding="0" cellspacing="1">
		 <tr class="a2875d3">
		     <td width="10%">职员名称:</td>
		     <td width="60%"><asp:TextBox ID="TextBox1" runat="server" Width="95%"></asp:TextBox></td>
		 </tr>
         <tr class="a2875d3">
		     <td width="10%">联系方式:</td>
		     <td width="60%"><asp:TextBox ID="TextBox6" runat="server" Width="95%"></asp:TextBox></td>
		 </tr>
         <tr class="a2875d3">
		     <td width="10%">部门:</td>
		     <td width="60%"><asp:DropDownList ID="DropDownList1" runat="server" Width="95%"></asp:DropDownList></td>
		 </tr>
          <tr class="a2875d3">
		     <td width="10%">职务:</td>
		     <td width="60%"><asp:DropDownList ID="DropDownList2" runat="server" Width="95%"></asp:DropDownList></td>
		 </tr>
		 <tr class="a2875d3">
		     <td width="10%">备注:</td>
		     <td width="60%"><asp:TextBox ID="TextBox2" runat="server" Width="95%" TextMode="MultiLine" Height="100px"></asp:TextBox></td>
		 </tr>
		 </table>
		  </div>
		  <p><a href="javascript:closeDiv1()">
          <asp:ImageButton ID="ImageButton1" runat="server" onclick="ImageButton1_Click" src="../images/fenlei/queren.jpg" />
          </a></p>
		  </div>
</div>
    <div id="popDiv2" class="mydiv" style="display:none;">
		  <div class="biaot">
		  <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;修改职员</h1><h2><a href="javascript:closeDiv2()"><img src="../images/fenlei/dialog_closebtn.gif" alt="CPU"  onmouseover="this.src='../images/fenlei/dialog_closebtn_over.gif'" onmouseout="this.src='../images/fenlei/dialog_closebtn.gif'" align="right" /></a>&nbsp;&nbsp;&nbsp;</h2>
		  <div class="js1 zhong">
		 <table width="98%" border="0" cellpadding="0" cellspacing="1">
           <tr class="a2875d3">
		     <td width="10%">职员名称:</td>
		     <td width="60%"><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
		 </tr>
          <tr class="a2875d3">
		     <td width="10%">职员名称:</td>
		     <td width="60%"><asp:TextBox ID="TextBox4" runat="server" Width="95%"></asp:TextBox></td>
		 </tr>
         <tr class="a2875d3">
		     <td width="10%">联系方式:</td>
		     <td width="60%"><asp:TextBox ID="TextBox5" runat="server" Width="95%"></asp:TextBox></td>
		 </tr>
         <tr class="a2875d3">
		     <td width="10%">部门:</td>
		     <td width="60%"><asp:DropDownList ID="DropDownList3" runat="server" Width="95%"></asp:DropDownList></td>
		 </tr>
          <tr class="a2875d3">
		     <td width="10%">职务:</td>
		     <td width="60%"><asp:DropDownList ID="DropDownList4" runat="server" Width="95%"></asp:DropDownList></td>
		 </tr>
		 <tr class="a2875d3">
		     <td width="10%">备注:</td>
		     <td width="60%"><asp:TextBox ID="TextBox7" runat="server" Width="95%" TextMode="MultiLine" Height="100px"></asp:TextBox></td>
		 </tr>
		 </table>
		  </div>
		  <p><a href="javascript:closeDiv2()">
          <asp:ImageButton ID="ImageButton2" runat="server" onclick="ImageButton2_Click" src="../images/fenlei/queren.jpg" />
          </a></p>
		  </div>
</div>

	<div id="tt" class="easyui-tabs" >
    <div id="container">
<table width="98%" border="0" align="left" cellpadding="0" cellspacing="1">
  <tr>
    <td height="33" colspan="7" class="tabaa"><asp:Image ID="Image1" runat="server" src="../images/bianti_jiao.jpg" width="34" height="33" align="left" /><span class="biaoti1">职员信息</span></td>
  </tr>
    
  <tr>
  <td height="33" colspan="7" align="left"  > &nbsp;&nbsp; 职员名称：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;
  <asp:Button ID="Button1" runat="server" Text="查  询" onclick="Button1_Click" /></td>
  </tr>
  <tr class="a2875d3">
    <td width="5%" height="30" align="center">编号</td>
    <td width="10%" align="center">职员名称</td>
    <td width="10%" align="center">联系方式</td>
    <td width="10%" align="center">部门</td>
    <td width="10%" align="center">职务</td>
	<td width="45%" align="center">备注</td>
    <td width="10%" height="30" align="center"><asp:LinkButton ID="LinkButton3" runat="server" ForeColor="Red" onclick="LinkButton3_Click">添加职员</asp:LinkButton></td>
	 </tr>
          <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
	   <tr>
            <td  align="center" height="30"><%# Eval("shu")%></td>
            <td  align="center"><%# Eval("Staffname")%></td>
            <td  align="center"><%# Eval("information")%></td>
            <td  align="center"><%# Eval("departmentname")%></td>
            <td  align="center"><%# Eval("name")%></td>
	        <td  align="center"><%# Eval("beizhu")%></td>
            <td align="center">
              <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="#0066FF" CommandArgument='<%# Eval("id") %>' onclick="LinkButton1_Click" >修改</asp:LinkButton>
              <asp:LinkButton ID="LinkButton2" runat="server" ForeColor="#0066FF" CommandArgument='<%# Eval("id") %>' onclick="LinkButton2_Click" OnInit="lbtnDelete_Init">删除</asp:LinkButton>
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