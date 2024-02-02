namespace Assignment_4_3
{
    partial class LoginPurgatory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPurgatory));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGoodBehavior = new System.Windows.Forms.Button();
            this.btnBadBehavior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(784, 480);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 158);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "This is login jail.... you will now sit here for an undetermined amount of time. " +
    "Good behavior may reduce your sentence.\r\n\r\nMAY reduce your sentence......\r\n\r\nEnj" +
    "oy your stay!\r\n\r\n- Management";
            // 
            // btnGoodBehavior
            // 
            this.btnGoodBehavior.Location = new System.Drawing.Point(953, 644);
            this.btnGoodBehavior.Name = "btnGoodBehavior";
            this.btnGoodBehavior.Size = new System.Drawing.Size(89, 43);
            this.btnGoodBehavior.TabIndex = 1;
            this.btnGoodBehavior.Text = "good behavior";
            this.btnGoodBehavior.UseVisualStyleBackColor = true;
            this.btnGoodBehavior.Click += new System.EventHandler(this.btnGoodBehavior_Click);
            // 
            // btnBadBehavior
            // 
            this.btnBadBehavior.Location = new System.Drawing.Point(858, 644);
            this.btnBadBehavior.Name = "btnBadBehavior";
            this.btnBadBehavior.Size = new System.Drawing.Size(89, 43);
            this.btnBadBehavior.TabIndex = 2;
            this.btnBadBehavior.Text = "bad behavior";
            this.btnBadBehavior.UseVisualStyleBackColor = true;
            // 
            // LoginPurgatory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 809);
            this.Controls.Add(this.btnBadBehavior);
            this.Controls.Add(this.btnGoodBehavior);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPurgatory";
            this.Text = "Login Purgatory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGoodBehavior;
        private System.Windows.Forms.Button btnBadBehavior;
    }
}