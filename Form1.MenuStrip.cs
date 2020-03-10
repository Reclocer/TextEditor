using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor_0._1
{
    partial class Form1
    {
        #region File
        private async void OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*|Docx(*.docx)|*.docx";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string fileName = openFileDialog.FileName;
            InputTextBox.Clear();

            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    InputTextBox.Text = await streamReader.ReadToEndAsync();
                }
            }                                
        }        

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
