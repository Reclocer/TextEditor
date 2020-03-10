namespace Text_Editor_0._1
{
    partial class FinalEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalEditForm));
            this.FinalTextBox = new System.Windows.Forms.TextBox();
            this.FinalTextSaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FinalTextBox
            // 
            this.FinalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FinalTextBox.Location = new System.Drawing.Point(12, 12);
            this.FinalTextBox.Multiline = true;
            this.FinalTextBox.Name = "FinalTextBox";
            this.FinalTextBox.Size = new System.Drawing.Size(1386, 689);
            this.FinalTextBox.TabIndex = 0;
            // 
            // FinalTextSaveBtn
            // 
            this.FinalTextSaveBtn.Location = new System.Drawing.Point(12, 707);
            this.FinalTextSaveBtn.Name = "FinalTextSaveBtn";
            this.FinalTextSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.FinalTextSaveBtn.TabIndex = 1;
            this.FinalTextSaveBtn.Text = "Сохранить";
            this.FinalTextSaveBtn.UseVisualStyleBackColor = true;
            this.FinalTextSaveBtn.Click += new System.EventHandler(this.FinalTextSaveBtn_Click);
            // 
            // FinalEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 743);
            this.Controls.Add(this.FinalTextSaveBtn);
            this.Controls.Add(this.FinalTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinalEditForm";
            this.Text = "Финальное редактирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FinalTextBox;
        private System.Windows.Forms.Button FinalTextSaveBtn;
    }
}