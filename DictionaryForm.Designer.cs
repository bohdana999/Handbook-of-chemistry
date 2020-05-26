namespace Chemestry
{
    partial class DictionaryForm
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
            this.components = new System.ComponentModel.Container();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.phraseLstBox = new System.Windows.Forms.ListBox();
            this.descriptionRTxtBox = new System.Windows.Forms.RichTextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.searchTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchTxtBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTxtBox.Location = new System.Drawing.Point(0, 0);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(1348, 36);
            this.searchTxtBox.TabIndex = 0;
            this.searchTxtBox.TextChanged += new System.EventHandler(this.searchTxtBox_TextChanged);
            // 
            // phraseLstBox
            // 
            this.phraseLstBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.phraseLstBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.phraseLstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phraseLstBox.FormattingEnabled = true;
            this.phraseLstBox.ItemHeight = 20;
            this.phraseLstBox.Location = new System.Drawing.Point(0, 36);
            this.phraseLstBox.Name = "phraseLstBox";
            this.phraseLstBox.Size = new System.Drawing.Size(341, 837);
            this.phraseLstBox.TabIndex = 1;
            this.phraseLstBox.SelectedIndexChanged += new System.EventHandler(this.phraseLstBox_SelectedIndexChanged);
            // 
            // descriptionRTxtBox
            // 
            this.descriptionRTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.descriptionRTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionRTxtBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionRTxtBox.Location = new System.Drawing.Point(341, 36);
            this.descriptionRTxtBox.Name = "descriptionRTxtBox";
            this.descriptionRTxtBox.ReadOnly = true;
            this.descriptionRTxtBox.Size = new System.Drawing.Size(1007, 837);
            this.descriptionRTxtBox.TabIndex = 2;
            this.descriptionRTxtBox.Text = "";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // DictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 873);
            this.Controls.Add(this.descriptionRTxtBox);
            this.Controls.Add(this.phraseLstBox);
            this.Controls.Add(this.searchTxtBox);
            this.Name = "DictionaryForm";
            this.Text = "Тлумачний словник";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.ListBox phraseLstBox;
        private System.Windows.Forms.RichTextBox descriptionRTxtBox;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}