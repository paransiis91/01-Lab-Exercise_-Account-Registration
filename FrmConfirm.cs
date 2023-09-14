using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;

        public FrmConfirm()
        {
            InitializeComponent();
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
        }


        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            label9.Text = Convert.ToString(DelStudNo(StudentInfoClass.StudentNo));
            label10.Text = DelProgram(StudentInfoClass.Program);
            label11.Text = DelLastName(StudentInfoClass.LastName);
            label12.Text = DelMiddleName(StudentInfoClass.MiddleName);
            label13.Text = DelFirstName(StudentInfoClass.FirstName);
            label14.Text = Convert.ToString(DelNumAge(StudentInfoClass.Age));
            label15.Text = Convert.ToString(DelNumContactNo(StudentInfoClass.ContactNo));
            label16.Text = DelAddress(StudentInfoClass.Address);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
