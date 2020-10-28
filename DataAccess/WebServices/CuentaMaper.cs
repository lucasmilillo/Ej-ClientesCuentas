using Newtonsoft.Json;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.WebServices
{
    public class CuentaMaper
    {
        public List<Cuenta> GetAll()
        {
            string json2 = WebHelper.Get("/cuenta");
            List<Cuenta> resultado = MapList(json2);
            return resultado;
        }
        public TransactionResult Insert(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta);

            string result = WebHelper.Post("/cuenta", obj);

            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;
        }
        private List<Cuenta> MapList(string json)
        {
            List<Cuenta> lst = JsonConvert.DeserializeObject<List<Cuenta>>(json);
            return lst;
        }
        private NameValueCollection ReverseMap(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();

            n.Add("IdCliente", cuenta.IdCliente.ToString());
            n.Add("NumeroCuenta", cuenta.NumeroCuenta.ToString());
            n.Add("Descripcion", cuenta.Descripcion);
            n.Add("Saldo", cuenta.Saldo.ToString());

            return n;
        }
        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
