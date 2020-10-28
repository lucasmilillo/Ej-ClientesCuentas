using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    [DataContract]
    public class Cliente
    {
        #region Atributos
        int id;
        int dni;
        string nombre;
        string apellido;
        string direccion;
        string email;
        string telefono;
        #endregion

        #region Propiedades

        [DataMember(Name = "id")]
        [System.ComponentModel.Browsable(false)]
        public int Id { get => id; private set => id = value; }
        [DataMember(Name = "dni")]
        public int Dni { get => dni; set => dni = value; }
        [DataMember(Name = "nombre")]
        public string Nombre { get => nombre; set => nombre = value; }
        [DataMember(Name = "apellido")]
        public string Apellido { get => apellido; set => apellido = value; }
        [DataMember(Name = "direccion")]
        public string Direccion { get => direccion; set => direccion = value; }
        [DataMember(Name = "email")]
        public string Email { get => email; set => email = value; }
        [DataMember(Name = "telefono")]
        public string Telefono { get => telefono; set => telefono = value; }

        #endregion

        public Cliente() { }
    }
}
