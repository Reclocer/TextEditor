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
    public partial class Form1 : Form
    {
        private static string _startTextInputTextBox;
        private Stack<string> _stackBackTexts  = new Stack<string>();
        private Stack<string> _stackFrontTexts = new Stack<string>();

        public Form1()
        {
            InitializeComponent();
            InitializationTextEditor();
        }

        private void InitializationTextEditor()
        {
            _startTextInputTextBox = this.InputTextBox.Text;
        }

        #region Get/Set functions
        public string GetOutputText()
        {
            return OutputTextBox.Text;
        }

        public void SetOutputText(string text)
        {
            OutputTextBox.Text = text;
        }

        public string GetInputText()
        {
            return InputTextBox.Text;
        }
        #endregion

        #region Back-Front text

        private void BackText_Click(object sender, EventArgs e)
        {
            string text = OutputTextBox.Text;
            _stackFrontTexts.Push(text);
            FrontText.Enabled = true;

            try//!!!!
            {
                text = _stackBackTexts.Pop();
            }
            catch
            {

            }            

            if(_stackBackTexts.Count == 0)
            {
                BackText.Enabled = false;
            }

            OutputTextBox.Text = text;
        }

        private void FrontText_Click(object sender, EventArgs e)
        {
            string text = OutputTextBox.Text;
            _stackBackTexts.Push(text);
            BackText.Enabled = true;

            try//!!!!
            {
                text = _stackFrontTexts.Pop();
            }
            catch
            {

            }

            if (_stackFrontTexts.Count == 0)
            {
                FrontText.Enabled = false;
            }

            OutputTextBox.Text = text;
        }

        #endregion

        private void FinalEditBtn_Click(object sender, EventArgs e)
        {
            FinalEditForm finalEditForm = new FinalEditForm(this);

            if (/*OutputTextBox.Text != "" | InputTextBox.Text != ""*/
                 OutputTextBox.Text != "Output text" || InputTextBox.Text != "Input text")
            {
                finalEditForm.Size = this.Size;
                finalEditForm.ShowDialog();  
            }
            else
            {
                MessageBox.Show("Отсутствует текст для редактирования", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region Drag and Drop
        private void Form1_DragEnter(object sender, DragEventArgs textFile)
        {
            if(textFile.Data.GetDataPresent(DataFormats.FileDrop))
            {
                textFile.Effect = DragDropEffects.Copy;

                PanelDragDrop.Visible = true;
                PanelDragDrop.Size = new Size(InputTextBox.Width, PanelDragDrop.Height); 
                PanelDragDrop.Location = new Point(InputTextBox.Location.X, InputTextBox.Location.Y + 20);
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs textFile)
        {
            string[] files = (string[])textFile.Data.GetData(DataFormats.FileDrop);
            
            if (files.Length >= 2)
            {
                MessageBox.Show("Количество файлов не может быть более одного", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PanelDragDrop.Visible = false;
            }
            else 
            {
                StreamReader sr = new StreamReader(files[0]);
                InputTextBox.Text = sr.ReadToEnd();
                PanelDragDrop.Visible = false;
            }           
        }

        private void Form1_DragLeave(object sender, EventArgs textFile)
        {
            PanelDragDrop.Visible = false;
        }

        #endregion
    }
}
