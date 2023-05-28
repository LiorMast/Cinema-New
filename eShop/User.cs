using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace eShop
{
    public class User
    {
        private string username;
        private string email;
        private string password;
        private DateTime birthdate;
        private string phone;
        private Cart cart;

        public User(string username, string email, string password, DateTime birthdate, string phone)
        {

            SetUsername(Capitalize(username));
            SetEmail(email);
            SetPassword(password);
            SetBirthdate(birthdate);
            SetPhone(phone);
            cart = new Cart();
        }

        public static string Capitalize(string str) => $"{str[0].ToString().ToUpper()}{str.Substring(1).ToLower()}";

        public string GetUsername()
        {
            return username;
        }

        public void SetUsername(string newUsername)
        {
            if (String.IsNullOrEmpty(newUsername)) throw new Exception("Username Can't be empty!");
            username = newUsername;
        }

        public string GetEmail()
        {
            return email;
        }

        private static bool IsValidEmail(string input)
        {
            Regex regex = new Regex("^[A-Za-z0-9]+@[A-Za-z0-9]+\\.[A-Za-z]{2,}$", RegexOptions.IgnoreCase);
            return regex.IsMatch(input);
        }

        private static bool IsValidPhone(string input)
        {
            Regex regex = new Regex("^0[0-9]{9}$", RegexOptions.IgnoreCase);
            return regex.IsMatch(input);
        }

        public void SetEmail(string newEmail)
        {
            if (IsValidEmail(newEmail))
            {
                email = newEmail;
            }
            else
            {
                throw new Exception("Invalid email format.");
            }
        }

        public void SetPhone(string newPhone)
        {
            if (IsValidPhone(newPhone))
            {
                phone = newPhone;
            }
            else
            {
                throw new Exception("Invalid phone format.");
            }
        }

        public string GetPhone() => phone;

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string newPassword)
        {
            if (String.IsNullOrEmpty(newPassword)) throw new Exception("Password Can't be empty!");
            password = newPassword;
        }

        public DateTime GetBirthdate()
        {
            return birthdate;
        }
        public void SetBirthdate(DateTime dateTime)
        {
            if (dateTime >= DateTime.Today)
            {
                throw new Exception("Date of birth must be in the past!");
            }
            try
            {
                this.birthdate = dateTime;
            }
            catch (Exception)
            {
                throw new Exception("Invalid birthdate.");
            }
        }
        public Cart GetCart()
        {
            return cart;
        }

        public override string ToString()
        {
            return $"Username: {username}\nEmail: {email}\nPassword: {password}\nBirthdate: {birthdate}\n";
        }

    }
}
