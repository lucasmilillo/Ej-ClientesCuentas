using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Entities;

namespace DataAccess.WebServices
{
    public class ClienteMaper
    {
        public List<Cliente> GetAll()
        {
            string json2 = WebHelper.Get("/cliente"); 
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }
        public TransactionResult Insert(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);

            string result = WebHelper.Post("/cliente", obj);

            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }
        private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lst;
        }
        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();

            n.Add("Dni", cliente.Dni.ToString());
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            n.Add("Email", cliente.Email); 
            n.Add("Telefono", cliente.Telefono.ToString()); 

            return n;
        }
        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
