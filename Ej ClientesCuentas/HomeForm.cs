using Domain;
using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_ClientesCuentas
{
    public partial class HomeForm : Form
    {
        #region Privadas

        ClienteModel miCliente;
        CuentaModel miCuenta;

        #endregion
        public HomeForm()
        {
            InitializeComponent();
            FormatoGridPrincipal();

            miCliente = new ClienteModel();
            miCuenta = new CuentaModel();
        }

        #region Metodos Propios
        public Cliente GetClienteById(int id)
        {
            Cliente retorno = null;
            retorno = miCliente.GetById(id);
            return retorno;
        }
        public Cuenta GetCuentaByNumero(int numero)
        {
            Cuenta retorno = null;
            retorno = miCuenta.GetByNumero(numero);
            return retorno;
        }
        public Cuenta GetCuentabyId(int id)
        {
            Cuenta retorno = null;
            retorno = miCuenta.GetById(id);
            return retorno;
        }
        public void IngresarCliente(Cliente unCliente)
        {
            TransactionResult response =  miCliente.Insert(unCliente);
            if (!response.IsOk) { throw new ArgumentException("Error en el ingreso."); }
        }
        public void IngresarCuenta(Cuenta unaCuenta)
        {
            TransactionResult response = miCuenta.Insert(unaCuenta);
            if (!response.IsOk) { throw new ArgumentException("Error en el ingreso."); }
        }
        public void ActualizarClientes()
        {
            List<Cliente> losClientes;
            losClientes = miCliente.GetAll();

            dataGridPrincipal.Visible = true;
            dataGridPrincipal.DataSource = losClientes;
        }
        public void ActualizarCuentas()
        {
            List<Cuenta> lasCuentas;
            lasCuentas = miCuenta.GetAll();

            dataGridPrincipal.Visible = true;
            dataGridPrincipal.DataSource = lasCuentas;
        }

        #endregion

        #region Botones
        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            FormatoSidePanel(btnIngresarCliente);
            ClienteForm unFormulario = new ClienteForm(this);
            this.Hide();
            unFormulario.Show();
        }
        private void btnIngresarCuenta_Click(object sender, EventArgs e)
        {
            FormatoSidePanel(btnIngresarCuenta);
            Cuentas unFormulario = new Cuentas(this);
            this.Hide();
            unFormulario.Show();
        }
        private void btnCargarClientes_Click(object sender, EventArgs e)
        {
            FormatoSidePanel(btnCargarClientes);
            ActualizarClientes();
        }
        private void btnCargarCuentas_Click(object sender, EventArgs e)
        {
            FormatoSidePanel(btnCargarCuentas);
            ActualizarCuentas();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormatoSidePanel(btnSalir);
            DialogResult dialogo = MessageBox.Show("¿Desea salir?", "Cerrar", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #endregion

        #region Formato
        private void FormatoGridPrincipal()
        {
            dataGridPrincipal.BorderStyle = BorderStyle.None;
            dataGridPrincipal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridPrincipal.DefaultCellStyle.SelectionBackColor = Color.FromArgb(142, 236, 217);
            dataGridPrincipal.DefaultCellStyle.SelectionForeColor = Color.FromArgb(0, 0, 0);
        }
        private void FormatoSidePanel(Button currentLocation)
        {
            panelSide.Visible = true;

            if (currentLocation == btnCargarClientes)
            {
                panelSide.BackColor = Color.FromArgb(70, 178, 158);
                panelSide.ForeColor = Color.FromArgb(70, 178, 158);
                panelSide.Height = btnCargarClientes.Height;
                panelSide.Top = btnCargarClientes.Top;
            }
            if (currentLocation == btnCargarCuentas)
            {
                panelSide.BackColor = Color.FromArgb(226, 123, 71);
                panelSide.ForeColor = Color.FromArgb(226, 123, 71);
                panelSide.Height = btnCargarCuentas.Height;
                panelSide.Top = btnCargarCuentas.Top;
            }
            if (currentLocation == btnSalir)
            {
                panelSide.BackColor = Color.FromArgb(238, 58, 89);
                panelSide.ForeColor = Color.FromArgb(238, 58, 89);
                panelSide.Height = btnSalir.Height;
                panelSide.Top = btnSalir.Top;
            }
            if(currentLocation == btnIngresarCliente)
            {
                panelSide.BackColor = Color.FromArgb(231, 192, 86);
                panelSide.ForeColor = Color.FromArgb(231, 192, 86);
                panelSide.Height = btnIngresarCliente.Height;
                panelSide.Top = btnIngresarCliente.Top;
            }
            if (currentLocation == btnIngresarCuenta)
            {
                panelSide.BackColor = Color.FromArgb(175, 46, 160);
                panelSide.ForeColor = Color.FromArgb(175, 46, 160);
                panelSide.Height = btnIngresarCuenta.Height;
                panelSide.Top = btnIngresarCuenta.Top;
            }
        }

        #endregion

    }
}
