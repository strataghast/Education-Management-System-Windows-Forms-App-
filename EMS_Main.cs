using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_4_3
{
    public partial class EMS_Main : Form
    {
        static string filename;
        const string path = @"C:\Users\brett\OneDrive\Desktop\Programming\MSSA\20483C\Module 5\Assignment 4-3\Print\";
        public EMS_Main()
        {
            InitializeComponent();
        }

        private void EMS_Main_Load(object sender, EventArgs e)
        {
            gridStudents.DataSource = Data.studentData.ToList();
            grpAdd.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grpAdd.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grpAdd.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Data.studentData.Add(new Student() { Id = Int32.Parse(txtID.Text), FName = txtFName.Text, LName = txtLName.Text, GPA = double.Parse(txtGPA.Text), Level = txtLevel.Text });
            RefreshData();
        }
        private void RefreshData()
        {
            txtID.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtGPA.Clear();
            txtLevel.Clear();
            gridStudents.DataSource = null;
            gridStudents.DataSource = Data.studentData.ToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this record?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                Data.studentData.RemoveAt(gridStudents.CurrentRow.Index);
                RefreshData();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Data.studentData.Sort();
            Data.studentData.Reverse();
            string highGPA = Data.studentData[0].ToString();

            filename = "CurrentHighGPA";
            string tempFile = path + filename + ".txt";
            StreamWriter sw = null;
            try
            {
                if(!File.Exists(tempFile))
                {
                    sw = File.CreateText(tempFile);
                    sw.WriteLine($"Highest GPA is {highGPA}.\nCurrent time is {DateTime.Now}.");
                }
                else
                {
                    File.AppendAllText(tempFile, $"\nNew line created at {DateTime.Now}.");
                }
            }
            catch( Exception ex )
            {
                MessageBox.Show( ex.ToString() );
            }
            finally
            {
                if(sw != null )
                    sw.Close();
            }
            MessageBox.Show("Highest GPA Printed.", "Print Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
