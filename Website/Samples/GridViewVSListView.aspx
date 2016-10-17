<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="GridViewVSListView.aspx.cs" Inherits="Samples_GridViewVSListView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="GridView POCO"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="GridViewODS">
        <Columns>
            <asp:BoundField DataField="MenuCategoryDescription" HeaderText="MenuCategoryDescription" SortExpression="MenuCategoryDescription"></asp:BoundField>
        </Columns>
    </asp:GridView>

    <asp:ListView ID="ListView1" runat="server" DataSourceID="GridViewODS"></asp:ListView>

    <asp:ObjectDataSource ID="GridViewODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="MenuCategoryFoodItemsDTO_Get" TypeName="eRestaurantSystem.BLL.ItemsController"></asp:ObjectDataSource>

</asp:Content>

