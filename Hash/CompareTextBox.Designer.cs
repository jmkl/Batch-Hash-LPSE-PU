namespace Hash
{
    partial class CompareTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.cek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(21, 10);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(47, 15);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "label1";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(22, 32);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(282, 20);
            this.tb1.TabIndex = 1;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(22, 58);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(282, 20);
            this.tb2.TabIndex = 2;
            // 
            // cek
            // 
            this.cek.Location = new System.Drawing.Point(229, 84);
            this.cek.Name = "cek";
            this.cek.Size = new System.Drawing.Size(75, 23);
            this.cek.TabIndex = 4;
            this.cek.Text = "Cek";
            this.cek.UseVisualStyleBackColor = true;
            this.cek.Click += new System.EventHandler(this.cek_Click);
            // 
            // CompareTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.cek);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lbl);
            this.Name = "CompareTextBox";
            this.Size = new System.Drawing.Size(325, 118);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button cek;
    }
}
