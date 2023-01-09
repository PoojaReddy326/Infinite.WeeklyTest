using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Infinite.WeeklyTest
{
    public partial class Form1 : Form
    {
        private SqlConnection conobj = null;
        private SqlDataAdapter adapterobj = null;
        private DataSet ds = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (conobj = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindCon"].ConnectionString))
            {
                using (adapterobj = new SqlDataAdapter("Select * from Customer", conobj))
                {
                    ds = new DataSet();
                    adapterobj.Fill(ds, "Cust");

                    CbSortBy.Text = "--Select--";
                   

                }
            }
        }

        private void BtnGetData_Click(object sender, EventArgs e)
        {
            conobj = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindCon"].ConnectionString);
            adapterobj = new SqlDataAdapter("select * from Customer", conobj);
            ds = new DataSet();
            adapterobj.Fill(ds, "Cust"); DataColumn[] dc = new DataColumn[1];
            dc[0] = ds.Tables["Cust"].Columns["CustomerId"];
            ds.Tables["Cust"].PrimaryKey = dc;
            DataRow dr = ds.Tables["Cust"].Rows.Find(TxtCustCity.Text);
            if (dr != null)
            {
                TxtCustCity.Text = dr["City"].ToString();
             
            }
            else
            {
                LblMessage.Text = "No Records Found";
            }

        }
    }
}
