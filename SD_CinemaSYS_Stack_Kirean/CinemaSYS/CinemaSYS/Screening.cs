using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSYS
{
    class Screening
    {

        private int screening_Number;
        DateTime date_From;
        DateTime date_To;
        private int time;
        private int max_Seats;
        private int seats_Available;
        private int movie_Id;
        private int screen_No;

        public Screening()
        {
            screening_Number = 0;
            max_Seats = 0;
            seats_Available = 0;
            movie_Id = 0;
            screen_No = 0;
        }

        public Screening(int screeningNumber, DateTime dateFrom, DateTime dateTo, int tim, int maxSeats, int seatsAvailable, int movieId, int screenNo)
        {
            screening_Number = screeningNumber;
            date_From = dateFrom;
            date_To = dateTo;
            time = tim;
            max_Seats = maxSeats;
            seats_Available = seatsAvailable;
            movie_Id = movieId;
            screen_No = screenNo;
        }

        public void setScreeningNumber(int Screening_Number)
        {
            this.screening_Number = Screening_Number;
        }
        public void setDateFrom(DateTime Date_From)
        {
            this.date_From = Date_From;
        }
        public void setDateTo(DateTime Date_To)
        {
            this.date_To = Date_To;
        }
        public void setTime(int Time)
        {
            this.time = Time;
        }
        public void setMaxSeats(int Max_Seats)
        {
            this.max_Seats = Max_Seats;
        }
        public void setSeatsAvailable(int Seats_Available)
        {
            this.seats_Available = Seats_Available;
        }
        public void setMovieId(int Movie_Id)
        {
            this.movie_Id = Movie_Id;
        }
        public void setScreenNo(int Screen_No)
        {
            this.screen_No = Screen_No;
        }

        //Getters
        public int getScreeningNo()
        {
            return screening_Number;
        }
        public DateTime getDateFrom()
        {
            return date_From;
        }
        public DateTime getDateTo()
        {
            return date_To;
        }
        public int getTime()
        {
            return time;
        }
        public int getMaxSeats()
        {
            return max_Seats;
        }
        public int getSeatsAvailable()
        {
            return seats_Available;
        }
        public int getMovieId()
        {
            return movie_Id;
        }
        public int getScreenNo()
        {
            return screen_No;
        }

        //Define a static method to get all data from Screening table
        public static DataSet getAllScreenings(DataSet DS)
        {
            //create an OracleConnection object using the connecting String defined in static
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //define the SQL query to retrieve the data
            String strSQL = "SELECT * FROM Screening ORDER BY Screening_Number";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "gasc");

            //Close the DB Connnection
            conn.Close();

            //Return the dataset with the required data to the windows form
            return DS;
        }

        public void getScreening(int screeningNumber)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX screening_Number used
            String strSQL = "SELECT * FROM Screening WHERE Screening_Number = " + screeningNumber;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //If first screening_Number, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {
                setScreeningNumber(dr.GetInt32(0));
                setDateFrom(Convert.ToDateTime(dr.GetString(1)));
                setDateTo(Convert.ToDateTime(dr.GetString(2)));
                setTime(dr.GetInt32(3));
                setMaxSeats(dr.GetInt32(4));
                setSeatsAvailable(dr.GetInt32(5));
                setScreenNo(dr.GetInt32(6));
                setMovieId(dr.GetInt32(7));
            }
            //close DB connection
            myConn.Close();
        }


        public void getScreeningTwo(int movie_Id)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX screening_Number used
            String strSQL = "SELECT MIN(Date_From), MAX(Date_To) FROM Screening WHERE movie_Id = " + movie_Id;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //If first screening_Number, assign value 1, otherwise add 1 to MAX value
            if (dr.Read())
            {
                setDateFrom(Convert.ToDateTime(dr.GetString(0)));
                setDateTo(Convert.ToDateTime(dr.GetString(1)));
            }
            //close DB connection
            myConn.Close();
        }


        public void updScreen()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            string dateOne = this.date_From.ToString("dd/MM/yyyy");
            string dateTwo = this.date_To.ToString("dd/MM/yyyy");

            //Define SQL query to UPDATE screening record
            String strSQL = "UPDATE Screening SET Date_From = '" + dateOne +
                "',Date_To = '" + dateTwo + "',Screening_Time_Id = '" + this.time + "',Max_Seats = " +
                this.max_Seats + ",Seats_Available = " + this.seats_Available + ",Movie_Id = " + this.movie_Id + ",Screen_No = " + this.screen_No + " WHERE Screening_Number = " + this.screening_Number;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public void updAvailSeats()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();
   
            String strSQL = "UPDATE Screening SET Seats_Available = " + (this.seats_Available-1) + " WHERE Screening_Number = " + this.screening_Number;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }


        public void regScreening()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //String dateOne = String.Format("{0:dd-MM-yy}", this.date_From);
            //String DateTwo = String.Format("{0:dd-MM-yy}", this.date_To);
            //String time = String.Format("{0:HH:mm:ss}", this.time);


            string dateOne = this.date_From.ToString("dd/MM/yyyy");
            string dateTwo = this.date_To.ToString("dd/MM/yyyy");

            //Define SQL query to INSERT screening record
            String strSQL = "INSERT INTO Screening VALUES(" + this.screening_Number + ",'" + dateOne +
                "','" + dateTwo + "','" + this.time + "'," +
                this.max_Seats + ","+ this.seats_Available + "," + this.screen_No + "," + this.movie_Id + ")";

            /*String strSQL = "INSERT INTO Screening VALUES(" + this.screening_Number + ",'" + this.date_From +
                "','" +  this.date_To + "','" + this.time + "'," +
                this.max_Seats + "," + this.seats_Available + "," + this.movie_Id + "," + this.screen_No + ")";*/

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public static int nextScreening_Number()
        {
            // variable to hold value to be returned
            int intNextScreening_Number = 1;

            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT MAX(Screening_Number) FROM Screening";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (!dr.IsDBNull(0))
                intNextScreening_Number = dr.GetInt32(0) + 1;

            myConn.Close();

            return intNextScreening_Number;
        }

        public void rmScreening()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to DELETE screen record
            String strSQL = "DELETE FROM Screening WHERE Screening_Number = " + this.screening_Number;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }


        public static DataSet getAllScreeningsOne(DataSet DS)
        {
            //create an OracleConnection object using the connecting String defined in static
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //define the SQL query to retrieve the data
            String strSQL = "SELECT movie_Id, name FROM movie";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleDataAdapter to hold the result of the executed OracleCommad
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the dataset DS with the query result
            da.Fill(DS, "scrs");

            //Close the DB Connnection
            conn.Close();

            //Return the dataset with the required data to the windows form
            return DS;
        }


        public static Boolean isTimeAvailable(string movie_Name, string date, int cboIndex)
        {
            Boolean answer = false;

            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT * FROM Screening FULL OUTER JOIN Movie ON Screening.movie_Id = Movie.MOVIE_ID WHERE movie_Name = ";

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

        public static Boolean isBooked(string screening_number)
        {
            Boolean answer = false;

            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT * FROM Sale WHERE screening_Number = " + screening_number;

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

        public static Boolean isTimeBooked(string screening_Time, string screening_Number, string dateFrom, string dateTo)
        {
            Boolean answer = false;
            int counter = 0;

            string date_from2 = dateFrom;
            string date_To2 = dateFrom;
            int screenNo = Int32.Parse(screening_Number);

            //System.Windows.Forms.MessageBox.Show("BreakOne");


            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT count(*) " +
                            "FROM Screening screen INNER JOIN Screening_Times times " +
                            "ON screen.SCREENING_TIME_ID = times.SCREENING_TIME_ID" +
                            " WHERE to_date(screen.DATE_TO,'DD/MM/YYYY') >=  to_date('" + date_from2 + "', 'DD/MM/YYYY') AND to_date(screen.DATE_FROM,'DD/MM/YYYY') <= to_date('" + date_To2 + "', 'DD/MM/YYYY') " +
                            "AND screen_no = " + screening_Number + " AND screening_Time = '" + screening_Time +"'";


            //System.Windows.Forms.MessageBox.Show("Break2");


            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                counter = dr.GetInt32(0);
            }

            if(counter != 0)
            {
                answer = true;
            }
            //close DB connection
            myConn.Close();

            return answer;
        }

        public static DataSet getTimes( string sno, string selectedDate)
        {
            DataSet DS = new DataSet();

            int screenNo = Int32.Parse(sno);

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT * " +
                            "FROM Screening " +
                            "WHERE to_date('" + selectedDate + "', 'DD/MM/YYYY') BETWEEN to_date('date_From', 'DD/MM/YYYY') AND to_date('date_To', 'DD/MM/YYYY') " +
                            "AND screen_No = " + screenNo;

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Create an oracleDataAdapter to hold the result of the executed OracleCommad
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the dataset DS with the query result
            da.Fill(DS, "getTimes");

            //Close the DB Connnection
            myConn.Close();

            //Return the dataset with the required data to the windows form
            return DS;
        }

    }
}
