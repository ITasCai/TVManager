using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVManagerBLL;
using System.Data.SqlClient;

namespace TVManagerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }

        private void lvwshow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvwshow.View = View.Details;
            lvwshow.Columns.Add("频道名称");
            lvwshow.Columns.Add("节目名称");
            lvwshow.Columns.Add("时间");

            SqlDataReader dr = TvBLL.TvShowBLL();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    string tvname = dr[0].ToString();
                    string jmname = dr[1].ToString();
                    string time = dr[2].ToString();

                    ListViewItem itemc = new ListViewItem(tvname);
                    itemc.SubItems.Add(jmname);
                    itemc.SubItems.Add(time);
                    lvwshow.Items.Add(itemc);

                }
            }

        }

        private void btncx_Click(object sender, EventArgs e)
        {
            // 清除数据
            lvwshow.Items.Clear();

            SqlDataReader dr = TvBLL.TvDimBLL(txttvname.Text.Trim());

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    string tvname = dr[0].ToString();
                    string jmname = dr[1].ToString();
                    string time = dr[2].ToString();

                    ListViewItem itemc = new ListViewItem(tvname);
                    itemc.SubItems.Add(jmname);
                    itemc.SubItems.Add(time);
                    lvwshow.Items.Add(itemc);

                }
            }
        }
    }
}
