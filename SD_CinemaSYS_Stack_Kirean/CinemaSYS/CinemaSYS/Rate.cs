using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace CinemaSYS
{
    class Rate
    {
        //Instance of Variables
        private int rate_Id;
        private string rate_name;
        private string rate_Price;
        private string description;

        //no Arg Constructor
        public Rate()
        {
            rate_Id = 0;
            rate_name = "";
            rate_Price = "";
            description = "";
        }

        //Arg Constructor
        public Rate(int RateId, string RateName, string RatePrice, string Description)
        {
            rate_Id = RateId;
            rate_name = RateName;
            rate_Price = RatePrice;
            description = Description;
        }

        //Define Setters
        public void setSaleId(int Rate_Id)
        {
            this.rate_Id = Rate_Id;
        }
        public void setScreeningNumber(string Rate_Name)
        {
            this.rate_name = Rate_Name;
        }
        public void setDateOfSale(string Rate_Price)
        {
            this.rate_Price = Rate_Price;
        }
        public void setDescription(string Description)
        {
            this.description = Description;
        }

        //Getters
        public int getRateId()
        {
            return rate_Id;
        }
        public string getRateName()
        {
            return rate_name;
        }
        public string getRatePrice()
        {
            return rate_Price;
        }
        public string getDescription()
        {
            return description;
        }

        public static DataSet getAllRates(DataSet DS)
        {
            //create an OracleConnection object using the connecting String defined in static
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //define the SQL query to retrieve the data
            String strSQL = "SELECT * FROM Rate ORDER BY Rate_Id";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "rat");

            //Close the DB Connnection
            conn.Close();

            //Return the dataset with the required data to the windows form
            return DS;
        }

        
    }
}
