using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
    
namespace Translution.DL
{


    public class CustomerDl
    {
        //instantiating classes
        DataTable dt = new DataTable();
        Dbconnection db = new Dbconnection();

        // this method is used to retrieve data from customers database tables
        public DataTable readCustomerData()
        {



            if (ConnectionState.Closed == db.conn.State)
            {
                db.conn.Open();
            }


            SqlCommand cmd = new SqlCommand("select * from Customers where region is not null", db.conn);

            try
            {

                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                cmd.Dispose();
                db.conn.Close();

            } catch
            {
                throw;
            }
            return dt;
        }

        //this method is used to insert value into the customers database table
        public void insertdata( String CustomerID , String CompanyName  , String ContactName , String ContactTitle , String Address, String  City  ,String Region, String PostalCode , String Country , String Phone ,String Fax)
        {
            if (ConnectionState.Closed == db.conn.State)
            {
                db.conn.Open();
            }


            try
            {
                SqlCommand cmd = new SqlCommand("Insert into  Customers values ('" + CustomerID + "','" + CompanyName + "','" + ContactName + "','" + ContactTitle + "','" + Address + "','" + City + "','" + Region + "','" + PostalCode + "','" + Country + "','" + Phone + "','"+Fax+"')", db.conn);
                cmd.ExecuteNonQuery();
                db.conn.Close();
               

            }
            catch
            {
                throw;
            }
        }

        //this method is used to update data from customers database table
        public void updatedata(String CustomerID, String CompanyName, String ContactName, String ContactTitle, String Address, String City, String Region, String PostalCode, String Country, String Phone, String Fax)
        {

            if (ConnectionState.Closed == db.conn.State)
            {
                db.conn.Open();
            }


            try
            {

                SqlCommand cmd = new SqlCommand("update Customers set CompanyName='" + CompanyName + "',ContactName='" + ContactName + "',ContactTitle='" + ContactTitle + "',Address='" + Address + "',City='" + City + "',Region='" + Region + "',PostalCode='" + PostalCode + "',Country='" + Country + "',Phone='" + Phone + "',Fax='" + Fax + "' where CustomerID="+ CustomerID, db.conn);
                cmd.ExecuteNonQuery();
                db.conn.Dispose();
                db.conn.Close();

            }
            catch
            {
                throw;
            }
        }

        //this method used to delete items from the database using cutomerid  from customers database table
        public void deletedata(String CustomerID)
        {
            if (ConnectionState.Closed == db.conn.State)
            {
                db.conn.Open();
            }

           

            try
            {
                SqlCommand cmd = new SqlCommand("delete from Customers where CustomerID="+ CustomerID, db.conn);
                cmd.ExecuteNonQuery();
                db.conn.Dispose();
                db.conn.Close();
           
                

            }
            catch
            {
                throw;
            }
        }


        // this method is used to search value from the database using the customerid  from customers database table
        public DataTable searchdata(string id)
        {
            if (ConnectionState.Closed == db.conn.State)
            {
                db.conn.Open();
            }



            try
            {
                SqlCommand cmd = new SqlCommand("select * from Customers where CustomerId = "+id, db.conn);
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                cmd.Dispose();
                db.conn.Close();


            }
            catch
            {
                throw;
            }
             return dt;
        }
}
}
