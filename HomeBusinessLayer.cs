using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using BusinessLayer.BusinessEntities;

namespace BusinessLayer
{
    public class HomeBusinessLayer
    {
        public List<Movie2018Entity> GetMovies2018()
        {
            List<Movie2018Entity> objMovieList = new List<Movie2018Entity>();
            string connectionString =
                    ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlDataReader dr;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetMovieDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //SqlParameter paramName = new SqlParameter();
                //paramName.ParameterName = "@Name";
                //paramName.Value = employee.Name;
                //cmd.Parameters.Add(paramName);

                //SqlParameter paramGender = new SqlParameter();
                //paramGender.ParameterName = "@Gender";
                //paramGender.Value = employee.Gender;
                //cmd.Parameters.Add(paramGender);

                //SqlParameter paramCity = new SqlParameter();
                //paramCity.ParameterName = "@City";
                //paramCity.Value = employee.City;
                //cmd.Parameters.Add(paramCity);

                //SqlParameter paramDateOfBirth = new SqlParameter();
                //paramDateOfBirth.ParameterName = "@DateOfBirth";
                //paramDateOfBirth.Value = employee.DateOfBirth;
                //cmd.Parameters.Add(paramDateOfBirth);

                con.Open();
                dr = cmd.ExecuteReader();               
                while (dr.Read())
                {
                    Movie2018Entity obj = new Movie2018Entity();
                    obj.MovieCode = Convert.ToInt32(dr["MovieCode"]);
                    obj.MovieName = Convert.ToString(dr["Name"]);
                    obj.ReleaseYear = Convert.ToInt32(dr["ReleaseYear"]);
                    obj.genre = Convert.ToString(dr["Genre"]);
                    obj.Runtime = Convert.ToInt32(dr["Runtime"]);
                    obj.IMDBRating = Convert.ToDouble(dr["IMDBRating"]);
                    obj.MovieDetails = Convert.ToString(dr["Details"]);
                    obj.Director = Convert.ToString(dr["Director"]);
                    obj.Actor = Convert.ToString(dr["Actor"]);
                    obj.BoxOfficeCollection = Convert.ToInt32(dr["BoxOffice"]);
                    obj.ImageId = Convert.ToString(dr["ImageId"]);


                    objMovieList.Add(obj);



                }
                return objMovieList;
            }
        }

        public List<MovieReviewEntity> GetReviewList(string movieCode = null, string action = null ,  string genre = null, string performance = null, string direction =null, string editing =null , string writing =null)
        {
            List<MovieReviewEntity> objMovieList = new List<MovieReviewEntity>();
            string connectionString =
                    ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlDataReader dr;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spIMDBGetReviewList", con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter paramCode = new SqlParameter();
                paramCode.ParameterName = "@MovieCode";
                paramCode.Value = movieCode;
                cmd.Parameters.Add(paramCode);

                SqlParameter paramAction = new SqlParameter();
                paramAction.ParameterName = "@Action";
                paramAction.Value = action;
                cmd.Parameters.Add(paramAction);


                SqlParameter paramGenre = new SqlParameter();
                paramGenre.ParameterName = "@Genre";
                paramGenre.Value = genre;
                cmd.Parameters.Add(paramGenre);

                SqlParameter paramPerformance = new SqlParameter();
                paramPerformance.ParameterName = "@Performance";
                paramPerformance.Value = Convert.ToInt32(performance);
                cmd.Parameters.Add(paramPerformance);

                SqlParameter paramDirection = new SqlParameter();
                paramDirection.ParameterName = "@Direction";
                paramDirection.Value = Convert.ToInt32(direction);
                cmd.Parameters.Add(paramDirection);

                SqlParameter paramEditing = new SqlParameter();
                paramEditing.ParameterName = "@Editing";
                paramEditing.Value = Convert.ToInt32(editing);
                cmd.Parameters.Add(paramEditing);

                SqlParameter paramWriting = new SqlParameter();
                paramWriting.ParameterName = "@Writing";
                paramWriting.Value = Convert.ToInt32(writing);
                cmd.Parameters.Add(paramWriting);

                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MovieReviewEntity obj = new MovieReviewEntity();
                    obj.MovieCode = Convert.ToString(dr["MovieCode"]);
                    obj.MovieName = Convert.ToString(dr["MovieName"]);
                    obj.ReleaseYear = Convert.ToInt32(dr["MovieYear"]);
                    obj.genre = Convert.ToString(dr["MovieGenre"]);
                    obj.Performances = Convert.ToString(dr["PerformanceScore"]);
                    obj.Direction = Convert.ToString(dr["DirectionScore"]);
                    obj.Editing = Convert.ToString(dr["EditingScore"]);
                    obj.Writing = Convert.ToString(dr["WritingScore"]);
                    obj.Music = Convert.ToString(dr["MusicScore"]);
                    
                    objMovieList.Add(obj);

                }
                return objMovieList;
            }


        }
    }
}
