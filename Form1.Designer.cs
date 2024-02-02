namespace Assignment_4_3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.grpError = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCloseError = new System.Windows.Forms.Button();
            this.grpError.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(198, 171);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(36, 16);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Location = new System.Drawing.Point(168, 193);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(66, 16);
            this.lblPW.TabIndex = 1;
            this.lblPW.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(240, 164);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(124, 23);
            this.txtUser.TabIndex = 2;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(240, 193);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(124, 23);
            this.txtPW.TabIndex = 3;
            this.txtPW.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(289, 222);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 30);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // grpError
            // 
            this.grpError.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.grpError.Controls.Add(this.btnCloseError);
            this.grpError.Controls.Add(this.lblError);
            this.grpError.ForeColor = System.Drawing.Color.Red;
            this.grpError.Location = new System.Drawing.Point(370, 171);
            this.grpError.Name = "grpError";
            this.grpError.Size = new System.Drawing.Size(144, 74);
            this.grpError.TabIndex = 5;
            this.grpError.TabStop = false;
            this.grpError.Text = "error";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(16, 30);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(112, 32);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Invalid login entry;\r\nplease try again.";
            // 
            // btnCloseError
            // 
            this.btnCloseError.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCloseError.Location = new System.Drawing.Point(114, 0);
            this.btnCloseError.Name = "btnCloseError";
            this.btnCloseError.Size = new System.Drawing.Size(30, 27);
            this.btnCloseError.TabIndex = 1;
            this.btnCloseError.Text = "x";
            this.btnCloseError.UseVisualStyleBackColor = true;
            this.btnCloseError.Click += new System.EventHandler(this.btnCloseError_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 360);
            this.Controls.Add(this.grpError);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblUser);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Education Management System : Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpError.ResumeLayout(false);
            this.grpError.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox grpError;
        private System.Windows.Forms.Button btnCloseError;
        private System.Windows.Forms.Label lblError;
    }
}

