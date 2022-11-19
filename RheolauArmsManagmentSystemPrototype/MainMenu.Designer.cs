namespace RheolauArmsManagmentSystemPrototype
{
    partial class MainMenu
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
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MenuLbl = new System.Windows.Forms.Label();
            this.StockMenuBtn = new System.Windows.Forms.Button();
            this.StaffMenuBtn = new System.Windows.Forms.Button();
            this.ThursdayBookingsBtn = new System.Windows.Forms.Button();
            this.SundayBookingsBtn = new System.Windows.Forms.Button();
            this.ActionsPanel = new System.Windows.Forms.Panel();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navigationPanel.Controls.Add(this.ExitBtn);
            this.navigationPanel.Controls.Add(this.MenuLbl);
            this.navigationPanel.Controls.Add(this.StockMenuBtn);
            this.navigationPanel.Controls.Add(this.StaffMenuBtn);
            this.navigationPanel.Controls.Add(this.ThursdayBookingsBtn);
            this.navigationPanel.Controls.Add(this.SundayBookingsBtn);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(177, 450);
            this.navigationPanel.TabIndex = 0;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExitBtn.BackColor = System.Drawing.Color.Maroon;
            this.ExitBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(3, 416);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(171, 29);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MenuLbl
            // 
            this.MenuLbl.AutoSize = true;
            this.MenuLbl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuLbl.ForeColor = System.Drawing.Color.White;
            this.MenuLbl.Location = new System.Drawing.Point(0, 4);
            this.MenuLbl.Name = "MenuLbl";
            this.MenuLbl.Size = new System.Drawing.Size(170, 24);
            this.MenuLbl.TabIndex = 1;
            this.MenuLbl.Text = " - Menu ------------";
            // 
            // StockMenuBtn
            // 
            this.StockMenuBtn.Location = new System.Drawing.Point(3, 136);
            this.StockMenuBtn.Name = "StockMenuBtn";
            this.StockMenuBtn.Size = new System.Drawing.Size(171, 29);
            this.StockMenuBtn.TabIndex = 4;
            this.StockMenuBtn.Text = "Stock";
            this.StockMenuBtn.UseVisualStyleBackColor = true;
            // 
            // StaffMenuBtn
            // 
            this.StaffMenuBtn.Location = new System.Drawing.Point(3, 101);
            this.StaffMenuBtn.Name = "StaffMenuBtn";
            this.StaffMenuBtn.Size = new System.Drawing.Size(171, 29);
            this.StaffMenuBtn.TabIndex = 3;
            this.StaffMenuBtn.Text = "Staff";
            this.StaffMenuBtn.UseVisualStyleBackColor = true;
            // 
            // ThursdayBookingsBtn
            // 
            this.ThursdayBookingsBtn.Location = new System.Drawing.Point(3, 66);
            this.ThursdayBookingsBtn.Name = "ThursdayBookingsBtn";
            this.ThursdayBookingsBtn.Size = new System.Drawing.Size(171, 29);
            this.ThursdayBookingsBtn.TabIndex = 2;
            this.ThursdayBookingsBtn.Text = "Thursday Bookings";
            this.ThursdayBookingsBtn.UseVisualStyleBackColor = true;
            this.ThursdayBookingsBtn.Click += new System.EventHandler(this.ThursdayBookingsBtn_Click);
            // 
            // SundayBookingsBtn
            // 
            this.SundayBookingsBtn.Location = new System.Drawing.Point(3, 31);
            this.SundayBookingsBtn.Name = "SundayBookingsBtn";
            this.SundayBookingsBtn.Size = new System.Drawing.Size(171, 29);
            this.SundayBookingsBtn.TabIndex = 1;
            this.SundayBookingsBtn.Text = "Sunday Bookings";
            this.SundayBookingsBtn.UseVisualStyleBackColor = true;
            this.SundayBookingsBtn.Click += new System.EventHandler(this.SundayBookingsBtn_Click);
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionsPanel.Location = new System.Drawing.Point(177, 0);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(623, 450);
            this.ActionsPanel.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActionsPanel);
            this.Controls.Add(this.navigationPanel);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel navigationPanel;
        private Label MenuLbl;
        private Button StockMenuBtn;
        private Button StaffMenuBtn;
        private Button ThursdayBookingsBtn;
        private Button SundayBookingsBtn;
        private Panel ActionsPanel;
        private Button ExitBtn;
    }
}