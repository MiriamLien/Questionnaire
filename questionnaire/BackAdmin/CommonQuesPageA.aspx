<%@ Page Title="" Language="C#" MasterPageFile="~/BackAdmin/Admin.Master" AutoEventWireup="true" CodeBehind="CommonQuesPageA.aspx.cs" Inherits="questionnaire.BackAdmin.CommonQuesPageA" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>常用問題管理</h3>
    <asp:Repeater ID="rptCQ" runat="server">
        <ItemTemplate>
            <p><%# Eval("CQID") %>. <%# Eval("CQTitle") %></p>
            <p><%# Eval("CQChoices") %></p><br />
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
