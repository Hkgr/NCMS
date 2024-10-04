namespace NCMS
{
    partial class SignIn
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.test2DataSet = new NCMS.test2DataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new NCMS.test2DataSetTableAdapters.usersTableAdapter();
            this.signin_pic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.username_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.password_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.username_text = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.singin_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.sibgin_msg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.test2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signin_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // test2DataSet
            // 
            this.test2DataSet.DataSetName = "test2DataSet";
            this.test2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.test2DataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // signin_pic
            // 
            this.signin_pic.BorderRadius = 20;
            this.signin_pic.Image = ((System.Drawing.Image)(resources.GetObject("signin_pic.Image")));
            this.signin_pic.ImageRotate = 0F;
            this.signin_pic.Location = new System.Drawing.Point(-25, -4);
            this.signin_pic.Name = "signin_pic";
            this.signin_pic.Size = new System.Drawing.Size(882, 655);
            this.signin_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signin_pic.TabIndex = 0;
            this.signin_pic.TabStop = false;
            this.signin_pic.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // username_label
            // 
            this.username_label.BackColor = System.Drawing.Color.Transparent;
            this.username_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(630, 399);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(157, 33);
            this.username_label.TabIndex = 1;
            this.username_label.Text = ": المستخدم اسم";
            // 
            // password_label
            // 
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.White;
            this.password_label.Location = new System.Drawing.Point(630, 449);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(116, 33);
            this.password_label.TabIndex = 2;
            this.password_label.Text = ": المرور كلمة";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderRadius = 20;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(641, 818);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(314, 74);
            this.guna2TextBox1.TabIndex = 3;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderRadius = 20;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(864, 804);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '*';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(314, 74);
            this.guna2TextBox2.TabIndex = 4;
            this.guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // username_text
            // 
            this.username_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_text.Font = new System.Drawing.Font("Tajawal", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.username_text.Location = new System.Drawing.Point(191, 399);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(382, 33);
            this.username_text.TabIndex = 5;
            this.username_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tajawal", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(186)))), ((int)(((byte)(196)))));
            this.textBox1.Location = new System.Drawing.Point(167, 449);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 33);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // singin_btn
            // 
            this.singin_btn.BackColor = System.Drawing.Color.Transparent;
            this.singin_btn.BorderRadius = 20;
            this.singin_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.singin_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.singin_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.singin_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.singin_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.singin_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(132)))), ((int)(((byte)(145)))));
            this.singin_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.singin_btn.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singin_btn.ForeColor = System.Drawing.Color.White;
            this.singin_btn.Location = new System.Drawing.Point(191, 534);
            this.singin_btn.Name = "singin_btn";
            this.singin_btn.Size = new System.Drawing.Size(596, 45);
            this.singin_btn.TabIndex = 7;
            this.singin_btn.Text = "تسجيل الدخول";
            this.singin_btn.Click += new System.EventHandler(this.singin_btn_Click);
            // 
            // sibgin_msg
            // 
            this.sibgin_msg.BackColor = System.Drawing.Color.Transparent;
            this.sibgin_msg.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sibgin_msg.ForeColor = System.Drawing.Color.White;
            this.sibgin_msg.Location = new System.Drawing.Point(259, 325);
            this.sibgin_msg.Name = "sibgin_msg";
            this.sibgin_msg.Size = new System.Drawing.Size(367, 33);
            this.sibgin_msg.TabIndex = 8;
            this.sibgin_msg.Text = "الدخول بتسجيل قم العمل لبدأ !بك مرحباً";
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.test2DataSet;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 643);
            this.Controls.Add(this.sibgin_msg);
            this.Controls.Add(this.singin_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.signin_pic);
            this.Font = new System.Drawing.Font("Tajawal ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.test2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signin_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private test2DataSet test2DataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private test2DataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private Guna.UI2.WinForms.Guna2PictureBox signin_pic;
        private Guna.UI2.WinForms.Guna2HtmlLabel username_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel password_label;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2GradientButton singin_btn;
        private Guna.UI2.WinForms.Guna2HtmlLabel sibgin_msg;
        private System.Windows.Forms.BindingSource usersBindingSource1;
    }
}

