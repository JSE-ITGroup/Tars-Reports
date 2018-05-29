<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TARSREPORTS._Default" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>TARS Reports</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>
                <asp:DropDownList ID="ReportsList" runat="server" DataSourceID="SqlDataSource1" DataTextField="DES" DataValueField="Location">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WebFeedRepositoryConnectionString %>" SelectCommand="SELECT ID, LTRIM(RTRIM(LOC)) + LTRIM(RTRIM(FIL)) AS Location, DES FROM REPORT WHERE VISIBLE='Y'"></asp:SqlDataSource>
                <asp:Button ID="Reports" runat="server" OnClick="Reports_Click" Text="View Report" />
            </h2>
            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" Width="700px" EnableDatabaseLogonPrompt="False" />
            <p>
&nbsp;</p>
        </div>
    </div>

</asp:Content>
