<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Maticsoft.Web.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>登录</title>
<link href="css/css.css" rel="stylesheet" type="text/css" />

</head>
<body style="background-image: url(images/loginbg.jpg);background-repeat: no-repeat;background-position: center top;">
<form id="Form1" runat="server">
<div id="login">

<div id="dl">
	<ul>
		<li>用户名：
<input class="input_yhm" type="text" name="uname" id="uname" style="height:26px" runat="server" /><br/></li>
		<li>密&nbsp;&nbsp;&nbsp;码：
<input class="input_mm" type="password" name="pwd" id="pwd" style="height:26px" runat="server" /></li>
		<li class="an"><a href="index.aspx"><asp:ImageButton ID="ImageButton1" runat="server" src="images/dl.jpg" onclick="ImageButton1_Click" /></a>&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton2" runat="server" src="images/cz.jpg" onclick="ImageButton2_Click" />
                </li>
        <li class="bq" style="color:#EEE;">版权所有：博米家ERP系统 V1.0</li>
	</ul>
</div>
</div>
</form>
</body>
</html>
