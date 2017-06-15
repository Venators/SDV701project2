using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV701Project2
{
    public partial class InputBox : Form
    {
        private string _Answer;

        public string Answer
        {
            get{return _Answer;}

            set{_Answer = value;}
        }

        public InputBox(string prQuestion)
        {
            InitializeComponent();
            lblQuestion.Text = prQuestion;
            txtbxAnswer.Focus();
            ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtbxAnswer.Text.Length > 0 && txtbxAnswer.Text.Length < 2)
            {
                Answer = txtbxAnswer.Text;
                DialogResult = DialogResult.OK;
            }
            else
            {
                lblError.Text = "Please enter a valid digit";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
