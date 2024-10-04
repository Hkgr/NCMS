using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NCMS
{
    public partial class SignIn : Form
    {
        private test2Entities1 _context;
        public SignIn()
        {
            InitializeComponent();
            _context = new test2Entities1();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            username_label.Parent = signin_pic;
            username_label.BackColor = Color.Transparent;
            password_label.Parent = signin_pic;
            password_label.BackColor = Color.Transparent;
            username_text.Parent = signin_pic;
            // username_text.BackColor = Color.Transparent;
            singin_btn.Parent = signin_pic;
            singin_btn.BackColor = Color.Transparent;
            sibgin_msg.Parent = signin_pic;
            sibgin_msg.BackColor = Color.Transparent;

            // TODO: This line of code loads data into the 'test2DataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.test2DataSet.users);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void singin_btn_Click(object sender, EventArgs e)
        {
            var userpass = _context.users
            .Where(u => u.username == username_text.Text)
            .Select(u => new { u.password, u.fullname })
            .FirstOrDefault();
            if (userpass != null)
            {
                SessionManager.Login(username_text.Text);
                SessionManager.fullname=userpass.fullname;
                main main = new main();
                main.Show();
                this.Hide();

            }
            else
            {
                sibgin_msg.Text = "أخرى مرة جرب ما خطأ هناك";
                sibgin_msg.ForeColor = Color.Red;
            }

        }
    }
}
