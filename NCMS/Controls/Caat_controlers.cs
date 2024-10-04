using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCMS.Controls
{
    public partial class Caat_controlers : UserControl
    {
        public Caat_controlers()
        {
            InitializeComponent();
        }

        private void Caat_controlers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                this.usersTableAdapter.Fill(this.test2DataSet.users);

                guna2DataGridView1.DataSource = usersBindingSource;

                guna2DataGridView1.AutoGenerateColumns = true;

                usersBindingSource.ResetBindings(false);
         
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
