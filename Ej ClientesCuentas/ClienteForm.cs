using Repositories;
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
    public partial class ClienteForm : Form
    {
        #region Privadas

        HomeForm miPadre;

        #endregion
        public ClienteForm(HomeForm parent)
        {
            InitializeComponent();
            miPadre = new HomeForm();
            miPadre = parent;
        }

        #region Metodos Propios

        private void ValidarCampos()
        {
            //Validacion Dni
            if(!int.TryParse(txtDni.Text, out int dni))
            {
                MessageBox.Show("El campo Dni solo permite numeros.", "Dato invalido");
                return;
            }
            if (txtDni.Text == null
                || txtDni.Text.Length != 8)
            {
                MessageBox.Show("El campo Dni debe tener 8 numeros.", "Dato invalido");
                return;
            }
            //Validacion Nombre y Apellido
            if(txtNombre.Text == null
                || txtNombre.Text.Length < 1
                || txtApellido.Text == null
                || txtApellido.Text.Length < 1)
            {
                MessageBox.Show("Los campos Nombre y Apellido son requeridos.", "Dato invalido");
                return;
            }
            //Validacion Direccion
            if (txtDireccion.Text == null
                || txtDireccion.Text.Length < 1)
            {
                MessageBox.Show("El campo Direccion es requerido.", "Dato invalido");
                return;
            }
            //Validacion Email
            if (txtEmail.Text == null
                || txtEmail.Text.Length < 1)
            {
                MessageBox.Show("El campo Email es requerido.", "Dato invalido");
                return;
            }
            //Validacion Telefono
            if (txtTelefono.Text == null
                || txtTelefono.Text.Length < 1)
            {
                MessageBox.Show("El campo Telefono es requerido.", "Dato invalido");
                return;
            }

            Cliente unCliente = new Cliente();
            unCliente.Dni = dni;
            unCliente.Nombre = txtNombre.Text;
            unCliente.Apellido = txtApellido.Text;
            unCliente.Direccion = txtDireccion.Text;
            unCliente.Email = txtEmail.Text;
            unCliente.Telefono = txtTelefono.Text;

            try
            {
                miPadre.IngresarCliente(unCliente);
                MessageBox.Show("Cliente ingresado.", "Ingreso exitoso");
                Volver();
            }
            catch(ArgumentException ex) { MessageBox.Show(ex.Message, "Error"); }
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
            miPadre.ActualizarClientes();
            Volver();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }
        #endregion

        #region Formato
        #endregion
    }
}
