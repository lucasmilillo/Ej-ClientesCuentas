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
    public partial class Cuentas : Form
    {
        #region Privadas

        HomeForm miPadre;

        #endregion
        public Cuentas(HomeForm parent)
        {
            InitializeComponent();
            miPadre = new HomeForm();
            miPadre = parent;
        }

        #region Metodos Privados
        private void ValidarCampos()
        {
            //Validacion IdCliente
            if (!int.TryParse(txtIdCliente.Text, out int idCliente))
            {
                MessageBox.Show("El campo Id.Cliente permite numeros.", "Dato invalido");
                return;
            }
            if (txtIdCliente.Text == null
                || txtIdCliente.Text.Length < 1)
            {
                MessageBox.Show("El campo Id.Clientei debe tener al menos un numero.", "Dato invalido");
                return;
            }
            Cliente unCliente = miPadre.GetClienteById(idCliente);
            if (unCliente == null)
            {
                MessageBox.Show($"No existe un cliente con el ID: {idCliente}.", "Dato invalido");
                return;
            }
            //Validacion Numero de Cuenta
            if (!int.TryParse(txtNumeroCuenta.Text, out int numeroCuenta))
            {
                MessageBox.Show("El campo Numero de Cuenta permite numeros.", "Dato invalido");
                return;
            }
            if (txtNumeroCuenta.Text == null
                || txtNumeroCuenta.Text.Length < 1)
            {
                MessageBox.Show("El campo Numero de Cuenta debe tener al menos un numero.", "Dato invalido");
                return;
            }
            Cuenta unaCuentaRepetida = miPadre.GetCuentaByNumero(numeroCuenta);
            if(unaCuentaRepetida != null)
            {
                MessageBox.Show($"Ya existe una cuenta con el numero {numeroCuenta}.", "Dato invalido");
                return;
            }
            //Validacion Saldo
            if (!int.TryParse(txtSaldo.Text, out int saldo))
            {
                MessageBox.Show("El campo Saldo permite numeros.", "Dato invalido");
                return;
            }
            if (txtSaldo.Text == null
                || txtSaldo.Text.Length < 1)
            {
                MessageBox.Show("El campo Numero de Cuenta debe tener al menos un numero.", "Dato invalido");
                return;
            }
            //Validacion Descripcion
            if (txtDescripcion.Text == null
                || txtDescripcion.Text.Length < 1)
            {
                MessageBox.Show("El campo Descripcion es requerido.", "Dato invalido");
                return;
            }

            Cuenta unaCuenta = new Cuenta();
            unaCuenta.IdCliente = idCliente;
            unaCuenta.NumeroCuenta = numeroCuenta;
            unaCuenta.Saldo = saldo;
            unaCuenta.Descripcion = txtDescripcion.Text;

            try
            {
                miPadre.IngresarCuenta(unaCuenta);
                MessageBox.Show("Cuenta ingresado.", "Ingreso exitoso");
                Volver();
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message, "Error"); }
        }
        private void Volver()
        {
            this.miPadre.Show();
            this.Close();
        }

        #endregion

        #region Botones
        private void btnVolver_Click(object sender, EventArgs e)
        {
            miPadre.ActualizarCuentas();
            Volver();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
        #endregion

        #region Fromato
        private void ActualizarGrid()
        {
            if (int.TryParse(txtIdCliente.Text, out int idCliente))
            {
                Cliente unCliente = miPadre.GetClienteById(idCliente);
                if (unCliente != null)
                {
                    this.lblCliente.Visible = true;
                    this.lblDni.Visible = true;
                    this.lblNombre.Visible = true;
                    this.lblApellido.Visible = true;

                    this.lblDatoDni.Visible = true;
                    this.lblDatoNombre.Visible = true;
                    this.lblDatoApellido.Visible = true;

                    this.lblDatoDni.Text = unCliente.Dni.ToString();
                    this.lblDatoNombre.Text = unCliente.Nombre;
                    this.lblDatoApellido.Text = unCliente.Apellido;
                }
                else
                {
                    this.lblCliente.Visible = false;
                    this.lblDni.Visible = false;
                    this.lblNombre.Visible = false;
                    this.lblApellido.Visible = false;

                    this.lblDatoDni.Visible = false;
                    this.lblDatoNombre.Visible = false;
                    this.lblDatoApellido.Visible = false;
                }
            }
            else
            {
                this.lblCliente.Visible = false;
                this.lblDni.Visible = false;
                this.lblNombre.Visible = false;
                this.lblApellido.Visible = false;

                this.lblDatoDni.Visible = false;
                this.lblDatoNombre.Visible = false;
                this.lblDatoApellido.Visible = false;
            }
        }

        #endregion

    }
}
