Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub ASPxGridView1_Load(ByVal sender As Object, ByVal e As EventArgs)
		' set DataSource
		ASPxGridView1.DataSource = GetCurrentTable()
		' create columns, if necessary
		EnsureColumns()
		' call DataBind()
		ASPxGridView1.DataBind()
	End Sub

	Private Function GetCurrentTable() As DataTable
		If ASPxRadioButton1.Checked Then
			Return GetTable1()
		Else
			Return GetTable2()
		End If
	End Function

	Private Function GetTable1() As DataTable
		Dim dt As DataTable = CType(Session("Table1"), DataTable)
		If dt Is Nothing Then
			dt = New DataTable()
			dt.Columns.Add("ID1")
			dt.Columns.Add("Data1")
			For i As Integer = 0 To 4
				dt.Rows.Add(i, "row 1 " & i.ToString())
			Next i
			Session.Add("Table1", dt)
		End If
		Return dt
	End Function
	Private Function GetTable2() As DataTable
		Dim dt As DataTable = CType(Session("Table2"), DataTable)
		If dt Is Nothing Then
			dt = New DataTable()
			dt.Columns.Add("ID2")
			dt.Columns.Add("Data2")
			For i As Integer = 0 To 9
				dt.Rows.Add(i, "row 2 " & i.ToString())
			Next i
			Session.Add("Table2", dt)
		End If
		Return dt
	End Function

	Private Sub EnsureColumns()
		If ASPxGridView1.Columns.Count = 0 Then
			ReCreateColumns()
		Else
			Dim table As DataTable = GetCurrentTable()
			' if the grid has other columns than the assigned data source, 
			' recreate columns
			If ASPxGridView1.Columns(table.Columns(0).ColumnName) Is Nothing Then
				ReCreateColumns()
			End If
		End If
	End Sub

	Private Sub ReCreateColumns()
		ASPxGridView1.Columns.Clear()

		Dim table As DataTable = GetCurrentTable()
		For Each dataColumn As DataColumn In table.Columns
			Dim column As New GridViewDataTextColumn()
			column.FieldName = dataColumn.ColumnName
			' set additional column properties
			column.Caption = dataColumn.ColumnName
			ASPxGridView1.Columns.Add(column)
		Next dataColumn
	End Sub
End Class