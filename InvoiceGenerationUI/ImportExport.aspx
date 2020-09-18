<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ImportExport.aspx.cs" Inherits="InvoiceGenerationUI.ImportExport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <div class="row border  mr-3">
        <div class="col p-3">
            <h4>Import</h4>
            <div class="alert alert-success mr-3" id="successalert" runat="server" visible="false" role="alert">
                File imported successfully.
            </div>
            <div class="alert alert-danger mr-3" id="erroralert" runat="server" visible="false" role="alert">
                File import failed.
            </div>
            <form class="needs-validation" runat="server">
                <div class="form-row">
                    <div class="col-md-4 mb-3">
                        <label for="ddlImportType">Import Type</label>
                        <asp:DropDownList class="custom-select" ValidationGroup="Import" ID="ddlImportType" runat="server">
                            <asp:ListItem Text="Choose.." Value="0"></asp:ListItem>
                            <asp:ListItem Text="P2 Import" Value="1"></asp:ListItem>
                            <asp:ListItem Text="P3 Import" Value="2"></asp:ListItem>
                            <asp:ListItem Text="GL Extract" Value="3"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvImportType" runat="server" Display="Dynamic" CssClass="alert-text text-danger" ControlToValidate="ddlImportType" ErrorMessage="Please select a valid import type." ValidationGroup="Import" InitialValue="0"></asp:RequiredFieldValidator>

                    </div>
                </div>
                <div class="form-row">
                    <div class="col-md-4 mb-3">
                        <div class="form-group">
                            <label for="fuImport">File Input</label>
                            <asp:FileUpload ID="fuImport" runat="server" class="form-control-file" ValidationGroup="Import" />
                            <asp:RequiredFieldValidator ID="rfvImport" runat="server" ControlToValidate="fuImport" CssClass="alert-text text-danger" Display="Dynamic" ValidationGroup="Import" ErrorMessage="Please select a file." InitialValue=""></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="revImport" ValidationExpression="([a-zA-Z0-9\s_\\.\-:])+(.csv)$"
                                ControlToValidate="fuImport" runat="server" ValidationGroup="Import" CssClass="alert-text text-danger" ErrorMessage="Please select a valid csv file."
                                Display="Dynamic" />
                        </div>
                    </div>
                </div>
                <asp:Button ID="btnImport" runat="server" class="btn btn-primary" OnClick="btnImport_Click" OnClientClick="return validate('Import')" ValidationGroup="Import" Text="Import" />
            </form>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="server">
</asp:Content>
