namespace Examen1CajeroAutomatico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnDepositar = new Button();
            btnRetirar = new Button();
            btnConsultar = new Button();
            btnSalir = new Button();
            btnLimpiar = new Button();
            txtUsuario = new TextBox();
            txtmonto = new TextBox();
            lblSaldoActual = new Label();
            lstHistorial = new ListBox();
            lblUsuario = new Label();
            lblMonto = new Label();
            lblError = new Label();
            cmnuMenu = new ContextMenuStrip(components);
            cambiarColorDeFondoToolStripMenuItem = new ToolStripMenuItem();
            limpiarHistorialToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            cmnuMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(75, 183);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(94, 29);
            btnDepositar.TabIndex = 0;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(227, 183);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(94, 29);
            btnRetirar.TabIndex = 1;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(384, 183);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(141, 29);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar Saldo";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(685, 407);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(594, 183);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(384, 31);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(130, 27);
            txtUsuario.TabIndex = 5;
            // 
            // txtmonto
            // 
            txtmonto.Location = new Point(384, 73);
            txtmonto.Name = "txtmonto";
            txtmonto.Size = new Size(130, 27);
            txtmonto.TabIndex = 6;
            // 
            // lblSaldoActual
            // 
            lblSaldoActual.AutoSize = true;
            lblSaldoActual.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaldoActual.Location = new Point(319, 120);
            lblSaldoActual.Name = "lblSaldoActual";
            lblSaldoActual.Size = new Size(170, 38);
            lblSaldoActual.TabIndex = 2;
            lblSaldoActual.Text = "Saldo Actual";
            lblSaldoActual.Click += lblSaldoActual_Click;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.Location = new Point(269, 239);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(284, 164);
            lstHistorial.TabIndex = 8;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(319, 38);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 9;
            lblUsuario.Text = "Usuario";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(257, 76);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(121, 20);
            lblMonto.TabIndex = 10;
            lblMonto.Text = "Ingrese el Monto";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(227, 160);
            lblError.Name = "lblError";
            lblError.Size = new Size(13, 20);
            lblError.TabIndex = 11;
            lblError.Text = " ";
            // 
            // cmnuMenu
            // 
            cmnuMenu.ImageScalingSize = new Size(20, 20);
            cmnuMenu.Items.AddRange(new ToolStripItem[] { cambiarColorDeFondoToolStripMenuItem, limpiarHistorialToolStripMenuItem, salirToolStripMenuItem });
            cmnuMenu.Name = "cmnuMenu";
            cmnuMenu.Size = new Size(238, 76);
            cmnuMenu.Text = "Menu";
            // 
            // cambiarColorDeFondoToolStripMenuItem
            // 
            cambiarColorDeFondoToolStripMenuItem.Name = "cambiarColorDeFondoToolStripMenuItem";
            cambiarColorDeFondoToolStripMenuItem.Size = new Size(237, 24);
            cambiarColorDeFondoToolStripMenuItem.Text = "Cambiar color de fondo";
            cambiarColorDeFondoToolStripMenuItem.Click += cambiarColorDeFondoToolStripMenuItem_Click;
            // 
            // limpiarHistorialToolStripMenuItem
            // 
            limpiarHistorialToolStripMenuItem.Name = "limpiarHistorialToolStripMenuItem";
            limpiarHistorialToolStripMenuItem.Size = new Size(237, 24);
            limpiarHistorialToolStripMenuItem.Text = "Limpiar historial";
            limpiarHistorialToolStripMenuItem.Click += limpiarHistorialToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(237, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = cmnuMenu;
            Controls.Add(lblError);
            Controls.Add(lblMonto);
            Controls.Add(lblUsuario);
            Controls.Add(lstHistorial);
            Controls.Add(lblSaldoActual);
            Controls.Add(txtmonto);
            Controls.Add(txtUsuario);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(btnRetirar);
            Controls.Add(btnDepositar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            cmnuMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDepositar;
        private Button btnRetirar;
        private Button btnConsultar;
        private Button btnSalir;
        private Button btnLimpiar;
        private TextBox txtUsuario;
        private TextBox txtmonto;
        private Label lblSaldoActual;
        private ListBox lstHistorial;
        private Label lblUsuario;
        private Label lblMonto;
        private Label lblError;
        private ContextMenuStrip cmnuMenu;
        private ToolStripMenuItem cambiarColorDeFondoToolStripMenuItem;
        private ToolStripMenuItem limpiarHistorialToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ColorDialog colorDialog1;
    }
}
