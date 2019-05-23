using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace CinemaSYS
{
    class AgeRating
    {

        //Instance of Variables
        private int age_Rating_Id;
        private char age_Rating;

        //no Arg Constructor
        public AgeRating()
        {
            age_Rating_Id = 0;
            age_Rating = ' ';
        }

        //Arg Constructor
        public AgeRating(int ageRatingId, Char ageRating)
        {
            age_Rating_Id = ageRating;
            age_Rating = ageRating;
        }

        //Define Setters
        public void setAgeRatingId(int Age_Rating_Id)
        {
            this.age_Rating_Id = Age_Rating_Id;
        }
        public void setScreenType(Char Age_Rating)
        {
            this.age_Rating = Age_Rating;
        }

        //Getters
        public int getAgeRatingId()
        {
            return age_Rating_Id;
        }
        public Char getAgeRating()
        {
            return age_Rating;
        }

        public static DataSet getAgeRatings(DataSet DS)
        {
            //create an OracleConnection object using the connecting String defined in static
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //define the SQL query to retrieve the data
            String strSQL = "SELECT * FROM AgeRating";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleDataAdapter to hold the result of the executed OracleCommad
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Fill the dataset DS with the query result
            da.Fill(DS, "gar");

            //Close the DB Connnection
            conn.Close();

            //Return the dataset with the required data to the windows form
            return DS;
        }

    }
}
