using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;

namespace ACRRentalCar
{
    public class Conexao
    {
        public static sqlconnection GetConnection()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source = THIAGO_NOTEBOOK; Initial Catalog = DB_LOCADORADECARROS; Integrated Security = True; Pooling = False");
            return cnn;
        }
    }
}

