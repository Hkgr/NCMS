using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCMS
{
    public partial class main : Form
    {
        Controls.Caat_controlers cat_con = new Controls.Caat_controlers();
        Controls.Emp_controler emp_Controler = new Controls.Emp_controler();
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'test2DataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.test2DataSet.users);
            user_label.Text=SessionManager.fullname;
           // emp_btn.Parent = navpar;
           // emp_btn.BackColor = Color.Transparent;
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            main_pan.Controls.Clear();
            main_pan.Controls.Add(emp_Controler);
            emp_Controler.Dock = DockStyle.Fill;
        }

        private void user_label_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
                
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            main_pan.Controls.Clear();
            main_pan.Controls.Add(cat_con);
            cat_con.Dock = DockStyle.Fill;
        }
    }
}
