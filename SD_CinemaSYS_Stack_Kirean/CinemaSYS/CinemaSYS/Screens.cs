using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSYS
{
    class Screens
    {
        //instance of vars
        private int screen_No;
        private int number_Of_Seats;
        private int screen_Status_ID;
        private int screen_Type_ID;

        //no arg constructor
        public Screens()
        {
            screen_No = 0;
            number_Of_Seats = 0;
            screen_Status_ID = 0;
            screen_Type_ID = 0;
        }

        //define a static method to get all stock form stock table
        public static DataSet getDataSet(DataSet DS)
        {
            //create an OracleConnection object using the connecting String defined in static
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //define the SQL query to retrieve the data
            String strSQL = "SELECT * FROM Stock";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleDataAdapter to hold the result of the executed OracleCommad
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the dataset DS with the query result
            da.Fill(DS, "stk");

            //Close the DB Connnection
            conn.Close();

            //Return the dataset with the required data to the windows form
            return DS;

        }


    }
}
