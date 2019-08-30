<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="waigouchanpin.aspx.cs" Inherits="Maticsoft.Web.chanpin.waigouchanpin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>外购商品列表</title>
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
     function PreView(sender, preViewImgId) {
         document.getElementById(preViewImgId).src = window.URL.createObjectURL(sender.files[0]);
     } 
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="popDiv1" class="mydiv" style="display:none;">
		  <div class="biaot">
		  <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;添加外购产品</h1><h2><a href="javascript:closeDiv1()"><img src="../images/fenlei/dialog_closebtn.gif" alt="CPU"  onmouseover="this.src='../images/fenlei/dialog_closebtn_over.gif'" onmouseout="this.src='../images/fenlei/dialog_closebtn.gif'" align="right" /></a>&nbsp;&nbsp;&nbsp;</h2>
		  <div class="js1 zhong">
		 <table width="98%" border="0" cellpadding="0" cellspacing="1">
        <%-- <tr class="a2875d3">
		     <td width="10%">上传图片:</td>
		     <td width="60%" align="left"><asp:Image ID="PreViewImg" runat="server" Width="120" Height="80" AlternateText="图片预览" BorderWidth="1" />
             <asp:FileUpload ID="FileUpload1" runat="server" onchange="PreView(this,'PreViewImg');" Width="200" />
                 </td>
		 </tr>--%>
          <tr class="a2875d3">
		     <td width="10%">产品类别:</td>
		     <td width="60%"><asp:ListBox ID="ListBox1" runat="server" Rows="1" Width="95%">
                            <asp:ListItem Value="0">请选择</asp:ListItem>
                            <asp:ListItem Value="1">餐  桌</asp:ListItem>
                            <asp:ListItem Value="2">餐  椅</asp:ListItem>
                            <asp:ListItem Value="3">茶  几</asp:ListItem>
                            <asp:ListItem Value="4">电视柜</asp:ListItem>
                            <asp:ListItem Value="5">  床  </asp:ListItem>
                            <asp:ListItem Value="6">床  垫</asp:ListItem>
                            <asp:ListItem Value="7">床头柜</asp:ListItem>
                 </asp:ListBox></td>
		 </tr>
		 <tr class="a2875d3">
		     <td width="10%">产品名称:</td>
		     <td width="60%"><asp:TextBox ID="TextBox1" runat="server" Width="95%"></asp:TextBox></td>
		 </tr>
         <%-- <tr class="a2875d3">
		     <td width="10%">说明:</td>
		     <td width="60%">
                 <asp:TextBox ID="TextBox6" runat="server" Width="95%" 
                     TextMode="MultiLine" Height="100px"></asp:TextBox></td>
		 </tr>--%>
		 <tr class="a2875d3">
		     <td width="10%">备注:</td>
		     <td width="60%">
                 <asp:TextBox ID="TextBox2" runat="server" Width="95%" 
                     TextMode="MultiLine" Height="100px"></asp:TextBox></td>
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
		  <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;修改外购商品</h1><h2><a href="javascript:closeDiv2()"><img src="../images/fenlei/dialog_closebtn.gif" alt="CPU"  onmouseover="this.src='../images/fenlei/dialog_closebtn_over.gif'" onmouseout="this.src='../images/fenlei/dialog_closebtn.gif'" align="right" /></a>&nbsp;&nbsp;&nbsp;</h2>
		  <div class="js1 zhong">
		 <table width="98%" border="0" cellpadding="0" cellspacing="1">
          <tr class="a2875d3">
		     <td width="10%">产品ID:</td>
		     <td width="60%"><asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
		 </tr>
          <tr class="a2875d3">
		     <td width="10%">产品类别:</td>
		     <td width="60%"><asp:ListBox ID="ListBox2" runat="server" Rows="1" Width="95%">
                            <asp:ListItem Value="0">请选择</asp:ListItem>
                            <asp:ListItem Value="1">餐  桌</asp:ListItem>
                            <asp:ListItem Value="2">餐  椅</asp:ListItem>
                            <asp:ListItem Value="3">茶  几</asp:ListItem>
                            <asp:ListItem Value="4">电视柜</asp:ListItem>
                            <asp:ListItem Value="5">  床  </asp:ListItem>
                            <asp:ListItem Value="6">床  垫</asp:ListItem>
                            <asp:ListItem Value="7">床头柜</asp:ListItem>
                 </asp:ListBox></td>
		 </tr>
         <%-- <tr class="a2875d3">
		     <td width="10%">上传图片:</td>
		     <td width="60%" align="left"><asp:Image ID="Image2" runat="server" Width="120" Height="80" AlternateText="图片预览" BorderWidth="1" />
             <asp:FileUpload ID="FileUpload2" runat="server" onchange="PreView(this,'Image2');" Width="200" />
                 </td>
		 </tr>--%>
		 <tr class="a2875d3">
		     <td width="10%">产品名称:</td>
		     <td width="60%"><asp:TextBox ID="TextBox4" runat="server" Width="95%"></asp:TextBox></td>
		 </tr>
        <%--  <tr class="a2875d3">
		     <td width="10%">说明:</td>
		     <td width="60%">
                 <asp:TextBox ID="TextBox5" runat="server" Width="95%" 
                     TextMode="MultiLine" Height="100px"></asp:TextBox></td>
		 </tr>--%>
		 <tr class="a2875d3">
		     <td width="10%">备注:</td>
		     <td width="60%">
                 <asp:TextBox ID="TextBox7" runat="server" Width="95%" 
                     TextMode="MultiLine" Height="100px"></asp:TextBox></td>
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
    <td height="33" colspan="5" class="tabaa"><asp:Image ID="Image1" runat="server" src="../images/bianti_jiao.jpg" width="34" height="33" align="left" /><span class="biaoti1">外购商品信息</span></td>
  </tr>
    
  <tr>
  <td height="33" colspan="5" align="left"  > &nbsp;&nbsp; 外购商品名称：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;
  <asp:Button ID="Button1" runat="server" Text="查  询" onclick="Button1_Click" /></td>
  </tr>
  <tr class="a2875d3">
    <td width="5%" height="30" align="center">编号</td>
    <td width="10%" align="center">商品类别</td>
    <td width="15%" align="center">商品名称</td>
	<td width="60%" align="center">备注</td>
    <td width="10%" height="30" align="center"><asp:LinkButton ID="LinkButton3" runat="server" ForeColor="Red" onclick="LinkButton3_Click">添加外购商品</asp:LinkButton></td>
	 </tr>
          <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
	   <tr>
            <td  align="center" height="30"><%# Eval("shu")%></td>
           <%-- <td  align="center"><img width="160" height="90" src="<%# Eval("Photourl") %>"  alt="" onmouseover="this.width='320'; this.height='180';" onmouseout="this.width='160'; this.height='90'"  style=" margin:5px;"/></td>--%>
            <td  align="center"><%# Eval("category")%></td>
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
