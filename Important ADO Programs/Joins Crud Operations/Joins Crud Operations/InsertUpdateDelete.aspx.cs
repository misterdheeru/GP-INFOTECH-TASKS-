using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DATAACCESSLOGIC;
using BUSSLOGIC;
using System.Data;
using System.Data.SqlClient;

namespace Joins_Crud_Operations
{
    public partial class InsertUpdateDelete : System.Web.UI.Page
    {


       DataAccessLogin objdl=new DataAccessLogin();
        BussnessLogic objbl=new BussnessLogic();
        internal void BindEmpDept()
        {
            DataSet ds=objbl.ForwordGridGetEmpDept();
            GridView1.DataSource= ds;
            GridView1.DataBind();
        }
        internal void BindDept()
        {
            DataSet ds=objbl.ForwardDropGetDept();
            dropListDept.DataSource= ds;
            dropListDept.DataTextField = "DeptName";
            dropListDept.DataValueField = "DeptNo";
            dropListDept.DataBind();
            dropListDept.Items.Insert(0, "-Select-");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindEmpDept();
                BindDept();
            }
        }


        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindEmpDept();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindEmpDept();
        }

      

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e )
        {
           if(e.CommandName == "add")
            {
                GridView1.FooterRow.Visible = true;
            }
            if (e.CommandName == "d")
            {
                GridViewRow row = (GridViewRow)((Control)e.CommandSource).NamingContainer;

                Label Lblmsg = (Label)row.FindControl("LBL1");

                objdl.Eno = Convert.ToInt32(Lblmsg.Text);

                int i = objbl.ForwardDeleteEmp(objdl);

                if (i == 1)
                {
                    Label1.Text = "Record Is Deleted";
                    BindEmpDept();

                }
                else
                {
                    Label1.Text = "Record Is Failed To Deleted";
                }

            }



            else if (e.CommandName == "save")
            {


                TextBox Txt1 = (TextBox)GridView1.FooterRow.FindControl("TxtFooter1");
                TextBox Txt2 = (TextBox)GridView1.FooterRow.FindControl("TxtFooter2");
                TextBox Txt3 = (TextBox)GridView1.FooterRow.FindControl("TxtFooter3");

                objdl.Eno = int.Parse(Txt1.Text);

                objdl.Ename = Convert.ToString(Txt2.Text);

                objdl.Esal = double.Parse(Txt3.Text);

                objdl.DeptName = dropListDept.SelectedItem.Text;
                objdl.DeptNo = Convert.ToInt32(dropListDept.SelectedValue);

                int i = objbl.ForwardInsertEmp(objdl);

                if (i == 1)
                {
                    Label1.Text = "inserted values";
                    BindEmpDept();

                }
                else
                {
                    Label1.Text = " failed to inserted values";
                }



            }


        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];

            Label Lblmsg = (Label)row.FindControl("LBL1");
                TextBox g = (TextBox)row.FindControl("TextBox1");

                objdl.Eno = Convert.ToInt32(Lblmsg.Text);
                objdl.Esal = int.Parse(g.Text);

                int i = objbl.ForwardUpdateEmp(objdl);

                if (i == 1)
                {
                    Label1.Text = "Value Is Updated ";
                    BindEmpDept();
                }
                else
                {
                    Label1.Text = "Value Is Failed To Updated ";
                }

            }
        }
    }

