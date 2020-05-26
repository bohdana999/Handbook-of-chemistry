namespace Chemestry
{
    partial class TablesForm
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
            this.tablesLstBox = new System.Windows.Forms.ListBox();
            this.tablePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablePic)).BeginInit();
            this.SuspendLayout();
            // 
            // tablesLstBox
            // 
            this.tablesLstBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tablesLstBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablesLstBox.FormattingEnabled = true;
            this.tablesLstBox.ItemHeight = 16;
            this.tablesLstBox.Location = new System.Drawing.Point(0, 0);
            this.tablesLstBox.Name = "tablesLstBox";
            this.tablesLstBox.Size = new System.Drawing.Size(409, 873);
            this.tablesLstBox.TabIndex = 0;
            this.tablesLstBox.SelectedIndexChanged += new System.EventHandler(this.tablesLstBox_SelectedIndexChanged);
            // 
            // tablePic
            // 
            this.tablePic.BackColor = System.Drawing.Color.White;
            this.tablePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePic.Location = new System.Drawing.Point(409, 0);
            this.tablePic.Name = "tablePic";
            this.tablePic.Size = new System.Drawing.Size(939, 873);
            this.tablePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tablePic.TabIndex = 1;
            this.tablePic.TabStop = false;
            this.tablePic.WaitOnLoad = true;
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1348, 873);
            this.Controls.Add(this.tablePic);
            this.Controls.Add(this.tablesLstBox);
            this.Name = "TablesForm";
            this.Text = "Опорні таблиці";
            ((System.ComponentModel.ISupportInitialize)(this.tablePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox tablesLstBox;
        private System.Windows.Forms.PictureBox tablePic;
    }
}