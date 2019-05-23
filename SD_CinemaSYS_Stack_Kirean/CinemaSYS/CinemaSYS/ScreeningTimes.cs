using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSYS
{
    class ScreeningTimes
    {
        private int screening_Times_Id;
        private string screening_Times;

        //Arg Constructor
        public ScreeningTimes(int Screening_Times_Id, string Screening_Times)
        {
            screening_Times_Id = Screening_Times_Id;
            screening_Times = Screening_Times;
        }

        //Define Setters
        public void setScreeningTimesId(int Screening_Times_Id)
        {
            this.screening_Times_Id = Screening_Times_Id;
        }
        public void setScreenTimes(string Screening_Times)
        {
            this.screening_Times = Screening_Times;
        }


        //Getters
        public int getScreeningTimesId()
        {
            return screening_Times_Id;
        }
        public string getScreeningTimes()
        {
            return screening_Times;
        }

        //Define a static method to get all data from Screening table
        public static DataSet getAllScreeningTimes(DataSet DS)
        {
            //create an OracleConnection object using the connecting String defined in static
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //define the SQL query to retrieve the data
            String strSQL = "SELECT * FROM Screening_Times ORDER BY Screening_Time_Id";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "gasct");

            //Close the DB Connnection
            conn.Close();

            //Return the dataset with the required data to the windows form
            return DS;
        }



    }
}
