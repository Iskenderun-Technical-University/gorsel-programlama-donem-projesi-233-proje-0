namespace PROJE0
{
    partial class Form3
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
            this.kontrol31 = new PROJE0.Kontrol3();
            this.SuspendLayout();
            // 
            // kontrol31
            // 
            this.kontrol31.BackColor = System.Drawing.Color.Peru;
            this.kontrol31.Location = new System.Drawing.Point(-2, 12);
            this.kontrol31.Name = "kontrol31";
            this.kontrol31.Size = new System.Drawing.Size(958, 578);
            this.kontrol31.TabIndex = 0;
            this.kontrol31.Load += new System.EventHandler(this.kontrol31_Load);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 585);
            this.Controls.Add(this.kontrol31);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private Kontrol3 kontrol31;
    }
}