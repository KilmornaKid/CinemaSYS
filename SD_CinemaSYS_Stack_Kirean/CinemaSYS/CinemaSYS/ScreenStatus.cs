using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSYS
{
    class ScreenStatus
    {
        //Instance of Variables
        private int screen_Status_Id;
        private Char screen_Status;
        private Char description;

        //Arg Constructor
        public ScreenStatus(int screenStatusId, Char screenStatus, Char descrip)
        {
            screen_Status_Id = screenStatusId;
            screen_Status = screenStatus;
            description = descrip;
        }

        //Define Setters
        public void setScreenStatusId(int Screen_Status_Id)
        {
            this.screen_Status_Id = Screen_Status_Id;
        }
        public void setScreenStatus(Char Screen_Status)
        {
            this.screen_Status = Screen_Status;
        }
        public void setDescription(Char Description)
        {
            this.description = Description;
        }


        //Getters
        public int getScreenStatusId()
        {
            return screen_Status_Id;
        }
        public Char getScreenStatus()
        {
            return screen_Status;
        }
        public Char getDescription()
        {
            return description;
        }

        public static DataSet getScreenStatus(DataSet DS)
        {
            //create an OracleConnection object using the connecting String defined in static
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //define the SQL query to retrieve the data
            String strSQL = "SELECT Screen_Status_Id, Description FROM ScreenStatus";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleDataAdapter to hold the result of the executed OracleCommad
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the dataset DS with the query result
            da.Fill(DS, "gss");

            //Close the DB Connnection
            conn.Close();

            //Return the dataset with the required data to the windows form
            return DS;
        }

        

    }
}
