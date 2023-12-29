<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E448)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to dynamically switch the grid's data source and recreate columns at runtime


<p>This example demonstrates how to allow a user to use the same grid to view different data sources. Grid columns are recreated when a new data source is assigned. Please notice that the data source is unconditionally assigned on each post back / callback within the ASPxGridView.Load event handler, while columns are recreated only after switching the data source.</p><p>See also:<br />
<a href="https://www.devexpress.com/Support/Center/p/E2965">How to bind ASPxGridView with autogenerated columns to different data sources at runtime. The grid is created at design mode</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E2967">How to bind ASPxGridView with manually created columns to different data sources at runtime. The grid is created in design mode.</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E2968">How to bind ASPxGridView with autogenerated columns to different data sources at runtime. The grid is created in runtime mode</a></p>

<br/>


