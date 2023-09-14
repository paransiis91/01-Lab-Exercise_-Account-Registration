using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Account_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            program.Items.Add("Bachelor of Science in Information Technology");
            program.Items.Add("Bachelor of Science in Computer Engineering");
            program.Items.Add("Bachelor of Science in Computer Science");

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.StudentNo = Convert.ToInt64(studentNo.Text.ToString());
            StudentInfoClass.Program = program.Text.ToString();
            StudentInfoClass.FirstName = firstName.Text.ToString();
            StudentInfoClass.LastName = lastName.Text.ToString();
            StudentInfoClass.MiddleName = middleName.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt64(age.Text.ToString());
            StudentInfoClass.ContactNo = Convert.ToInt64(contactNo.Text.ToString());
            StudentInfoClass.Address = address.Text.ToString();

            using (FrmConfirm frmConfirm = new FrmConfirm())
            {
                if (frmConfirm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    studentNo.Clear();
                    program.SelectedIndex = 0;
                    firstName.Clear();
                    lastName.Clear();
                    middleName.Clear();
                    age.Clear();
                    contactNo.Clear();
                    address.Clear();


                }
            }

        }
    }

}