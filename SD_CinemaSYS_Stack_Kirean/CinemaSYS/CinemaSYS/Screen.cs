using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace CinemaSYS
{
    class Screen
    {
        //Instance of Variables
        private int screen_No;
        private int number_Of_Seats;
        private int screen_Type_Id;
        private int screen_Status_Id;

        //no Arg Constructor
        public Screen()
        {
            screen_No = 0;
            number_Of_Seats = 0;
            screen_Type_Id = 0;
            screen_Status_Id = 0;
        }

        //Arg Constructor
        public Screen(int Sno, int numOfSeats, int screenTypeId, int screenStatusId)
        {
            screen_No = Sno;
            number_Of_Seats = numOfSeats;
            screen_Type_Id = screenTypeId;
            screen_Status_Id = screenStatusId;
        }

        //Define Setters
        public void setSno(int Screen_No)
        {
            this.screen_No = Screen_No;
        }
        public void setNumberOfSeats(int Num_Of_Seats)
        {
            this.number_Of_Seats = Num_Of_Seats;
        }
        public void setScreenTypeId(int Screen_Type_Id)
        {
            this.screen_Type_Id = Screen_Type_Id;
        }
        public void setScreenStatusId(int Screen_Status_Id)
        {
            this.screen_Status_Id = Screen_Status_Id;
        }

        //Getters
        public int getScreenNo()
        {
            return screen_No;
        }
        public int getNumberOfSeats()
        {
            return number_Of_Seats;
        }
        public int getScreenTypeId()
        {
            return screen_Type_Id;
        }
        public int getScreenStatusId()
        {
            return screen_Status_Id;
        }
        

        //Define a static method to get all data from Screen table
        public static DataSet getAllScreens(DataSet DS)
        {
            //create an OracleConnection object using the connecting String defined in static
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //define the SQL query to retrieve the data
            String strSQL = "SELECT * FROM Screen ORDER BY Screen_No";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "gas");

            //Close the DB Connnection
            conn.Close();

            //Return the dataset with the required data to the windows form
            return DS;
        }

        public static DataSet getAllRemovedScreens(DataSet DS)
        {
            //create an OracleConnection object using the connecting String defined in static
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //define the SQL query to retrieve the data
            String strSQL = "SELECT * FROM Screen WHERE SCREEN_STATUS_ID = 2";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "gars");

            //Close the DB Connnection
            conn.Close();

            //Return the dataset with the required data to the windows form
            return DS;
        }


        public static DataSet getAllAvailableScreens(DataSet DS)
        {
            //create an OracleConnection object using the connecting String defined in static
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //define the SQL query to retrieve the data
            String strSQL = "SELECT * FROM Screen WHERE SCREEN_STATUS_ID = 1";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "gaas");

            //Close the DB Connnection
            conn.Close();

            //Return the dataset with the required data to the windows form
            return DS;
        }

        //Creating ScreenNo when Add Screen is selected
        public static int nextScreen_No()
        {
            // variable to hold value to be returned
            int intNextScreen_No = 1;

            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX screen_No used
            String strSQL = "SELECT MAX(Screen_No) FROM Screen";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            //If first screenNo, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            //An aggregate function always returns 1 row, even if it contains a NULL value
            // If NULL, then there are no ScreenNo's in the Screen File - start at 1
            //Otherwise add 1 to the value read

            if (!dr.IsDBNull(0))
                //intNextScreenNo = Convert.ToInt32(dr.GetValue(0)) + 1;
                intNextScreen_No = dr.GetInt32(0) + 1;

            //close DB connection
            myConn.Close();

            //return next ScreenkNo
            return intNextScreen_No;
        }

        public void regScreen()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT screen record
            String strSQL = "INSERT INTO Screen VALUES('" + this.screen_No.ToString() +
                "','" + this.number_Of_Seats + "','" + this.screen_Type_Id + "','" + 
                this.screen_Status_Id + "')";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public void getScreen(int Sno)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX screen_No used
            String strSQL = "SELECT * FROM Screen WHERE Screen_No = " + Sno;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                setSno(dr.GetInt32(0));
                setNumberOfSeats(dr.GetInt32(1));
                setScreenTypeId(dr.GetInt32(2));
                setScreenStatusId(dr.GetInt32(3));

            }

            //close DB connection
            myConn.Close();
        }


        public void updScreen()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to UPDATE screen record
            String strSQL = "UPDATE Screen SET Number_Of_Seats = " + this.number_Of_Seats +
                ", Screen_Type_Id = " + this.screen_Type_Id + " WHERE Screen_No = " + this.screen_No;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public void updScreen(int Sno)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to UPDATE screen record
            String strSQL = "UPDATE Screen SET Number_Of_Seats " + this.number_Of_Seats + ", Screen_Type_Id = " + this.screen_Type_Id + " WHERE Screen_No = " + Sno.ToString() + ")";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public void updScreenStatus(int Sno)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to UPDATE screen record
            String strSQL = "UPDATE Screen SET Screen_Status_Id =  " + this.screen_Status_Id +" WHERE Screen_No = " + Sno.ToString();

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public static Boolean isScheduled(string Sno)
        {
            Boolean answer = false;

            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT * FROM Screening WHERE Screen_No = " + Sno.ToString();

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                answer = true;
            }

            //close DB connection
            myConn.Close();
            return answer;
        }

        public static Boolean isAvailable(string Sno)
        {
            Boolean answer = false;

            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT * FROM Screen WHERE Screen_No = " + Sno + " AND Screen_Status_Id = " + 1;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                answer = true;
            }

            //close DB connection
            myConn.Close();
            return answer;
        }

        public static Boolean isRemoved(string Sno)
        {
            Boolean answer = false;

            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT * FROM Screen WHERE Screen_No = " + Sno.ToString() + " AND Screen_Status_Id = 2";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                answer = true;
            }

            //close DB connection
            myConn.Close();
            return answer;
        }


    }
}
