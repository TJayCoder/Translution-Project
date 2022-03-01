using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Translution.DL;



namespace Translution.BL
{
    public class CustomerBl
    {

        public DataTable getCustomers()
        {

            try {

                CustomerDl customer = new CustomerDl();
                return customer.readCustomerData();
            }
            catch
            {
                throw;
            }
        }



    }
}
