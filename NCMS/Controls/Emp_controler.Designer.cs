namespace NCMS.Controls
{
    partial class Emp_controler
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emp_controler));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test2DataSet = new NCMS.test2DataSet();
            this.usersTableAdapter = new NCMS.test2DataSetTableAdapters.usersTableAdapter();
            this.emp_dtv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new NCMS.test2DataSetTableAdapters.employeesTableAdapter();
            this.createdbyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_dtv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(177, 74);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 5;
            this.guna2PictureBox2.TabStop = false;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.test2DataSet;
            // 
            // test2DataSet
            // 
            this.test2DataSet.DataSetName = "test2DataSet";
            this.test2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // emp_dtv
            // 
            this.emp_dtv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tajawal ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.emp_dtv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.emp_dtv.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tajawal ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emp_dtv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.emp_dtv.ColumnHeadersHeight = 35;
            this.emp_dtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.emp_dtv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createdbyDataGridViewTextBoxColumn1,
            this.createdatDataGridViewTextBoxColumn1,
            this.remarksDataGridViewTextBoxColumn,
            this.emnameDataGridViewTextBoxColumn,
            this.jopDataGridViewTextBoxColumn,
            this.empcodeDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.empidDataGridViewTextBoxColumn});
            this.emp_dtv.DataSource = this.employeesBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tajawal ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.emp_dtv.DefaultCellStyle = dataGridViewCellStyle5;
            this.emp_dtv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.emp_dtv.Location = new System.Drawing.Point(3, 148);
            this.emp_dtv.Name = "emp_dtv";
            this.emp_dtv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emp_dtv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.emp_dtv.RowHeadersVisible = false;
            this.emp_dtv.RowTemplate.Height = 25;
            this.emp_dtv.Size = new System.Drawing.Size(1173, 469);
            this.emp_dtv.TabIndex = 7;
            this.emp_dtv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.emp_dtv.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Tajawal ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_dtv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.emp_dtv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.emp_dtv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.emp_dtv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.emp_dtv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.emp_dtv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.emp_dtv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.emp_dtv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tajawal ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_dtv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.emp_dtv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.emp_dtv.ThemeStyle.HeaderStyle.Height = 35;
            this.emp_dtv.ThemeStyle.ReadOnly = false;
            this.emp_dtv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.emp_dtv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.emp_dtv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tajawal ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_dtv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.emp_dtv.ThemeStyle.RowsStyle.Height = 25;
            this.emp_dtv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.emp_dtv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.emp_dtv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.emp_dtv_CellEndEdit);
            this.emp_dtv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.emp_dtv_CellValueChanged);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.test2DataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // createdbyDataGridViewTextBoxColumn1
            // 
            this.createdbyDataGridViewTextBoxColumn1.DataPropertyName = "created_by";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.createdbyDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.createdbyDataGridViewTextBoxColumn1.DividerWidth = 3;
            this.createdbyDataGridViewTextBoxColumn1.HeaderText = "أنشأ من قبل";
            this.createdbyDataGridViewTextBoxColumn1.Name = "createdbyDataGridViewTextBoxColumn1";
            // 
            // createdatDataGridViewTextBoxColumn1
            // 
            this.createdatDataGridViewTextBoxColumn1.DataPropertyName = "created_at";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.createdatDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.createdatDataGridViewTextBoxColumn1.DividerWidth = 3;
            this.createdatDataGridViewTextBoxColumn1.HeaderText = "انشأ بتاريخ";
            this.createdatDataGridViewTextBoxColumn1.Name = "createdatDataGridViewTextBoxColumn1";
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "remarks";
            this.remarksDataGridViewTextBoxColumn.DividerWidth = 3;
            this.remarksDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // emnameDataGridViewTextBoxColumn
            // 
            this.emnameDataGridViewTextBoxColumn.DataPropertyName = "em_name";
            this.emnameDataGridViewTextBoxColumn.DividerWidth = 3;
            this.emnameDataGridViewTextBoxColumn.HeaderText = "الاسم";
            this.emnameDataGridViewTextBoxColumn.Name = "emnameDataGridViewTextBoxColumn";
            // 
            // jopDataGridViewTextBoxColumn
            // 
            this.jopDataGridViewTextBoxColumn.DataPropertyName = "jop";
            this.jopDataGridViewTextBoxColumn.DividerWidth = 3;
            this.jopDataGridViewTextBoxColumn.HeaderText = "المسمى الوظيفي";
            this.jopDataGridViewTextBoxColumn.Name = "jopDataGridViewTextBoxColumn";
            // 
            // empcodeDataGridViewTextBoxColumn
            // 
            this.empcodeDataGridViewTextBoxColumn.DataPropertyName = "emp_code";
            this.empcodeDataGridViewTextBoxColumn.DividerWidth = 3;
            this.empcodeDataGridViewTextBoxColumn.HeaderText = "الرقم الوظيفي";
            this.empcodeDataGridViewTextBoxColumn.Name = "empcodeDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.DividerWidth = 3;
            this.departmentDataGridViewTextBoxColumn.HeaderText = "القسم";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.DividerWidth = 3;
            this.empidDataGridViewTextBoxColumn.HeaderText = "الرقم التسلسلي";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Emp_controler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.emp_dtv);
            this.Controls.Add(this.guna2PictureBox2);
            this.Name = "Emp_controler";
            this.Size = new System.Drawing.Size(1179, 777);
            this.Load += new System.EventHandler(this.Emp_controler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_dtv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private test2DataSet test2DataSet;
        private test2DataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Guna.UI2.WinForms.Guna2DataGridView emp_dtv;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private test2DataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdbyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
    }
}
