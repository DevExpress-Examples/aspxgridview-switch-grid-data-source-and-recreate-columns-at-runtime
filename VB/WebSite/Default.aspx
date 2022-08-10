<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <dxwgv:aspxgridview id="ASPxGridView1" runat="server" AutoGenerateColumns="False" Width="910px" Settings-ShowGroupPanel="true" OnLoad="ASPxGridView1_Load"></dxwgv:aspxgridview>
        &nbsp;
        <dxe:ASPxRadioButton ID="ASPxRadioButton1" runat="server" AutoPostBack="True" Checked="True"
            GroupName="1" Text="Data Source #1">
        </dxe:ASPxRadioButton>
        <dxe:ASPxRadioButton ID="ASPxRadioButton2" runat="server" AutoPostBack="True" GroupName="1"
            Text="Data Source #2">
        </dxe:ASPxRadioButton>
    </div>
    </form>
</body>
</html>