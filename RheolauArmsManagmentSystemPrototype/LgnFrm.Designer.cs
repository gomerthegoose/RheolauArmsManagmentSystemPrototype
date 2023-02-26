namespace RheolauArmsManagmentSystemPrototype
{
    partial class LgnFrm
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
            this.lgnPnl = new System.Windows.Forms.Panel();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.lgnPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lgnPnl
            // 
            this.lgnPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lgnPnl.Controls.Add(this.LoginLbl);
            this.lgnPnl.Controls.Add(this.PasswordTxt);
            this.lgnPnl.Controls.Add(this.UsernameTxt);
            this.lgnPnl.Controls.Add(this.LoginBtn);
            this.lgnPnl.Location = new System.Drawing.Point(12, 12);
            this.lgnPnl.Name = "lgnPnl";
            this.lgnPnl.Size = new System.Drawing.Size(229, 141);
            this.lgnPnl.TabIndex = 0;
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLbl.ForeColor = System.Drawing.Color.White;
            this.LoginLbl.Location = new System.Drawing.Point(3, 0);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(222, 32);
            this.LoginLbl.TabIndex = 4;
            this.LoginLbl.Text = "- Login -------------";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PasswordTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTxt.ForeColor = System.Drawing.Color.White;
            this.PasswordTxt.Location = new System.Drawing.Point(3, 62);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.PlaceholderText = "Password";
            this.PasswordTxt.Size = new System.Drawing.Size(219, 26);
            this.PasswordTxt.TabIndex = 2;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.UsernameTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTxt.ForeColor = System.Drawing.Color.White;
            this.UsernameTxt.Location = new System.Drawing.Point(3, 33);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.PlaceholderText = "Username";
            this.UsernameTxt.Size = new System.Drawing.Size(219, 26);
            this.UsernameTxt.TabIndex = 1;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LoginBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(199)))), ((int)(((byte)(73)))));
            this.LoginBtn.Location = new System.Drawing.Point(3, 106);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(219, 28);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LgnFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(252, 163);
            this.Controls.Add(this.lgnPnl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LgnFrm";
            this.Text = "Login";
            this.Resize += new System.EventHandler(this.LgnFrm_Resize);
            this.lgnPnl.ResumeLayout(false);
            this.lgnPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel lgnPnl;
        private TextBox PasswordTxt;
        private TextBox UsernameTxt;
        private Button LoginBtn;
        private Label LoginLbl;
    }
}