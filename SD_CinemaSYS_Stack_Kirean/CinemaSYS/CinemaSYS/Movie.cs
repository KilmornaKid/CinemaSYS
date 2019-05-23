using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Collections;

namespace CinemaSYS
{
    class Movie
    {
        //Instance of Variables
        private int movie_Id;
        private String movie_Name;
        private int running_Time;
        private String description;
        private int age_Rating_Id;

        //No Arg Constructor
        public Movie()
        {
            movie_Id = 0;
            movie_Name = "";
            running_Time = 0;
            description = "";
            age_Rating_Id = 0;
        }

        //Arg Constructor
        public Movie(int movieId, String movieName, int runningTime, String descrip, int ageRatingId)
        {
            movie_Id = movieId;
            movie_Name = movieName;
            running_Time = runningTime;
            description = descrip;
            age_Rating_Id = ageRatingId;
        }

        //Define Setters
        public void setMovieId(int Movie_Id)
        {
            this.movie_Id = Movie_Id;
        }
        public void setMovieName(String Movie_Name)
        {
            this.movie_Name = Movie_Name.ToUpper();
        }
        public void setRunningTime(int Running_Time)
        {
            this.running_Time = Running_Time;
        }
        public void setDescription(String Description)
        {
            this.description = Description;
        }
        public void setAgeRatingId(int Age_Rating_Id)
        {
            this.age_Rating_Id = Age_Rating_Id;
        }

        //Getters
        public int getMovieId()
        {
            return movie_Id;
        }
        public String getMovieName()
        {
            return movie_Name;
        }
        public int getRunningTime()
        {
            return running_Time;
        }
        public String getDescription()
        {
            return description;
        }
        public int getAgeRatingId()
        {
            return age_Rating_Id;
        }

        //Define a static method to get all data from Movie table
        public static DataSet getAllMovies(DataSet DS)
        {
            //create an OracleConnection object using the connecting String defined in static
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //define the SQL query to retrieve the data
            String strSQL = "SELECT * FROM Movie ORDER BY Movie_Id";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "gam");

            //Close the DB Connnection
            conn.Close();

            //Return the dataset with the required data to the windows form
            return DS;
        }

        //Creating MovieId when Add Movie is selected
        public static int nextMovie_Id()
        {
            // variable to hold value to be returned
            int intMovie_Id = 1;

            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get MAX Movie_Id used
            String strSQL = "SELECT MAX(Movie_Id) FROM Movie";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query and put result in OracleDataReader object
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first (only) value returned by query
            //If first Movie_Id, assign value 1, otherwise add 1 to MAX value
            dr.Read();

            //An aggregate function always returns 1 row, even if it contains a NULL value
            // If NULL, then there are no MoviedID's in the Movie File - start at 1
            //Otherwise add 1 to the value read

            if (!dr.IsDBNull(0))
                //intMovie_Id = Convert.ToInt32(dr.GetValue(0)) + 1;
                intMovie_Id = dr.GetInt32(0) + 1;

            //close DB connection
            myConn.Close();

            //return next Movie_Id
            return intMovie_Id;
        }

        public void regMovie()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT movie record
            String strSQL = "INSERT INTO Movie VALUES(" + this.movie_Id +
                ",'" + this.movie_Name + "'," + this.running_Time + ",'" +
                this.description  + "'," + this.age_Rating_Id + ")";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public static Movie getMovie(String movieName)
        {

            Movie movie;

            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT * FROM Movie WHERE Name LIKE '%" + movieName.ToUpper() + "%'";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                 movie = new Movie(dr.GetInt32(0), dr.GetString(1), dr.GetInt32(2), dr.GetString(3),dr.GetInt32(4));
            }
            else
            {
                movie = new Movie();
            }

            //close DB connection
            myConn.Close();
            return movie;
        }

        public static Movie getMovieById(int movieId)
        {

            Movie movie;

            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT * FROM Movie WHERE Movie_ID = " + movieId;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                movie = new Movie(dr.GetInt32(0), dr.GetString(1), dr.GetInt32(2), dr.GetString(3), dr.GetInt32(4));
            }
            else
            {
                movie = new Movie();
            }

            //close DB connection
            myConn.Close();
            return movie;
        }


        public void updMovie()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to UPDATE movie record
            String strSQL = "UPDATE Movie SET Name = '" + this.movie_Name.ToUpper() +
                "', Running_Time = " + this.running_Time + ",Description = '" + this.description + "', Age_Rating_Id = " + this.age_Rating_Id + " WHERE Movie_Id = " + this.movie_Id;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }


        public void rmMovie()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to DELETE movie record
            String strSQL = "DELETE FROM Movie WHERE Movie_ID = " + this.movie_Id;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public static Boolean isShowing(string movie_Id)
        {
            Boolean answer = false;

            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            String strSQL = "SELECT * FROM Screening WHERE movie_Id = " + movie_Id;

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
