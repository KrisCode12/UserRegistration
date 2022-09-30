using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmRegistration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelAge, DelContactNo, DelStudNo;

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            
            label9.Text =  Convert.ToString(DelStudNo(StudentInfoClass.StudentNo));
            label10.Text = DelProgram(StudentInfoClass.Program);
            label11.Text = DelLastName(StudentInfoClass.LastName);
            label12.Text = DelFirstName(StudentInfoClass.FirstName);
            label13.Text = DelMiddleName(StudentInfoClass.MiddleName);
            label14.Text = Convert.ToString(DelAge(StudentInfoClass.Age));
            label15.Text = Convert.ToString(DelContactNo(StudentInfoClass.ContactNo));
            label16.Text = DelAddress(StudentInfoClass.Address);
        }

        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram =new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }
    }
}
