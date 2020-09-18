<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Accept.aspx.cs" Inherits="InvoiceGenerationUI.Accept" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <div class="row border mr-3">
    <div class="col p-3">
        <div class="row">
            <div class="col-7">
                <h6>Invoice Transactions</h6>
            </div>
            <div class="col-5 divButtons">
                <button type="button" class="btn btn-success">Accept</button>
                <button type="button" class="btn btn-danger">Reject</button>
                <button type="button" class="btn btn-warning">Close</button>
                <button type="button" class="btn btn-info">Credit Request</button>
            </div>
        </div>
       
    </div>
</div>
<div class="row border mr-3">
    <div class="col p-3">
        <h6>Invoice Transaction Details</h6>
        
    </div>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="server">
</asp:Content>
