<%@ Page Title="OrderTab" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.OrderTab.List" %>
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
                            
		<asp:BoundField DataField="MemberID" HeaderText="MemberID" SortExpression="MemberID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MemberName" HeaderText="MemberName" SortExpression="MemberName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MemberPhone" HeaderText="MemberPhone" SortExpression="MemberPhone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MemberPhone1" HeaderText="MemberPhone1" SortExpression="MemberPhone1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MemberAdd" HeaderText="MemberAdd" SortExpression="MemberAdd" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Orderdate" HeaderText="Orderdate" SortExpression="Orderdate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OrderNumber" HeaderText="OrderNumber" SortExpression="OrderNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="StaffmemberID" HeaderText="StaffmemberID" SortExpression="StaffmemberID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Staffmembername" HeaderText="Staffmembername" SortExpression="Staffmembername" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UserTabID" HeaderText="UserTabID" SortExpression="UserTabID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PhotoID" HeaderText="PhotoID" SortExpression="PhotoID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="validity" HeaderText="validity" SortExpression="validity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="progress" HeaderText="progress" SortExpression="progress" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Deposit" HeaderText="Deposit" SortExpression="Deposit" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AllMoney" HeaderText="AllMoney" SortExpression="AllMoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="alllength" HeaderText="alllength" SortExpression="alllength" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Imperial" HeaderText="Imperial" SortExpression="Imperial" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QhWidth" HeaderText="QhWidth" SortExpression="QhWidth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Beizhuwg" HeaderText="Beizhuwg" SortExpression="Beizhuwg" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Beizhuzz" HeaderText="Beizhuzz" SortExpression="Beizhuzz" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Zengsong" HeaderText="Zengsong" SortExpression="Zengsong" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Zhuangtai1" HeaderText="Zhuangtai1" SortExpression="Zhuangtai1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Zhuangtai2" HeaderText="Zhuangtai2" SortExpression="Zhuangtai2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="By1" HeaderText="By1" SortExpression="By1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="By2" HeaderText="By2" SortExpression="By2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="By3" HeaderText="By3" SortExpression="By3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="By4" HeaderText="By4" SortExpression="By4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="By5" HeaderText="By5" SortExpression="By5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="By6" HeaderText="By6" SortExpression="By6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="By7" HeaderText="By7" SortExpression="By7" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
