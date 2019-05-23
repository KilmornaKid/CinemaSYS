using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace CinemaSYS
{
    class ScreenType
    {

        private int screen_Type_Id;
        private String screen_Type;

        //no Arg Constructor
        public ScreenType()
        {
            screen_Type_Id = 0;
            screen_Type = "";
        }

        //Arg Constructor
        public ScreenType(int screenTypeId, String screenType)
        {
            screen_Type_Id = screenTypeId;
            screen_Type = screenType;
        }

        //Define Setters
        public void setScreenTypeId(int Screen_Type_Id)
        {
            this.screen_Type_Id = Screen_Type_Id;
        }
        public void setScreenType(String Screen_Type)
        {
            this.screen_Type = Screen_Type;
        }

        //Getters
        public int getScreenTypeId()
        {
            return screen_Type_Id;
        }
        public String getScreenType()
        {
            return screen_Type;
        }

        public static DataSet getScreenTypes(DataSet DS)
        {
            //create an OracleConnection object using the connecting String defined in static
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //define the SQL query to retrieve the data
            String strSQL = "SELECT Screen_Type_Id, Screen_Type FROM ScreenTypes";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleDataAdapter to hold the result of the executed OracleCommad
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the dataset DS with the query result
            da.Fill(DS, "gst");

            //Close the DB Connnection
            conn.Close();

            //Return the dataset with the required data to the windows form
            return DS;
        }




    }
}
