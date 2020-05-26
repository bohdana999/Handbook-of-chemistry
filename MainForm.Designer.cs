namespace Chemestry
{
    partial class MainForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.tablesBtn = new System.Windows.Forms.Button();
            this.reactionsBtn = new System.Windows.Forms.Button();
            this.dictionaryBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLbl.Location = new System.Drawing.Point(108, 54);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(226, 37);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Довідник з Хімії";
            // 
            // tablesBtn
            // 
            this.tablesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tablesBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tablesBtn.Location = new System.Drawing.Point(77, 133);
            this.tablesBtn.Name = "tablesBtn";
            this.tablesBtn.Size = new System.Drawing.Size(300, 40);
            this.tablesBtn.TabIndex = 1;
            this.tablesBtn.Text = "Опорні таблиці";
            this.tablesBtn.UseVisualStyleBackColor = false;
            this.tablesBtn.Click += new System.EventHandler(this.tablesBtn_Click);
            // 
            // reactionsBtn
            // 
            this.reactionsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.reactionsBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reactionsBtn.Location = new System.Drawing.Point(77, 196);
            this.reactionsBtn.Name = "reactionsBtn";
            this.reactionsBtn.Size = new System.Drawing.Size(300, 40);
            this.reactionsBtn.TabIndex = 2;
            this.reactionsBtn.Text = "Хімічні реакції";
            this.reactionsBtn.UseVisualStyleBackColor = false;
            this.reactionsBtn.Click += new System.EventHandler(this.reactionsBtn_Click);
            // 
            // dictionaryBtn
            // 
            this.dictionaryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dictionaryBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dictionaryBtn.Location = new System.Drawing.Point(77, 253);
            this.dictionaryBtn.Name = "dictionaryBtn";
            this.dictionaryBtn.Size = new System.Drawing.Size(300, 40);
            this.dictionaryBtn.TabIndex = 3;
            this.dictionaryBtn.Text = "Тлумачний словник";
            this.dictionaryBtn.UseVisualStyleBackColor = false;
            this.dictionaryBtn.Click += new System.EventHandler(this.dictionaryBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitBtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(124, 386);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(198, 40);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Вихід";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(196)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(449, 472);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.dictionaryBtn);
            this.Controls.Add(this.reactionsBtn);
            this.Controls.Add(this.tablesBtn);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Довідник з хімії (Риба Б.О. КІ-19)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button tablesBtn;
        private System.Windows.Forms.Button reactionsBtn;
        private System.Windows.Forms.Button dictionaryBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

