<%@ Page Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="InvoiceGenerationUI.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <div class="row border  mr-3">
        <div class="col p-3">
            <form runat="server">
                <asp:Repeater ID="rptTest" runat="server">
                    <HeaderTemplate>
                        <div class="table-responsive">
                        <table class="table">
                            <thead class="thead-light">
                                <tr>
                                    <th scope="col">Inv_Date
                                    </th>
                                    <th scope="col">Year
                                    </th>
                                    <th scope="col">Period
                                    </th>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtInv_Date" CssClass="float-left" runat="server" />
                                        <div class="dropdown  ml-1 float-left">
                                            <button type="button" class="btn btn-secondary dropdown-toggle p-0 pr-1" data-toggle="dropdown">
                                            </button>
                                            <div class="dropdown-menu">
                                                <a class="dropdown-item" href="#">Link 1</a>
                                                <a class="dropdown-item" href="#">Link 2</a>
                                                <a class="dropdown-item" href="#">Link 3</a>
                                            </div>
                                        </div>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtYear" runat="server" CssClass="float-left" />
                                        <div class="dropdown  ml-1 float-left">
                                            <button type="button" class="btn btn-secondary dropdown-toggle p-0 pr-1" data-toggle="dropdown">
                                            </button>
                                            <div class="dropdown-menu">
                                                <a class="dropdown-item" href="#">Link 1</a>
                                                <a class="dropdown-item" href="#">Link 2</a>
                                                <a class="dropdown-item" href="#">Link 3</a>
                                            </div>
                                        </div>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtPeriod" runat="server" CssClass="float-left" />
                                        <div class="dropdown  ml-1 float-left">
                                            <button type="button" class="btn btn-secondary dropdown-toggle p-0 pr-1" data-toggle="dropdown">
                                            </button>
                                            <div class="dropdown-menu">
                                                <a class="dropdown-item" href="#">Link 1</a>
                                                <a class="dropdown-item" href="#">Link 2</a>
                                                <a class="dropdown-item" href="#">Link 3</a>
                                            </div>
                                        </div>
                                    </td>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%#DataBinder.Eval(Container,"DataItem.Inv_Date")%>
                            </td>
                            <td>
                                <%#DataBinder.Eval(Container,"DataItem.Year")%>
                            </td>
                            <td>
                                <%#DataBinder.Eval(Container,"DataItem.Period")%>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
									</table>
                        </div>
                    </FooterTemplate>
                </asp:Repeater>
            </form>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphScripts" runat="server">
</asp:Content>
