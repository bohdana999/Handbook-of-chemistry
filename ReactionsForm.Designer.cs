namespace Chemestry
{
    partial class ReactionsForm
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
            this.reactionLstBox = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.reactionPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reactionPic)).BeginInit();
            this.SuspendLayout();
            // 
            // reactionLstBox
            // 
            this.reactionLstBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.reactionLstBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.reactionLstBox.FormattingEnabled = true;
            this.reactionLstBox.ItemHeight = 16;
            this.reactionLstBox.Location = new System.Drawing.Point(0, 0);
            this.reactionLstBox.Name = "reactionLstBox";
            this.reactionLstBox.Size = new System.Drawing.Size(380, 873);
            this.reactionLstBox.TabIndex = 0;
            this.reactionLstBox.SelectedIndexChanged += new System.EventHandler(this.reactionLstBox_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(672, 650);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 1;
            // 
            // reactionPic
            // 
            this.reactionPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reactionPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reactionPic.Location = new System.Drawing.Point(380, 0);
            this.reactionPic.Name = "reactionPic";
            this.reactionPic.Size = new System.Drawing.Size(968, 873);
            this.reactionPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reactionPic.TabIndex = 2;
            this.reactionPic.TabStop = false;
            // 
            // ReactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 873);
            this.Controls.Add(this.reactionPic);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.reactionLstBox);
            this.Name = "ReactionsForm";
            this.Text = "Приклади хімічних реакцій";
            ((System.ComponentModel.ISupportInitialize)(this.reactionPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox reactionLstBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox reactionPic;
    }
}