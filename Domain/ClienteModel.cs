using DataAccess.WebServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Entities;

namespace Domain
{
    public class ClienteModel
    {
        #region Privadas

        ClienteMaper mapper;

        #endregion
        public ClienteModel()
        {
            mapper = new ClienteMaper();
        }

        #region Metodos Generales

        public List<Cliente> GetAll()
        {
            List<Cliente> result = mapper.GetAll();
            return result;
        }
        public Cliente GetById(int id)
        {
            List<Cliente> result = mapper.GetAll();
            Cliente retorno = null;

            foreach(Cliente cli in result)
            {
                if(cli.Id == id)
                {
                    retorno = cli;
                }
            }

            return retorno;
        }
        public TransactionResult Insert(Cliente cliente)
        {
            List<Cliente> result = mapper.GetAll();

            foreach (Cliente item in result)
            {
                if(item.Id == cliente.Id)
                {
                    throw new ArgumentException($"El cliente {cliente.Nombre} | {cliente.Dni} ya existe.");

                }
            }

            TransactionResult response = mapper.Insert(cliente);

            return response;
        }

        #endregion

    }
}
