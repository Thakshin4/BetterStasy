namespace BetterStasy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.password_txb = new System.Windows.Forms.TextBox();
            this.username_txb = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.heading_lbl = new System.Windows.Forms.Label();
            this.error_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(93, 110);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(66, 15);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "Username: ";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(93, 139);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(60, 15);
            this.password_lbl.TabIndex = 1;
            this.password_lbl.Text = "Password:";
            // 
            // password_txb
            // 
            this.password_txb.Location = new System.Drawing.Point(174, 136);
            this.password_txb.Name = "password_txb";
            this.password_txb.Size = new System.Drawing.Size(100, 23);
            this.password_txb.TabIndex = 2;
            // 
            // username_txb
            // 
            this.username_txb.Location = new System.Drawing.Point(174, 107);
            this.username_txb.Name = "username_txb";
            this.username_txb.Size = new System.Drawing.Size(100, 23);
            this.username_txb.TabIndex = 3;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(135, 194);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(135, 223);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(75, 23);
            this.register_btn.TabIndex = 5;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // heading_lbl
            // 
            this.heading_lbl.AutoSize = true;
            this.heading_lbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heading_lbl.ForeColor = System.Drawing.Color.White;
            this.heading_lbl.Location = new System.Drawing.Point(93, 33);
            this.heading_lbl.Name = "heading_lbl";
            this.heading_lbl.Size = new System.Drawing.Size(173, 40);
            this.heading_lbl.TabIndex = 6;
            this.heading_lbl.Text = "BetterStasy";
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.error_lbl.Location = new System.Drawing.Point(93, 166);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(0, 15);
            this.error_lbl.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(342, 261);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.heading_lbl);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.username_txb);
            this.Controls.Add(this.password_txb);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label username_lbl;
        private Label password_lbl;
        private TextBox password_txb;
        private TextBox username_txb;
        private Button login_btn;
        private Button register_btn;
        private Label heading_lbl;
        private Label error_lbl;
    }
}