using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxGridView;

public partial class _Default : System.Web.UI.Page {
    protected void ASPxGridView1_Load(object sender, EventArgs e) {
        // set DataSource
        ASPxGridView1.DataSource = GetCurrentTable();
        // create columns, if necessary
        EnsureColumns();
        // call DataBind()
        ASPxGridView1.DataBind();
    }

    private DataTable GetCurrentTable() {
        if(ASPxRadioButton1.Checked)
            return GetTable1();
        else
            return GetTable2();
    }

    private DataTable GetTable1() {
        DataTable dt = (DataTable)Session["Table1"];
        if(dt == null) {
            dt = new DataTable();
            dt.Columns.Add("ID1");
            dt.Columns.Add("Data1");
            for(int i = 0; i < 5; i++)
                dt.Rows.Add(i, "row 1 " + i.ToString());
            Session.Add("Table1", dt);
        }
        return dt;
    }
    private DataTable GetTable2() {
        DataTable dt = (DataTable)Session["Table2"];
        if(dt == null) {
            dt = new DataTable();
            dt.Columns.Add("ID2");
            dt.Columns.Add("Data2");
            for(int i = 0; i < 10; i++)
                dt.Rows.Add(i, "row 2 " + i.ToString());
            Session.Add("Table2", dt);
        }
        return dt;
    }

    private void EnsureColumns() {
        if(ASPxGridView1.Columns.Count == 0)
            ReCreateColumns();
        else {
            DataTable table = GetCurrentTable();
            // if the grid has other columns than the assigned data source, 
            // recreate columns
            if(ASPxGridView1.Columns[table.Columns[0].ColumnName] == null)
                ReCreateColumns(); 
        }
    }

    private void ReCreateColumns() {
        ASPxGridView1.Columns.Clear();

        DataTable table = GetCurrentTable();
        foreach(DataColumn dataColumn in table.Columns) {
            GridViewDataTextColumn column = new GridViewDataTextColumn();
            column.FieldName = dataColumn.ColumnName;
            // set additional column properties
            column.Caption = dataColumn.ColumnName;
            ASPxGridView1.Columns.Add(column);
        }
    }
}