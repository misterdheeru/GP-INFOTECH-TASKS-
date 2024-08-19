using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String cs = "server=.;database=MyDataBase;uid=sa;pwd=123";

        private void _Bind()
        {
            SqlConnection Conn = new SqlConnection(cs);
            String Query = "SELECT *FROM EMP ";
            SqlCommand cmd = new SqlCommand(Query, Conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "new");
            GridView1.DataSource = ds.Tables["new"];
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                _Bind();
            }           
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];

            Label Lblmsg = (Label)row.FindControl("lbml");

            int eno = int.Parse(Lblmsg.Text);
            SqlConnection Conn = new SqlConnection(cs);
            Conn.Open();
            String Query = "Delete from Emp Where EmpNo =  @eno";
            SqlCommand cmd = new SqlCommand(Query, Conn);

            cmd.Parameters.AddWithValue("@eno", eno);

            int i = cmd.ExecuteNonQuery();
            Conn.Close();

             if(i==1)
            {
                LBLMSG.Text = "DELEATED ";
            }
            _Bind();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            _Bind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            _Bind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            GridViewRow row = GridView1.Rows[e.RowIndex];
            Label LBL2 = (Label)row.FindControl("lbml");
            int eno = int.Parse(LBL2.Text);
            TextBox g = (TextBox)row.FindControl("TextBox1");
            int sal = int.Parse(g.Text);
            SqlConnection Conn = new SqlConnection(cs);
            Conn.Open();
            String Query = "UPDATE EMP SET EMPSAL = @esal WHERE EMPNO=@eno";
            SqlCommand cmd = new SqlCommand(Query, Conn);

            cmd.Parameters.AddWithValue("@esal", sal);
            cmd.Parameters.AddWithValue("@eno", eno);

            int i = cmd.ExecuteNonQuery();
            Conn.Close();

            if(i==1)
            {
                LBLMSG.Text = "UPDATED";
            
            }
            _Bind();
        }
       protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
           
                if (e.CommandName == "add")
                {
                    GridView1.FooterRow.Visible = true;
                }
                else if (e.CommandName == "save")
                {
                    TextBox Txt1 = (TextBox)GridView1.FooterRow.FindControl("Footer1");
                    TextBox Txt2 = (TextBox)GridView1.FooterRow.FindControl("Footer2");
                    TextBox Txt3 = (TextBox)GridView1.FooterRow.FindControl("Footer3");
                    int eno = int.Parse(Txt1.Text);
                    string name = Txt2.Text;
                    int esal = int.Parse(Txt3.Text);
                    SqlConnection conn = new SqlConnection(cs);
                    conn.Open();
                    string Query = "Insert Into Emp (EmpNo,EmpName,EmpSal)Values(@id,@ename,@sal)";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.Parameters.AddWithValue("@id", eno);
                    cmd.Parameters.AddWithValue("@ename", Txt2.Text);
                    cmd.Parameters.AddWithValue("@sal", esal);

                    int i = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (i == 1)
                    {

                        LBLMSG.Text = "RECORD WAS INSERTED";
                      _Bind();

                    }
                }
        }
    }
}