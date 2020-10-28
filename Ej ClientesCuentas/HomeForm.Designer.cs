namespace Ej_ClientesCuentas
{
    partial class HomeForm
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresarCuenta = new System.Windows.Forms.Button();
            this.lblCuentas = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.btnIngresarCliente = new System.Windows.Forms.Button();
            this.btnCargarCuentas = new System.Windows.Forms.Button();
            this.btnCargarClientes = new System.Windows.Forms.Button();
            this.dataGridPrincipal = new System.Windows.Forms.DataGridView();
            this.topPanel = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.panelSide);
            this.leftPanel.Controls.Add(this.btnSalir);
            this.leftPanel.Controls.Add(this.btnIngresarCuenta);
            this.leftPanel.Controls.Add(this.lblCuentas);
            this.leftPanel.Controls.Add(this.lblClientes);
            this.leftPanel.Controls.Add(this.btnIngresarCliente);
            this.leftPanel.Controls.Add(this.btnCargarCuentas);
            this.leftPanel.Controls.Add(this.btnCargarClientes);
            this.leftPanel.Location = new System.Drawing.Point(0, 26);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(141, 373);
            this.leftPanel.TabIndex = 0;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Transparent;
            this.panelSide.Location = new System.Drawing.Point(3, 33);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(10, 27);
            this.panelSide.TabIndex = 14;
            this.panelSide.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(15, 343);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 27);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresarCuenta
            // 
            this.btnIngresarCuenta.FlatAppearance.BorderSize = 0;
            this.btnIngresarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarCuenta.Location = new System.Drawing.Point(15, 189);
            this.btnIngresarCuenta.Name = "btnIngresarCuenta";
            this.btnIngresarCuenta.Size = new System.Drawing.Size(111, 27);
            this.btnIngresarCuenta.TabIndex = 6;
            this.btnIngresarCuenta.Text = "Ingresar Cuenta";
            this.btnIngresarCuenta.UseVisualStyleBackColor = true;
            this.btnIngresarCuenta.Click += new System.EventHandler(this.btnIngresarCuenta_Click);
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentas.Location = new System.Drawing.Point(12, 136);
            this.lblCuentas.Name = "lblCuentas";
            this.lblCuentas.Size = new System.Drawing.Size(74, 20);
            this.lblCuentas.TabIndex = 5;
            this.lblCuentas.Text = "CUENTAS";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(12, 13);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(72, 20);
            this.lblClientes.TabIndex = 4;
            this.lblClientes.Text = "CLIENTES";
            // 
            // btnIngresarCliente
            // 
            this.btnIngresarCliente.FlatAppearance.BorderSize = 0;
            this.btnIngresarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarCliente.Location = new System.Drawing.Point(15, 66);
            this.btnIngresarCliente.Name = "btnIngresarCliente";
            this.btnIngresarCliente.Size = new System.Drawing.Size(111, 27);
            this.btnIngresarCliente.TabIndex = 3;
            this.btnIngresarCliente.Text = "Ingresar Cliente";
            this.btnIngresarCliente.UseVisualStyleBackColor = true;
            this.btnIngresarCliente.Click += new System.EventHandler(this.btnIngresarCliente_Click);
            // 
            // btnCargarCuentas
            // 
            this.btnCargarCuentas.FlatAppearance.BorderSize = 0;
            this.btnCargarCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCuentas.Location = new System.Drawing.Point(15, 156);
            this.btnCargarCuentas.Name = "btnCargarCuentas";
            this.btnCargarCuentas.Size = new System.Drawing.Size(111, 27);
            this.btnCargarCuentas.TabIndex = 2;
            this.btnCargarCuentas.Text = "Cargar Cuentas";
            this.btnCargarCuentas.UseVisualStyleBackColor = true;
            this.btnCargarCuentas.Click += new System.EventHandler(this.btnCargarCuentas_Click);
            // 
            // btnCargarClientes
            // 
            this.btnCargarClientes.FlatAppearance.BorderSize = 0;
            this.btnCargarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarClientes.Location = new System.Drawing.Point(15, 33);
            this.btnCargarClientes.Name = "btnCargarClientes";
            this.btnCargarClientes.Size = new System.Drawing.Size(111, 27);
            this.btnCargarClientes.TabIndex = 1;
            this.btnCargarClientes.Text = "Cargar Clientes";
            this.btnCargarClientes.UseVisualStyleBackColor = true;
            this.btnCargarClientes.Click += new System.EventHandler(this.btnCargarClientes_Click);
            // 
            // dataGridPrincipal
            // 
            this.dataGridPrincipal.AllowUserToAddRows = false;
            this.dataGridPrincipal.AllowUserToDeleteRows = false;
            this.dataGridPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPrincipal.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrincipal.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridPrincipal.Location = new System.Drawing.Point(147, 39);
            this.dataGridPrincipal.Name = "dataGridPrincipal";
            this.dataGridPrincipal.ReadOnly = true;
            this.dataGridPrincipal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridPrincipal.RowHeadersVisible = false;
            this.dataGridPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPrincipal.Size = new System.Drawing.Size(625, 360);
            this.dataGridPrincipal.TabIndex = 1;
            this.dataGridPrincipal.Visible = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(784, 26);
            this.topPanel.TabIndex = 2;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.dataGridPrincipal);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresarCuenta;
        private System.Windows.Forms.Label lblCuentas;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Button btnIngresarCliente;
        private System.Windows.Forms.Button btnCargarCuentas;
        private System.Windows.Forms.Button btnCargarClientes;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.DataGridView dataGridPrincipal;
        private System.Windows.Forms.Panel topPanel;
    }
}