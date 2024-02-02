namespace Assignment_4_3
{
    partial class EMS_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMS_Main));
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.lblGPA = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGrid = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            this.grpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStudents
            // 
            this.gridStudents.BackgroundColor = System.Drawing.Color.Thistle;
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridStudents.Location = new System.Drawing.Point(401, 26);
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.Size = new System.Drawing.Size(630, 424);
            this.gridStudents.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(12, 687);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 30);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // grpAdd
            // 
            this.grpAdd.BackColor = System.Drawing.Color.Thistle;
            this.grpAdd.Controls.Add(this.pictureBox1);
            this.grpAdd.Controls.Add(this.lblLevel);
            this.grpAdd.Controls.Add(this.txtLevel);
            this.grpAdd.Controls.Add(this.lblGPA);
            this.grpAdd.Controls.Add(this.lblLName);
            this.grpAdd.Controls.Add(this.lblFName);
            this.grpAdd.Controls.Add(this.lblID);
            this.grpAdd.Controls.Add(this.txtGPA);
            this.grpAdd.Controls.Add(this.txtLName);
            this.grpAdd.Controls.Add(this.txtFName);
            this.grpAdd.Controls.Add(this.txtID);
            this.grpAdd.Controls.Add(this.btnSubmit);
            this.grpAdd.Controls.Add(this.btnClose);
            this.grpAdd.Location = new System.Drawing.Point(401, 456);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(398, 258);
            this.grpAdd.TabIndex = 6;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Add Student";
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.BackColor = System.Drawing.Color.MediumPurple;
            this.lblGPA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGPA.Location = new System.Drawing.Point(98, 148);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(27, 16);
            this.lblGPA.TabIndex = 17;
            this.lblGPA.Text = "GPA";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.Color.MediumPurple;
            this.lblLName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLName.Location = new System.Drawing.Point(65, 119);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(60, 16);
            this.lblLName.TabIndex = 16;
            this.lblLName.Text = "Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BackColor = System.Drawing.Color.MediumPurple;
            this.lblFName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFName.Location = new System.Drawing.Point(63, 90);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(62, 16);
            this.lblFName.TabIndex = 15;
            this.lblFName.Text = "First Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.MediumPurple;
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.Location = new System.Drawing.Point(101, 61);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 16);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID#";
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(131, 141);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(175, 23);
            this.txtGPA.TabIndex = 13;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(131, 112);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(175, 23);
            this.txtLName.TabIndex = 12;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(131, 83);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(175, 23);
            this.txtFName.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 54);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(175, 23);
            this.txtID.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Thistle;
            this.btnSubmit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(310, 223);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(82, 29);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Thistle;
            this.btnClose.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(367, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 29);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Thistle;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(893, 456);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Thistle;
            this.btnRemove.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(805, 456);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(82, 29);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Thistle;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Location = new System.Drawing.Point(981, 456);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(50, 48);
            this.btnPrint.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnPrint, "Print the highest GPA in the student list.");
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.MediumPurple;
            this.lblLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLevel.Location = new System.Drawing.Point(91, 177);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(34, 16);
            this.lblLevel.TabIndex = 19;
            this.lblLevel.Text = "Level";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(131, 170);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(175, 23);
            this.txtLevel.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblGrid
            // 
            this.lblGrid.AutoSize = true;
            this.lblGrid.BackColor = System.Drawing.Color.MediumPurple;
            this.lblGrid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGrid.Location = new System.Drawing.Point(404, 11);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(67, 16);
            this.lblGrid.TabIndex = 20;
            this.lblGrid.Text = "Student List";
            // 
            // EMS_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 729);
            this.Controls.Add(this.lblGrid);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gridStudents);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EMS_Main";
            this.Text = "Education Management System : Main";
            this.Load += new System.EventHandler(this.EMS_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridStudents;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}