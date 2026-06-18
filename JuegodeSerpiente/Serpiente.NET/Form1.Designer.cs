namespace Serpiente
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.SuspendLayout();

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Name = "Form1";
            this.Text = "Juego de la Serpiente";

            this.ResumeLayout(false);
        }
    }
}