using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using UtilsCode;
using Utils;

public partial class ListSv : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = MyUtils.createDt("select *,tbllop.ten as tenLop from tblsv inner join tbllop on tblsv.maLop = tbllop.ma");
        DataTable dt2 = dt.Clone();
        dt2.Columns[2].DataType = typeof(string);

        foreach (DataRow row in dt.Rows)
        {
            dt2.ImportRow(row);
        }
        for (int i = 0; i < dt2.Rows.Count; i++)
        {
            string gt = dt2.Rows[i][2].ToString();
            dt2.Rows[i][2] = gt == "True" ? "Nam" : "Nu";
        }
        grvSv.DataSource = dt2;
        grvSv.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string ten = txtTen.Text;
        DataTable dt = MyUtils.createDt("select * from tblsv where ten like '%" + ten + "%'");
        grvSv.DataSource = dt;
        grvSv.DataBind();
    }


    protected void grvSv_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(grvSv.Rows[e.RowIndex].Cells[0].Text);
        MyUtils.execute("delete from tblsv where ma=" + id);
        PageUtils.ReloadPage(Page);
    }
    
    protected void grvSv_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        int id = Convert.ToInt32(grvSv.Rows[e.NewSelectedIndex].Cells[0].Text);
        Response.Redirect("SuaSv.aspx?ma=" + id);
    }
}