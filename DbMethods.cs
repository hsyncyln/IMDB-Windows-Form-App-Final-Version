using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImdbFinal
{
    public static class DbMethods
    {

        public static void DbHasPerson(Cast cast)  //Person tablosuna veri ekler
        {

            SqlConnection cnn = new SqlConnection(@"server=.\MSSQLServer01;database=Imdb;trusted_connection=true");

            cnn.Open();

            SqlCommand cmdCast = new SqlCommand("select * from Person where PersonID=@Id", cnn);
            cmdCast.Parameters.AddWithValue("@Id", cast.CastId);

            SqlDataReader sdrCast = cmdCast.ExecuteReader();

            if (sdrCast.HasRows)
            {
                while (sdrCast.Read())
                {
                    cast.BirthDate = sdrCast.GetDateTime(3);
                    cast.City = sdrCast.GetString(4);
                    cast.State = sdrCast.GetString(5);
                    cast.Country = sdrCast.GetString(6);
                    cast.Description = sdrCast.GetString(7);
                }
                sdrCast.Close();
            }
            else
            {
                sdrCast.Close();
                cast.GetInfo();
                SqlCommand cmdAdd = new SqlCommand("insert into Person (PersonID,FirstName,LastName,BirthDate,Description,PosterLink,City,State,Country) " +
                    "values(@PersonID,@FirstName,@LastName,@BirthDate,@Description,@PosterLink,@City,@State,@Country)", cnn);
                cmdAdd.Parameters.AddWithValue("@PersonID", cast.CastId);
                cmdAdd.Parameters.AddWithValue("@FirstName", cast.FirstName);
                cmdAdd.Parameters.AddWithValue("@LastName", cast.LastName);
                cmdAdd.Parameters.AddWithValue("@BirthDate", cast.BirthDate);
                cmdAdd.Parameters.AddWithValue("@Description", cast.Description);
                cmdAdd.Parameters.AddWithValue("@PosterLink", cast.PosterLink);
                cmdAdd.Parameters.AddWithValue("@City", cast.City);
                cmdAdd.Parameters.AddWithValue("@State", cast.State);
                cmdAdd.Parameters.AddWithValue("@Country", cast.Country);

                cmdAdd.ExecuteNonQuery();
            }
            cnn.Close();
        }
        public static void DbHasMovie(Movie movie)
        {
            SqlConnection cnn = new SqlConnection(@"server=.\MSSQLServer01;database=IMDB;trusted_connection=true");

            cnn.Open();

            SqlCommand cmd = new SqlCommand("Select * from Movie where MovieID=@Id ", cnn);
            cmd.Parameters.AddWithValue("@Id", movie.MovieId);

            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    movie.Rate = Convert.ToSingle(sdr[2]);
                    movie.Date = Convert.ToDateTime(sdr[3]);
                    movie.Description = sdr.GetString(4);
                    movie.Poster = sdr[5].ToString();

                }
                sdr.Close();
            }
            else
            {
                sdr.Close();

                movie.GetInfo();

                cmd = new SqlCommand("insert into Movie (MovieID,MovieName,MovieRate,MovieDate,Description,MoviePosterLink) " +
                    "values(@ID,@Name,@Rate,@Date,@Description,@Link)", cnn);
                cmd.Parameters.AddWithValue("@ID", movie.MovieId);
                cmd.Parameters.AddWithValue("@Name", movie.Name);
                cmd.Parameters.AddWithValue("@Rate", movie.Rate);
                cmd.Parameters.AddWithValue("@Date", movie.Date);
                cmd.Parameters.AddWithValue("@Description", movie.Description);
                cmd.Parameters.AddWithValue("@Link", movie.Poster);
                cmd.ExecuteNonQuery();

            }
            cnn.Close();
        }

        public static void DbHasMoviePerson(string movieId, string castId, int roleId)  //Db de Person ve movie bilgileri eklenmişken Mapping tablosuna veri ekler
        {
            SqlConnection cnn = new SqlConnection(@"server=.\MSSQLServer01;database=Imdb;trusted_connection=true");

            cnn.Open();

            SqlCommand cmdMap = new SqlCommand("select count(*) from MoviePerson where MovieID=@movieId " +
                    "and PersonID=@castId and RoleID=@roleId", cnn);
            cmdMap.Parameters.AddWithValue("@movieId", movieId);
            cmdMap.Parameters.AddWithValue("@castId", castId);
            cmdMap.Parameters.AddWithValue("@roleId", roleId.ToString());

            if (cmdMap.ExecuteScalar().ToString() != "1")
            {
                SqlCommand cmdMapping = new SqlCommand("insert into MoviePerson (PersonID,MovieID,RoleID) values(@PersonID,@MovieID,@RoleId)", cnn);

                cmdMapping.Parameters.AddWithValue("@PersonID", castId);
                cmdMapping.Parameters.AddWithValue("@MovieID", movieId);
                cmdMapping.Parameters.AddWithValue("@RoleID", roleId);

                cmdMapping.ExecuteNonQuery();
            }
            cnn.Close();
        }
        public static void DbHasMovieGenre(string movieId, int genreId) //Movie biigisiyle genre için mapping tablosuna veri ekler
        {
            SqlConnection cnn = new SqlConnection(@"server=.\MSSQLServer01;database=Imdb;trusted_connection=true");

            cnn.Open();

            SqlCommand cmdMap = new SqlCommand("select * from MovieGenre where MovieID=@movieId and GenreID=@genreId ", cnn);
            cmdMap.Parameters.AddWithValue("@movieId", movieId);
            cmdMap.Parameters.AddWithValue("@genreId", genreId.ToString());

            SqlDataReader sdrMap = cmdMap.ExecuteReader();

            if (!sdrMap.HasRows)
            {
                sdrMap.Close();

                SqlCommand cmdAdd = new SqlCommand("insert into MovieGenre (MovieID,GenreID) values (@MovieId,@GenreId)", cnn);
                cmdAdd.Parameters.AddWithValue("@GenreID", genreId.ToString());
                cmdAdd.Parameters.AddWithValue("@MovieId", movieId);

                cmdAdd.ExecuteNonQuery();
            }
            sdrMap.Close();
            cnn.Close();
        }
        public static List<Genre> DbFindMovieGenre(string movieId) //Movie biigisiyle genre için mapping tablosuna veri ekler
        {
            SqlConnection cnn = new SqlConnection(@"server=.\MSSQLServer01;database=Imdb;trusted_connection=true");

            cnn.Open();

            SqlCommand cmdMap = new SqlCommand("select g.GenreName,g.GenreUrl from MovieGenre mg inner join Genre g " +
                "on mg.GenreId=g.GenreId where MovieID=@movieId ", cnn);
            cmdMap.Parameters.AddWithValue("@movieId", movieId);

            SqlDataReader sdrMap = cmdMap.ExecuteReader();

            List<Genre> genres = new List<Genre>();

            while (sdrMap.Read())
            {
                Genre genre = new Genre(sdrMap.GetString(0), sdrMap.GetString(1));
                genres.Add(genre);
            }
            sdrMap.Close();
            cnn.Close();
            return genres;
        }
        public static int DbHasGenre(Genre genre) //yeni genre varsa ekler
        {
            SqlConnection cnn = new SqlConnection(@"server=.\MSSQLServer01;database=Imdb;trusted_connection=true");

            cnn.Open();

            SqlCommand cmdMap = new SqlCommand("select GenreUrl from Genre where GenreName=@name ", cnn);
            cmdMap.Parameters.AddWithValue("@name", genre.GenreName);

            if (cmdMap.ExecuteScalar() ==null)
            {
                SqlCommand cmdAdd = new SqlCommand("insert into Genre (GenreName,GenreUrl) values (@name,@url)", cnn);
                cmdAdd.Parameters.AddWithValue("@name", genre.GenreName);
                cmdAdd.Parameters.AddWithValue("@url", genre.GenreUrl);

                cmdAdd.ExecuteNonQuery();
            }

            SqlCommand cmdId = new SqlCommand("select GenreID from Genre where GenreUrl=@url ", cnn);
            cmdId.Parameters.AddWithValue("@url", genre.GenreUrl);

            return Convert.ToInt32(cmdId.ExecuteScalar().ToString());
        }
        public static int DbHasRole(String role) //yeni role varsa ekler
        {
            SqlConnection cnn = new SqlConnection(@"server=.\MSSQLServer01;database=Imdb;trusted_connection=true");

            cnn.Open();

            SqlCommand cmdMap = new SqlCommand("select RoleId from Role where RoleName=@name ", cnn);
            cmdMap.Parameters.AddWithValue("@name", role);


            if (cmdMap.ExecuteScalar()==null)
            {
                SqlCommand cmdAdd = new SqlCommand("insert into Role (RoleName) values (@name)", cnn);
                cmdAdd.Parameters.AddWithValue("@name", role);

                cmdAdd.ExecuteNonQuery();
                
            }

            return Convert.ToInt32(cmdMap.ExecuteScalar().ToString());
        
        }

        public static void DbHasMovieImage(Movie movie)
        {
            SqlConnection cnn = new SqlConnection(@"server=.\MSSQLServer01;database=IMDB;trusted_connection=true");

            cnn.Open();

            SqlCommand cmd = new SqlCommand("Select ImageName,ImageUrl from MovieImage where MovieID=@Id ", cnn);
            cmd.Parameters.AddWithValue("@Id", movie.MovieId);

            SqlDataReader sdr = cmd.ExecuteReader();

            movie.Pictures = new List<Picture>();

            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Picture pic = new Picture(sdr.GetString(0), sdr.GetString(1));
                    movie.Pictures.Add(pic);
                }
                sdr.Close();
            }
            else
            {
                sdr.Close();

                movie.FindPicture();

                foreach(Picture pic in movie.Pictures)
                {
                    cmd = new SqlCommand("insert into MovieImage (MovieID,ImageName,ImageUrl) values(@ID,@Name,@url)", cnn);
                    cmd.Parameters.AddWithValue("@ID", movie.MovieId);
                    cmd.Parameters.AddWithValue("@Name", pic.ImageName);
                    cmd.Parameters.AddWithValue("@url", pic.ImageUrl);
                    cmd.ExecuteNonQuery();

                }
            }
            cnn.Close();
        }
        public static void DbHasPersonImage(Cast person)
        {
            SqlConnection cnn = new SqlConnection(@"server=.\MSSQLServer01;database=IMDB;trusted_connection=true");

            cnn.Open();

            SqlCommand cmd = new SqlCommand("Select ImageName,ImageUrl from PersonImage where PersonID=@Id ", cnn);
            cmd.Parameters.AddWithValue("@Id", person.CastId);

            SqlDataReader sdr = cmd.ExecuteReader();

            person.Pictures = new List<Picture>();

            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Picture pic = new Picture(sdr.GetString(0), sdr.GetString(1));
                    person.Pictures.Add(pic);
                }
                sdr.Close();
            }
            else
            {
                sdr.Close();

                person.FindPicture();

                foreach (Picture pic in person.Pictures)
                {
                    cmd = new SqlCommand("insert into PersonImage (PersonID,ImageName,ImageUrl) values(@ID,@Name,@url)", cnn);
                    cmd.Parameters.AddWithValue("@ID", person.CastId);
                    cmd.Parameters.AddWithValue("@Name", pic.ImageName);
                    cmd.Parameters.AddWithValue("@url", pic.ImageUrl);
                    cmd.ExecuteNonQuery();
                }
            }
            cnn.Close();
        }
        public static void DbHasMovieWatch(Movie movie,int status,double rate)
        {
            SqlConnection cnn = new SqlConnection(@"server=.\MSSQLServer01;database=IMDB;trusted_connection=true");

            cnn.Open();

            SqlCommand cmd = new SqlCommand("Select Id from MovieWatch where MovieID=@Id ", cnn);
            cmd.Parameters.AddWithValue("@Id", movie.MovieId);
            
            if (cmd.ExecuteScalar()!=null)
            {
                cmd = new SqlCommand("Update MovieWatch set Status=@status , MyRate=@rate where MovieId=@id", cnn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@rate", rate);
                cmd.Parameters.AddWithValue("@id", movie.MovieId);
                cmd.ExecuteNonQuery();       
            }
            else
            {
                cmd = new SqlCommand("insert into MovieWatch (Status,MyRate,MovieId) values(@status,@rate,@id)", cnn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@rate", rate);
                cmd.Parameters.AddWithValue("@id", movie.MovieId);
                cmd.ExecuteNonQuery();
            }
            cnn.Close();
        }
        public static string DbFindMyRate(Movie movie)
        {
            SqlConnection cnn = new SqlConnection(@"server=.\MSSQLServer01;database=IMDB;trusted_connection=true");

            cnn.Open();

            SqlCommand cmd = new SqlCommand("Select MyRate from MovieWatch where MovieID=@Id ", cnn);
            cmd.Parameters.AddWithValue("@Id", movie.MovieId);

            if (cmd.ExecuteScalar() != null)
            {
                return cmd.ExecuteScalar().ToString();
            }
            else return "";
        }
        public static List<Movie> DbFindMovieWatch(int status)
        {
            SqlConnection cnn = new SqlConnection(@"server=.\MSSQLServer01;database=IMDB;trusted_connection=true");

            cnn.Open();

            SqlCommand cmd = new SqlCommand("Select distinct m.MovieId,m.MovieName from MovieWatch mw inner join Movie m on mw.MovieId=m.MovieId where Status=@status", cnn);
            cmd.Parameters.AddWithValue("@status", status);
            SqlDataReader sdr = cmd.ExecuteReader();

            List<Movie> list = new List<Movie>();
            while (sdr.Read())
            {
                Movie movie = new Movie(sdr[1].ToString(), sdr[0].ToString());
                list.Add(movie);
            }
            cnn.Close();
            return list;
        }
    }
}
            