namespace BetterStasy
{
    partial class Form2
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
            this.register_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.studentno_txb = new System.Windows.Forms.TextBox();
            this.pasword_txb = new System.Windows.Forms.TextBox();
            this.firstname_txb = new System.Windows.Forms.TextBox();
            this.lastname_txb = new System.Windows.Forms.TextBox();
            this.course_cmb = new System.Windows.Forms.ComboBox();
            this.modules_clb = new System.Windows.Forms.CheckedListBox();
            this.group_cmb = new System.Windows.Forms.ComboBox();
            this.rmodule_cbx = new System.Windows.Forms.CheckBox();
            this.rmodules_clb = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // register_lbl
            // 
            this.register_lbl.AutoSize = true;
            this.register_lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.register_lbl.ForeColor = System.Drawing.Color.White;
            this.register_lbl.Location = new System.Drawing.Point(154, 27);
            this.register_lbl.Name = "register_lbl";
            this.register_lbl.Size = new System.Drawing.Size(107, 32);
            this.register_lbl.TabIndex = 0;
            this.register_lbl.Text = "Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student No: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Course (Year):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Modules";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Group:";
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(144, 401);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(121, 23);
            this.register_btn.TabIndex = 8;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // studentno_txb
            // 
            this.studentno_txb.Location = new System.Drawing.Point(144, 98);
            this.studentno_txb.Name = "studentno_txb";
            this.studentno_txb.Size = new System.Drawing.Size(121, 23);
            this.studentno_txb.TabIndex = 9;
            // 
            // pasword_txb
            // 
            this.pasword_txb.Location = new System.Drawing.Point(144, 127);
            this.pasword_txb.Name = "pasword_txb";
            this.pasword_txb.PasswordChar = '●';
            this.pasword_txb.Size = new System.Drawing.Size(121, 23);
            this.pasword_txb.TabIndex = 10;
            // 
            // firstname_txb
            // 
            this.firstname_txb.Location = new System.Drawing.Point(144, 156);
            this.firstname_txb.Name = "firstname_txb";
            this.firstname_txb.Size = new System.Drawing.Size(121, 23);
            this.firstname_txb.TabIndex = 11;
            // 
            // lastname_txb
            // 
            this.lastname_txb.Location = new System.Drawing.Point(144, 185);
            this.lastname_txb.Name = "lastname_txb";
            this.lastname_txb.Size = new System.Drawing.Size(121, 23);
            this.lastname_txb.TabIndex = 12;
            // 
            // course_cmb
            // 
            this.course_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course_cmb.FormattingEnabled = true;
            this.course_cmb.Items.AddRange(new object[] {
            "BCAD1",
            "BCAD2",
            "BCAD3"});
            this.course_cmb.Location = new System.Drawing.Point(144, 214);
            this.course_cmb.Name = "course_cmb";
            this.course_cmb.Size = new System.Drawing.Size(121, 23);
            this.course_cmb.TabIndex = 13;
            this.course_cmb.SelectedIndexChanged += new System.EventHandler(this.course_cmb_SelectedIndexChanged);
            // 
            // modules_clb
            // 
            this.modules_clb.FormattingEnabled = true;
            this.modules_clb.Location = new System.Drawing.Point(144, 243);
            this.modules_clb.Name = "modules_clb";
            this.modules_clb.Size = new System.Drawing.Size(120, 94);
            this.modules_clb.TabIndex = 14;
            // 
            // group_cmb
            // 
            this.group_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.group_cmb.FormattingEnabled = true;
            this.group_cmb.Location = new System.Drawing.Point(144, 344);
            this.group_cmb.Name = "group_cmb";
            this.group_cmb.Size = new System.Drawing.Size(121, 23);
            this.group_cmb.TabIndex = 15;
            // 
            // rmodule_cbx
            // 
            this.rmodule_cbx.AutoSize = true;
            this.rmodule_cbx.Location = new System.Drawing.Point(271, 218);
            this.rmodule_cbx.Name = "rmodule_cbx";
            this.rmodule_cbx.Size = new System.Drawing.Size(116, 19);
            this.rmodule_cbx.TabIndex = 16;
            this.rmodule_cbx.Text = "Repeat Modules?";
            this.rmodule_cbx.UseVisualStyleBackColor = true;
            this.rmodule_cbx.CheckedChanged += new System.EventHandler(this.rmodule_cbx_CheckedChanged);
            // 
            // rmodules_clb
            // 
            this.rmodules_clb.FormattingEnabled = true;
            this.rmodules_clb.Location = new System.Drawing.Point(270, 243);
            this.rmodules_clb.Name = "rmodules_clb";
            this.rmodules_clb.Size = new System.Drawing.Size(120, 94);
            this.rmodules_clb.TabIndex = 17;
            this.rmodules_clb.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(434, 436);
            this.Controls.Add(this.rmodules_clb);
            this.Controls.Add(this.rmodule_cbx);
            this.Controls.Add(this.group_cmb);
            this.Controls.Add(this.modules_clb);
            this.Controls.Add(this.course_cmb);
            this.Controls.Add(this.lastname_txb);
            this.Controls.Add(this.firstname_txb);
            this.Controls.Add(this.pasword_txb);
            this.Controls.Add(this.studentno_txb);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.register_lbl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label register_lbl;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button register_btn;
        private TextBox studentno_txb;
        private TextBox pasword_txb;
        private TextBox firstname_txb;
        private TextBox lastname_txb;
        private ComboBox course_cmb;
        private CheckedListBox modules_clb;
        private ComboBox group_cmb;
        private CheckBox rmodule_cbx;
        private CheckedListBox rmodules_clb;
    }
}