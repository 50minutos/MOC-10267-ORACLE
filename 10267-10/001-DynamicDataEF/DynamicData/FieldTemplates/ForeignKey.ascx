﻿<%@ Control Language="C#" CodeBehind="ForeignKey.ascx.cs" Inherits="_001_DynamicDataEF.ForeignKeyField" %>

<asp:HyperLink ID="HyperLink1" runat="server"
    Text="<%# GetDisplayString() %>"
    NavigateUrl="<%# GetNavigateUrl() %>"  />

