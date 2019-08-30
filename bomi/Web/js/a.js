// JavaScript Document
function addTab(title, url){
			if (parent.$('#tt').tabs('exists', title)){
				parent.$('#tt').tabs('select', title);
			} else {
				var content = '<iframe scrolling="auto" frameborder="0"  src="'+url+'" style="width:100%;height:100%;"></iframe>';
				parent.$('#tt').tabs('add',{
					title:title,
					content:content,
					closable:true
				});
			}
		}