using DataAccess.WebServices;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CuentaModel
    {
        #region Privadas

        CuentaMaper mapper;

        #endregion
        public CuentaModel()
        {
            mapper = new CuentaMaper();
        }

        #region Metodos Generales

        public List<Cuenta> GetAll()
        {
            List<Cuenta> result = mapper.GetAll();
            return result;
        }
        public Cuenta GetById(int id)
        {
            List<Cuenta> result = mapper.GetAll();
            Cuenta retorno = null;

            foreach (Cuenta cuenta in result)
            {
                if (cuenta.Id == id)
                {
                    retorno = cuenta;
                }
            }

            return retorno;
        }
        public Cuenta GetByNumero(int numero)
        {
            List<Cuenta> result = mapper.GetAll();
            Cuenta retorno = null;

            foreach (Cuenta cuenta in result)
            {
                if (cuenta.NumeroCuenta == numero)
                {
                    retorno = cuenta;
                }
            }

            return retorno;
        }
        public TransactionResult Insert(Cuenta cuenta)
        {
            List<Cuenta> result = mapper.GetAll();

            foreach (Cuenta item in result)
            {
                if (item.Id == cuenta.Id)
                {
                    throw new ArgumentException($"La cuenta {cuenta.NumeroCuenta} | {cuenta.Descripcion} ya existe.");

                }
            }

            TransactionResult response = mapper.Insert(cuenta);

            return response;
        }

        #endregion
    }
}
