using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Translution.DL
{

  
    public class Dbconnection
    {
       public SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JKA7826;Initial Catalog=Northwind;User ID=sa;Password=dimakatso");
        
    }
}
