using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace CinemaSYS
{
    class Sale
    {
        

        //Instance of Variables
        private int sale_Id;
        private int screening_Number;
        private DateTime date_of_Booking;
        private int rate_Id;

        //no Arg Constructor
        public Sale()
        {
            sale_Id = 0;
            screening_Number = 0;
            rate_Id = 0;
        }

        //Arg Constructor
        public Sale(int SaleId, int ScreeningNumber, DateTime date_of_Booking, int RateId)
        {
            sale_Id = SaleId;
            screening_Number = ScreeningNumber;
            rate_Id = RateId;
        }

        //Define Setters
        public void setSaleId(int Sale_Id)
        {
            this.sale_Id = Sale_Id;
        }
        public void setScreeningNumber(int Screening_Number)
        {
            this.screening_Number = Screening_Number;
        }
        public void setDateOfSale(DateTime Date_of_Sale)
        {
            this.date_of_Booking = Date_of_Sale;
        }
        public void setRateId(int Rate_Id)
        {
            this.rate_Id = Rate_Id;
        }

        //Getters
        public int getSaleId()
        {
            return sale_Id;
        }
        public int getScreeningNumber()
        {
            return screening_Number;
        }
        public DateTime getDateOfSale()
        {
            return date_of_Booking;
        }
        public int getRateId()
        {
            return rate_Id;
        }

        public static int nextSale_Id()
        {
            // variable to hold value to be returned
            int intNextSale_Id = 1;

            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(Sale_Id) FROM Sale";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (!dr.IsDBNull(0))
                intNextSale_Id = dr.GetInt32(0) + 1;

            myConn.Close();

            return intNextSale_Id;
        }

        public void regSale()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //string dateOne = this.date_of_Booking.ToString("dd/MM/yyyy");

            //Define SQL query to INSERT movie record
            String strSQL = "INSERT INTO Sale VALUES(" + this.sale_Id +
                "," + this.screening_Number + "," +
                this.rate_Id+")";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        

    }
}
