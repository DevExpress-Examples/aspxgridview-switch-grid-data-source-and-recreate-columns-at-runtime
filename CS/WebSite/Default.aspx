﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>




<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <dx:aspxgridview id="ASPxGridView1" runat="server" AutoGenerateColumns="False" Width="910px" Settings-ShowGroupPanel="true" OnLoad="ASPxGridView1_Load"></dx:aspxgridview>
        &nbsp;
        <dx:ASPxRadioButton ID="ASPxRadioButton1" runat="server" AutoPostBack="True" Checked="True"
            GroupName="1" Text="Data Source #1">
        </dx:ASPxRadioButton>
        <dx:ASPxRadioButton ID="ASPxRadioButton2" runat="server" AutoPostBack="True" GroupName="1"
            Text="Data Source #2">
        </dx:ASPxRadioButton>
    </div>
    </form>
</body>
</html>
