namespace PuntoVentaForms.Forms
{
    partial class FormFactura
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtFactura;
        private Button btnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            txtFactura = new TextBox();
            btnCerrar = new Button();
            SuspendLayout();

            // txtFactura

            txtFactura.Location = new Point(20, 20);
            txtFactura.Multiline = true;
            txtFactura.ReadOnly = true;
            txtFactura.ScrollBars = ScrollBars.Vertical;
            txtFactura.Font = new Font("Consolas", 11F);
            txtFactura.Size = new Size(460, 500);

            // btnCerrar

            btnCerrar.Location = new Point(180, 540);
            btnCerrar.Size = new Size(140, 45);
            btnCerrar.Text = "Cerrar";
            btnCerrar.BackColor = Color.ForestGreen;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Click += btnCerrar_Click;

            // FormFactura

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(500, 610);
            Controls.Add(txtFactura);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Factura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}