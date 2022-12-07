namespace PROJE0
{
    partial class Form2
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
            this.kontrol21 = new PROJE0.Kontrol2();
            this.SuspendLayout();
            // 
            // kontrol21
            // 
            this.kontrol21.BackColor = System.Drawing.Color.Peru;
            this.kontrol21.Location = new System.Drawing.Point(7, 35);
            this.kontrol21.Name = "kontrol21";
            this.kontrol21.Size = new System.Drawing.Size(1112, 597);
            this.kontrol21.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 674);
            this.Controls.Add(this.kontrol21);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Kontrol2 kontrol21;
    }
}