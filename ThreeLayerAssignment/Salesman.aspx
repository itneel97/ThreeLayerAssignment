<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Salesman.aspx.cs" Inherits="ThreeLayerAssignment.Salesman" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <br />
    <h2 class="d-flex justify-content-center">Salesman</h2>
    <br />
    
        <div class="container">
            <div class="form-group row">
                <asp:Label class="col-sm-2 col-form-label" ID="Label3" runat="server" Text="Label">Salesman ID</asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="SalesmanIdTxt" class="form-control" Placeholder="Enter ID" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="form-group row">
                <asp:Label class="col-sm-2 col-form-label" ID="Label1" runat="server" Text="Label">Salesman Name</asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="SalesmanNameTxt" class="form-control" Placeholder="Enter Name" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="form-group row">
                <asp:Label class="col-sm-2 col-form-label" ID="Label2" runat="server" Text="Label">City</asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="SalesmanCityTxt" class="form-control" Placeholder="Enter City" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="form-group row">
                <asp:Label class="col-sm-2 col-form-label" ID="Label4" runat="server" Text="Label">Commission</asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="SalesmanCommissionTxt" class="form-control" Placeholder="Enter Comission" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="form-group row">
                <div class="col-sm-10">
                    <asp:Button class="btn btn-primary" ID="SubmitBtn" runat="server" Text="Button" OnClick="SubmitBtn_Click" />
                </div>
            </div>
        </div>    

    <br />

    <asp:GridView CssClass="d-flex justify-content-center" ID="SalesmanGv" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnDataBound="SalesmanGv_DataBound">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>

    <br />
</asp:Content>
