using Guna.UI2.WinForms;
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
    public partial class Emp_controler : UserControl
    {
        public Emp_controler()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                this.employeesTableAdapter.Fill(this.test2DataSet.employees);

                emp_dtv.DataSource = employeesBindingSource;

                emp_dtv.AutoGenerateColumns = true;

                employeesBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void SaveChanges()
        {
            try
            {
                employeesBindingSource.EndEdit();
                employeesTableAdapter.Update(test2DataSet.employees);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message);
            }
        }

        private void Emp_controler_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void emp_dtv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SaveChanges();
        }

        private void emp_dtv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SaveChanges();
        }
    }
}
