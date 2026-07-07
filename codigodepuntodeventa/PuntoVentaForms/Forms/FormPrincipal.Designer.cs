namespace PuntoVentaForms.Forms
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private GroupBox gbAbarrotes;
        private GroupBox gbBebidas;
        private GroupBox gbSnacks;

        private Button btnArroz;
        private Button btnAzucar;
        private Button btnPasta;

        private Button btnLeche;
        private Button btnRefresco;
        private Button btnAgua;

        private Button btnGalletas;
        private Button btnPapitas;
        private Button btnChocolate;

        private ListBox lstCarrito;

        private Label lblTotal;

        private Button btnEliminar;
        private Button btnVaciar;
        private Button btnPagar;

        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();

            gbAbarrotes = new GroupBox();
            gbBebidas = new GroupBox();
            gbSnacks = new GroupBox();

            btnArroz = new Button();
            btnAzucar = new Button();
            btnPasta = new Button();

            btnLeche = new Button();
            btnRefresco = new Button();
            btnAgua = new Button();

            btnGalletas = new Button();
            btnPapitas = new Button();
            btnChocolate = new Button();

            lstCarrito = new ListBox();

            lblTotal = new Label();

            btnEliminar = new Button();
            btnVaciar = new Button();
            btnPagar = new Button();

            SuspendLayout();

            BackColor = Color.Honeydew;
            ClientSize = new Size(980,620);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mini Mercado La Canasta";

            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI",18,FontStyle.Bold);
            lblTitulo.Location = new Point(270,20);
            lblTitulo.Text = "🛒 MINI MERCADO LA CANASTA";

            Controls.Add(lblTitulo);

            //-----------------------------------
            // ABARROTES
            //-----------------------------------

            gbAbarrotes.Text="Abarrotes";
            gbAbarrotes.Location=new Point(20,80);
            gbAbarrotes.Size=new Size(280,180);

            btnArroz.Text="🍚 Arroz\nRD$250";
            btnArroz.Size=new Size(80,60);
            btnArroz.Location=new Point(15,30);
            btnArroz.BackColor=Color.LightGreen;
            btnArroz.Click+=btnArroz_Click;

            btnAzucar.Text="🍬 Azúcar\nRD$60";
            btnAzucar.Size=new Size(80,60);
            btnAzucar.Location=new Point(100,30);
            btnAzucar.BackColor=Color.LightGreen;
            btnAzucar.Click+=btnAzucar_Click;

            btnPasta.Text="🍝 Pasta\nRD$80";
            btnPasta.Size=new Size(80,60);
            btnPasta.Location=new Point(185,30);
            btnPasta.BackColor=Color.LightGreen;
            btnPasta.Click+=btnPasta_Click;

            gbAbarrotes.Controls.Add(btnArroz);
            gbAbarrotes.Controls.Add(btnAzucar);
            gbAbarrotes.Controls.Add(btnPasta);

            Controls.Add(gbAbarrotes);

            //-----------------------------------
            // BEBIDAS
            //-----------------------------------

            gbBebidas.Text="Bebidas";
            gbBebidas.Location=new Point(20,280);
            gbBebidas.Size=new Size(280,180);

            btnLeche.Text="🥛 Leche\nRD$70";
            btnLeche.Size=new Size(80,60);
            btnLeche.Location=new Point(15,30);
            btnLeche.BackColor=Color.LightGreen;
            btnLeche.Click+=btnLeche_Click;

            btnRefresco.Text="🥤 Refresco\nRD$50";
            btnRefresco.Size=new Size(80,60);
            btnRefresco.Location=new Point(100,30);
            btnRefresco.BackColor=Color.LightGreen;
            btnRefresco.Click+=btnRefresco_Click;

            btnAgua.Text="💧 Agua\nRD$35";
            btnAgua.Size=new Size(80,60);
            btnAgua.Location=new Point(185,30);
            btnAgua.BackColor=Color.LightGreen;
            btnAgua.Click+=btnAgua_Click;

            gbBebidas.Controls.Add(btnLeche);
            gbBebidas.Controls.Add(btnRefresco);
            gbBebidas.Controls.Add(btnAgua);

            Controls.Add(gbBebidas);

            //-----------------------------------
            // SNACKS
            //-----------------------------------

            gbSnacks.Text="Snacks";
            gbSnacks.Location=new Point(20,480);
            gbSnacks.Size=new Size(280,120);

            btnGalletas.Text="🍪 Galletas\nRD$45";
            btnGalletas.Size=new Size(80,60);
            btnGalletas.Location=new Point(15,30);
            btnGalletas.BackColor=Color.LightGreen;
            btnGalletas.Click+=btnGalletas_Click;

            btnPapitas.Text="🍟 Papitas\nRD$40";
            btnPapitas.Size=new Size(80,60);
            btnPapitas.Location=new Point(100,30);
            btnPapitas.BackColor=Color.LightGreen;
            btnPapitas.Click+=btnPapitas_Click;

            btnChocolate.Text="🍫 Chocolate\nRD$90";
            btnChocolate.Size=new Size(80,60);
            btnChocolate.Location=new Point(185,30);
            btnChocolate.BackColor=Color.LightGreen;
            btnChocolate.Click+=btnChocolate_Click;

            gbSnacks.Controls.Add(btnGalletas);
            gbSnacks.Controls.Add(btnPapitas);
            gbSnacks.Controls.Add(btnChocolate);

            Controls.Add(gbSnacks);

            //-----------------------------------
            // CARRITO
            //-----------------------------------

            lstCarrito.Location=new Point(340,80);
            lstCarrito.Size=new Size(610,340);
            lstCarrito.Font=new Font("Segoe UI",10);

            Controls.Add(lstCarrito);

            //-----------------------------------
            // TOTAL
            //-----------------------------------

            lblTotal.AutoSize=true;
            lblTotal.Font=new Font("Segoe UI",14,FontStyle.Bold);
            lblTotal.Location=new Point(340,440);
            lblTotal.Text="TOTAL: RD$0.00";

            Controls.Add(lblTotal);

            //-----------------------------------
            // BOTONES
            //-----------------------------------

            btnEliminar.Text="Eliminar";
            btnEliminar.Location=new Point(340,500);
            btnEliminar.Size=new Size(150,45);
            btnEliminar.BackColor=Color.Khaki;
            btnEliminar.Click+=btnEliminar_Click;

            Controls.Add(btnEliminar);

            btnVaciar.Text="Vaciar";
            btnVaciar.Location=new Point(520,500);
            btnVaciar.Size=new Size(150,45);
            btnVaciar.BackColor=Color.Orange;
            btnVaciar.Click+=btnVaciar_Click;

            Controls.Add(btnVaciar);

            btnPagar.Text="Pagar";
            btnPagar.Location=new Point(700,500);
            btnPagar.Size=new Size(200,60);
            btnPagar.Font=new Font("Segoe UI",12,FontStyle.Bold);
            btnPagar.BackColor=Color.ForestGreen;
            btnPagar.ForeColor=Color.White;
            btnPagar.Click+=btnPagar_Click;

            Controls.Add(btnPagar);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}