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

namespace Text_Editor_0._1
{
    public partial class FinalEditForm : Form
    {
        private Form1 _form1 = new Form1();
        private SaveFileDialog _saveFileDialog = new SaveFileDialog();

        public FinalEditForm(Form1 form)
        {
            InitializeComponent();
            _form1 = form;            
            Start();
        }       

        private void Start()
        {
            if (_form1.GetOutputText() != "Output text")
            {
                FinalTextBox.Text = _form1.GetOutputText();
            }
            else
            {
                FinalTextBox.Text = _form1.GetInputText();
            }
        }

        private async void FinalTextSaveBtn_Click(object sender, EventArgs e)
        {
            _saveFileDialog.Filter = "Text files(*.txt)|*.txt|Docx(*.docx)|*.docx";

            if (_saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string fileName = _saveFileDialog.FileName;

            using (FileStream fileStream = new FileStream(fileName, FileMode.Append))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    await streamWriter.WriteLineAsync(FinalTextBox.Text);
                }
            }          

        }

    }
}
