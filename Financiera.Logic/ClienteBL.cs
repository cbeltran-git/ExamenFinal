using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financiera.Core;
using Financiera.Data;

namespace Financiera.Logic
{
    public class ClienteBL
    {
        public static List<Cliente> Listar()
        {
            using (var db = new FinancieraEntities())
            {
                return db.Cliente.ToList();
            }
        }
    }
}
