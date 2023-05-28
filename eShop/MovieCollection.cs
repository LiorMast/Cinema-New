using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace eShop
{
    public class MovieCollection
    {
        private Movie[] movies;
        private int currentIndex;

        public MovieCollection()
        {
            movies = new Movie[10]; // Initial capacity of 10
            currentIndex = 0;
        }

        
        public Movie[] GetMovies()
        {
            return movies;
        }

        public int GetCurrentIndex()
        {
            return currentIndex;
        }

        public void AddMovie(Movie movie)
        {
            if (currentIndex == movies.Length)
            {
                // Array is full, resize it
                Array.Resize(ref movies, movies.Length + 10);
            }

            movies[currentIndex] = movie;
            currentIndex++;
        }

        public void DeleteMovie(string movieName)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (movies[i].GetTitle().Equals(movieName, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < currentIndex - 1; j++)
                    {
                        movies[j] = movies[j + 1];
                    }

                    movies[currentIndex - 1] = null;
                    currentIndex--;
                    return;
                }
            }
        }

        public Movie[] GetMoviesByGenre(string genre)
        {

            MovieCollection moviesByGenre = new MovieCollection();

            foreach (Movie movie in movies)
            {
                if (movie != null && movie.GetGenre().ToString().ToLower().Equals(genre.ToString().ToLower()))
                {
                    moviesByGenre.AddMovie(movie);
                }
            }

            return moviesByGenre.GetMovies();
        }

        public Movie SearchMovieByName(string movieName)
        {
            foreach (Movie movie in movies)
            {
                if (movie != null && movie.GetTitle().ToString().ToLower().Contains(movieName.ToString().ToLower()))
                {
                    return movie;
                }
            }

            return null;
        }

        public void LoadMovies()
        {
            string[] file = File.ReadAllLines(@"..\..\Data\movies.txt");
            string[] lines = new string[file.Length];
            int i = 0;
            int j =0;
            for (; i < file.Length; i++)
            {
                if (file[i].Trim() != "") if (file[i][0] == '(')
                {
                    lines[j++] = file[i].Trim().Replace("(", "").Replace(")", "");
                }
                else continue;
            }
            Array.Resize(ref lines, j);

            foreach (var item in lines)
            {
                string[] temp = item.Split(';');
                for (int k = 0; k < temp.Length; k++)
                {
                    temp[k] = temp[k].Trim().Replace("\"", "");
                }
                
                try { 
                    Movie.Genre gen;
                    Enum.TryParse(temp[3], true, out gen);
                    string path = @"..\..\Data\Posters\" + temp[4];
                    Movie mov = new Movie(temp[0], temp[1], int.Parse(temp[2]), gen, path, temp[5]);
                    this.AddMovie(mov);
                    }   
                    catch (Exception ex) { MessageBox.Show(ex.Message + " " + temp[3]); }


            }
        }


        public override string ToString()
        {
            string output = "";
            foreach (Movie movie in movies)
            {
                if(movie !=null) output += movie.ToString() + "\n";
            }
            return output;
        }
    }

}
