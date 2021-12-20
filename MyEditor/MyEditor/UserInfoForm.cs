using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditor
{
    public partial class UserInfoForm : Form
    {
        public UserInfoForm()
        {
            InitializeComponent();
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            //purvi nachin
            ValidateInputs(tbFirstName, epFirstName);
        }

        private void tbLastName_Validated(object sender, EventArgs e)
        {
            //vtori nachin
            ValidateInputs((TextBox)sender, epLastName);
        }

        private void ValidateInputs(TextBox tb, ErrorProvider ep)
        {
            if (tb.Text == "")
            {
                ep.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                ep.BlinkRate = 100;
                ep.Icon = Properties.Resources.iconfinder_sign_error_299045;
                ep.SetError(tb, "Field is empty!");

                tb.BackColor = Color.Red;
            }
            else
            {
                ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                ep.Icon = Properties.Resources.iconfinder_Checkmark_1891021;
                ep.SetError(tb, "OK");

                tb.BackColor = Color.Green;
            }
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs(tbFirstName, epFirstName);
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs(tbLastName, epLastName);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text != "" && tbLastName.Text != "")
            {
                Editor editorForm = new Editor(tbFirstName.Text, tbLastName.Text);
                //editorForm.FirstName = tbFirstName.Text;
                //editorForm.LastName = tbLastName.Text;

                editorForm.ShowDialog();
            }
        }
    }
}
