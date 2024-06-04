namespace CursoWindowsForms
{
    partial class Frm_MouseCaptura
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
            this.Btn_Caputa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Caputa
            // 
            this.Btn_Caputa.Location = new System.Drawing.Point(78, 48);
            this.Btn_Caputa.Name = "Btn_Caputa";
            this.Btn_Caputa.Size = new System.Drawing.Size(333, 156);
            this.Btn_Caputa.TabIndex = 0;
            this.Btn_Caputa.UseVisualStyleBackColor = true;
            this.Btn_Caputa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Caputa_MouseDown);
            // 
            // Frm_MouseCaptura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 249);
            this.Controls.Add(this.Btn_Caputa);
            this.Name = "Frm_MouseCaptura";
            this.Text = "Frm_MouseCaptura";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Caputa;
    }
}