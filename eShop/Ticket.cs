using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop
{
    public class Ticket : Item
    {
        private Movie movie;
        private string seatNumber;
        private ScreeningTime screeningTime;

        public enum ScreeningTime
        {
            _10AM = 0,
            _13PM,
            _16PM,
            _19PM,
            _22PM
        }

        public Ticket(Movie movie, string seatNumber, ScreeningTime screeningTime, double price) : base(price)
        {
            this.movie = movie;
            SetSeatNumber(seatNumber);
            SetScreeningTime(screeningTime);
        }

        public Movie GetMovie()
        {
            return movie;
        }

        public void SetMovie(Movie newMovie)
        {
            movie = newMovie;
        }

        public string GetSeatNumber()
        {
            return seatNumber;
        }

        public void SetSeatNumber(string newSeatNumber)
        {
            if (string.IsNullOrEmpty(newSeatNumber))
            {
                throw new Exception("Seat number cannot be empty.");
            }

            seatNumber = newSeatNumber;
        }

        public ScreeningTime GetScreeningTime()
        {
            return screeningTime;
        }

        public static string ScreeningTimeToString(ScreeningTime screeningTime)
        {
            string[] hours = { "10:00", "13:00", "16:00", "19:00", "22:00" };
            try{
                return hours[(int)screeningTime];
            }catch(Exception){
                return "Invalid screening time.";
            }
        }

        

        public void SetScreeningTime(ScreeningTime screeningTime)
        {
            // Check if the provided screening time is valid
            if (Enum.IsDefined(typeof(ScreeningTime), screeningTime))
            {
                this.screeningTime = screeningTime;
            }
            else
            {
                throw new ArgumentException("Invalid screening time.");
            }
        }

        public override string ToString()
        {
            return $"{movie.GetTitle()} - {ScreeningTimeToString(screeningTime)} Seat {seatNumber} Price: {GetPrice()}";
        }
    }

}
