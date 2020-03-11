namespace Text_Editor_0._1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartEditText = new System.Windows.Forms.Button();
            this.FinalEditBtn = new System.Windows.Forms.Button();
            this.BackText = new System.Windows.Forms.Button();
            this.FrontText = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.Trim = new System.Windows.Forms.CheckBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PanelDragDrop = new System.Windows.Forms.Panel();
            this.AddTextLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.PanelDragDrop.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartEditText
            // 
            resources.ApplyResources(this.StartEditText, "StartEditText");
            this.StartEditText.Name = "StartEditText";
            this.StartEditText.UseVisualStyleBackColor = true;
            this.StartEditText.Click += new System.EventHandler(this.StartEditText_Click);
            // 
            // FinalEditBtn
            // 
            resources.ApplyResources(this.FinalEditBtn, "FinalEditBtn");
            this.FinalEditBtn.Name = "FinalEditBtn";
            this.FinalEditBtn.UseVisualStyleBackColor = true;
            this.FinalEditBtn.Click += new System.EventHandler(this.FinalEditBtn_Click);
            // 
            // BackText
            // 
            resources.ApplyResources(this.BackText, "BackText");
            this.BackText.Name = "BackText";
            this.BackText.UseVisualStyleBackColor = true;
            this.BackText.Click += new System.EventHandler(this.BackText_Click);
            // 
            // FrontText
            // 
            resources.ApplyResources(this.FrontText, "FrontText");
            this.FrontText.Name = "FrontText";
            this.FrontText.UseVisualStyleBackColor = true;
            this.FrontText.Click += new System.EventHandler(this.FrontText_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // InputTextBox
            // 
            resources.ApplyResources(this.InputTextBox, "InputTextBox");
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Click += new System.EventHandler(this.InputTextBox_Click);
            this.InputTextBox.Leave += new System.EventHandler(this.InputTextBox_Leave);
            // 
            // OutputTextBox
            // 
            resources.ApplyResources(this.OutputTextBox, "OutputTextBox");
            this.OutputTextBox.Name = "OutputTextBox";
            // 
            // Trim
            // 
            resources.ApplyResources(this.Trim, "Trim");
            this.Trim.Name = "Trim";
            this.Trim.UseVisualStyleBackColor = true;
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            resources.ApplyResources(this.toolStripComboBox1, "toolStripComboBox1");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.Exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            resources.ApplyResources(this.OpenFile, "OpenFile");
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            resources.ApplyResources(this.Exit, "Exit");
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Text.txt";
            // 
            // PanelDragDrop
            // 
            this.PanelDragDrop.Controls.Add(this.AddTextLabel);
            resources.ApplyResources(this.PanelDragDrop, "PanelDragDrop");
            this.PanelDragDrop.Name = "PanelDragDrop";
            // 
            // AddTextLabel
            // 
            resources.ApplyResources(this.AddTextLabel, "AddTextLabel");
            this.AddTextLabel.Name = "AddTextLabel";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelDragDrop);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Trim);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FrontText);
            this.Controls.Add(this.BackText);
            this.Controls.Add(this.FinalEditBtn);
            this.Controls.Add(this.StartEditText);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.DragLeave += new System.EventHandler(this.Form1_DragLeave);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelDragDrop.ResumeLayout(false);
            this.PanelDragDrop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartEditText;
        private System.Windows.Forms.Button FinalEditBtn;
        private System.Windows.Forms.Button BackText;
        private System.Windows.Forms.Button FrontText;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.CheckBox Trim;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel PanelDragDrop;
        private System.Windows.Forms.Label AddTextLabel;
    }
}

