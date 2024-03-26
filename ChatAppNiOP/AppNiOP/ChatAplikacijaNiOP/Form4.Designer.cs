namespace ChatAplikacijaNiOP
{
    partial class Form4
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
            this.PosaljiPoruku = new System.Windows.Forms.Button();
            this.Poruka = new System.Windows.Forms.TextBox();
            this.Poruke = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PosaljiPoruku
            // 
            this.PosaljiPoruku.Location = new System.Drawing.Point(438, 281);
            this.PosaljiPoruku.Name = "PosaljiPoruku";
            this.PosaljiPoruku.Size = new System.Drawing.Size(128, 23);
            this.PosaljiPoruku.TabIndex = 0;
            this.PosaljiPoruku.Text = "PosaljiPoruku";
            this.PosaljiPoruku.UseVisualStyleBackColor = true;
            // 
            // Poruka
            // 
            this.Poruka.Location = new System.Drawing.Point(320, 283);
            this.Poruka.Name = "Poruka";
            this.Poruka.Size = new System.Drawing.Size(100, 20);
            this.Poruka.TabIndex = 1;
            // 
            // Poruke
            // 
            this.Poruke.FormattingEnabled = true;
            this.Poruke.Location = new System.Drawing.Point(320, 177);
            this.Poruke.Name = "Poruke";
            this.Poruke.Size = new System.Drawing.Size(120, 95);
            this.Poruke.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Poruke);
            this.Controls.Add(this.Poruka);
            this.Controls.Add(this.PosaljiPoruku);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PosaljiPoruku;
        private System.Windows.Forms.TextBox Poruka;
        private System.Windows.Forms.ListBox Poruke;
    }
}