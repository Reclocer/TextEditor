using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor_0._1
{
    partial class Form1
    {                
        private void StartEditText_Click(object sender, EventArgs e)
        {
            string outText = OutputTextBox.Text;

            if (outText != null)
            {
                _stackBackTexts.Push(outText);
                BackText.Enabled = true;
            }

            string text = this.InputTextBox.Text;

            //MessageBox.Show("Please input text", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Trim
            if (Trim.Checked)
            {
                text = text.Trim();
            }





            this.OutputTextBox.Text = text;
        }        

        private void InputTextBox_Click(object sender, EventArgs e)
        {
            string text = this.InputTextBox.Text;

            if (text == _startTextInputTextBox)
            {
                text = "";
                this.InputTextBox.Text = text;
            }
        }

        private void InputTextBox_Leave(object sender, EventArgs e)
        {
            if(InputTextBox.Text == "")
            {
                InputTextBox.Text = _startTextInputTextBox;
            }

        }
    }
}
