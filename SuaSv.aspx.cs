using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using UtilsCode;
using Utils;

public partial class SuaSv : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            int ma = Convert.ToInt32(Request.QueryString["ma"]);
            txtMa.Text = ma.ToString();
            DataTable dt = MyUtils.createDt("select * from tblsv where ma = " + ma);
            txtTen.Text = (string)dt.Rows[0]["ten"];
            bool gt = (bool)dt.Rows[0]["gt"];
            rdbNu.Checked = gt == false ? true : false;
            int maLop = (int)dt.Rows[0]["maLop"];
            //Response.Write(maLop);
            DataTable dt2 = MyUtils.createDt("select * from tbllop");
            ddlLop.DataSource = dt2;
            ddlLop.DataValueField = "ma";
            ddlLop.DataTextField = "ten";
            ddlLop.DataBind();
            ddlLop.SelectedValue = maLop.ToString();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int ma = Convert.ToInt32(txtMa.Text);
        bool gt = rdbNam.Checked ? true : false;
        string ten = txtTen.Text;
        int lop = Convert.ToInt32(ddlLop.SelectedValue);
        MyUtils.execute("update tblsv set ten='"+ ten +"', gt='" + gt + "', maLop=" + lop + " where ma = " +ma);
        Response.Redirect("ListSv.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int ma = Convert.ToInt32(txtMa.Text);
        MyUtils.execute("delete from tblsv where ma = " + ma);
        Response.Redirect("ListSv.aspx");
    }
}