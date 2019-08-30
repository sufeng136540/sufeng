<%@ Page Title="Member" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.Member.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="id" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="MemberName" HeaderText="MemberName" SortExpression="MemberName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MemberPhone" HeaderText="MemberPhone" SortExpression="MemberPhone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MemberPhone1" HeaderText="MemberPhone1" SortExpression="MemberPhone1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Integral" HeaderText="Integral" SortExpression="Integral" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="address" HeaderText="address" SortExpression="address" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Beizhu" HeaderText="Beizhu" SortExpression="Beizhu" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BY1" HeaderText="BY1" SortExpression="BY1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BY2" HeaderText="BY2" SortExpression="BY2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BY3" HeaderText="BY3" SortExpression="BY3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BY4" HeaderText="BY4" SortExpression="BY4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BY5" HeaderText="BY5" SortExpression="BY5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BY6" HeaderText="BY6" SortExpression="BY6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BY7" HeaderText="BY7" SortExpression="BY7" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="id" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="id" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
