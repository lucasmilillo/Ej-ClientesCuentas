using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    [DataContract]
    public class Cuenta
    {
        #region Privadas
        int id;
        int idCliente;
        int numeroCuenta;
        string descripcion;
        int saldo;
        #endregion

        #region Propiedades
        [DataMember(Name = "id")]
        [System.ComponentModel.Browsable(false)]
        public int Id { get => id; private set => id = value; }
        [DataMember(Name = "idCliente")]
        public int IdCliente { get => idCliente; set => idCliente = value; }
        [DataMember(Name = "nroCuenta")]
        public int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
        [DataMember(Name = "descripcion")]
        public string Descripcion { get => descripcion; set => descripcion = value; }
        [DataMember(Name = "saldo")]
        public int Saldo { get => saldo; set => saldo = value; }
        #endregion
        public Cuenta() { }
    }
}
