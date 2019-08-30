<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Maticsoft.Web.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>博米家居</title>
<link rel="stylesheet" href="css/font-awesome.min.css" />
<link href="css/css.css" rel="stylesheet" type="text/css" />
<link rel="stylesheet" type="text/css" href="css/easyui.css" />
<link rel="stylesheet" type="text/css" href="css/icon.css" />
<script type="text/javascript" src="js/jquery1.42.min.js"></script><script type="text/javascript" src="js/jquery.SuperSlide.2.1.1.js"></script>
<script type="text/javascript" src="js/jquery.easyui.min.js"></script>
	<script>
	    function addTab(title, url) {
	        if ($('#tt').tabs('exists', title)) {
	            $('#tt').tabs('select', title);
	        } else {
	            var content = '<iframe scrolling="auto" frameborder="0"  src="' + url + '" style="width:100%;height:100%;"></iframe>';
	            $('#tt').tabs('add', {
	                title: title,
	                content: content,
	                closable: true
	            });
	        }
	    }
	</script>

</head>
<body>
<div class="w10 top"><div style="width:298px;" class="z"></div><div class="y topa"><asp:Label ID="Label1" runat="server" Text=""></asp:Label>&nbsp;&nbsp;<a href="login.aspx">退出登录</a>&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" ></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;</div></div>

<div class="ce1">
<div class="ce">


<div class="sideMenu" style="margin:0 auto">
			<h3 style=" color:#fff;font-size:17px; font-weight:bold; font-family:'微软雅黑';letter-spacing: 5px; " >&nbsp;<i class="fa fa-map" style="width:30px;"></i>单据录入</h3>
			<ul>
			<li style="display: none;"><a id="tishi"  href="#" onclick="addTab('欢迎','huanying.aspx')">欢迎登陆</a></li>
            <li><a href="#" onclick="addTab('单据录入','danju/danjuluru.aspx')"><i class="fa fa-edit" style="width:20px;"></i>单据录入</a></li>
			    <li><a  href="#" onclick="addTab('工厂订单列表','danju/gongchangdanjulist.aspx')"><i class="fa fa-map-o" style="width:20px;"></i>工厂单据列表</a></li>
                <li><a  href="#" onclick="addTab('职员单据列表','danju/zhiyuandanjulist.aspx')"><i class="fa fa-map-o" style="width:20px;"></i>职员单据列表</a></li>
			</ul>
			<h3 style=" color:#fff;font-size:17px; font-weight:bold; font-family:'微软雅黑';letter-spacing: 5px; " >&nbsp;<i class="fa fa-send" style="width:30px;"></i>信息相关</h3>
			<ul>
			<li><a href="#" onclick="addTab('图片表','xinxi/tupian.aspx')"><i class="fa fa-user-circle-o" style="width:20px;"></i>图片表</a></li>
				<li><a href="#" onclick="addTab('完成单据','danju/wanchengdanju.aspx')"><i class="fa fa-user-plus" style="width:20px;"></i>完成单据</a></li>
				<li><a href="#" onclick="addTab('往来账目','xinxi/wanglaizhang.aspx')"><i class="fa fa-credit-card-alt" style="width:20px;"></i>往来账目</a></li>
			</ul>
			<h3 style=" color:#fff;font-size:17px; font-weight:bold; font-family:'微软雅黑';letter-spacing: 5px; " >&nbsp;<i class="fa fa-area-chart" style="width:30px;"></i>产品列表</h3>
			<ul>
			<li><a href="#" onclick="addTab('自制商品','chanpin/zizhichanpin.aspx')"><i class="fa fa-sitemap" style="width:20px;"></i>自制商品</a></li>
			<li><a href="#" onclick="addTab('外购商品','chanpin/waigouchanpin.aspx')"><i class="fa fa-truck" style="width:20px;"></i>外购商品</a></li>
			</ul>
			<script type="text/javascript">
			    setTimeout(function () {
			        // IE
			        if (document.all) {
			            document.getElementById("tishi").click();
			        }
			        // 其它浏览器
			        else {
			            var e = document.createEvent("MouseEvents");
			            e.initEvent("click", true, true);
			            document.getElementById("tishi").dispatchEvent(e);
			        }
			    }, 200);
</script>
			
			<h3 style=" color:#fff;font-size:17px; font-weight:bold; font-family:'微软雅黑';letter-spacing: 5px; " >&nbsp;<i class="fa fa-cog" style="width:30px;"></i>系统设置</h3>
			<ul>
			    <li><a href="#" onClick="addTab('操作员管理','xitong/caozuoyuanlist.aspx')"><i class="fa fa-user" style="width:20px;"></i>操作员管理</a></li>
			    <li><a href="#" onClick="addTab('职员列表','xitong/zhiyuanlist.aspx')"><i class="fa fa-id-card" style="width:20px;"></i>职员列表</a></li>
				<li><a href="#" onClick="addTab('部门信息','xitong/bumenlist.aspx')"><i class="fa fa-institution" style="width:20px;"></i>部门信息</a></li>
				<li><a href="#" onClick="addTab('职务信息','xitong/zhiwulist.aspx')"><i class="fa fa-graduation-cap" style="width:20px;"></i>职务信息</a></li>
			</ul>

</div>
</div></div>
			<script type="text/javascript">
			    var ary = location.href.split("&");
			    jQuery(".sideMenu").slide({ titCell: "h3", targetCell: "ul", effect: ary[1], delayTime: ary[2], trigger: ary[3], triggerTime: ary[4], defaultPlay: false, returnDefault: ary[6], easing: ary[7] });
		</script>
 <div id="center">
	<div id="tt"  fit="true" class="easyui-tabs y">
   </div>
  </div>
		<div class="w10 footer">版权所有：博米家居&nbsp;&nbsp;&nbsp;&nbsp;博米家居ERP V1.0&nbsp;&nbsp;&nbsp;&nbsp;浏览需求：1920*1080分辨率</div>
		

</body>
</html>
