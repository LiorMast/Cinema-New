using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace eShop
{
    public class UserCollection
    {
        private User[] users;
        private int currentIndex;

        public UserCollection()
        {
            users = new User[10]; // Initial capacity of 10
            currentIndex = 0;
        }

        public void AddUser(User user)
        {
            if (currentIndex == users.Length)
            {
                // Array is full, resize it
                Array.Resize(ref users, users.Length * 2);
            }

            users[currentIndex] = user;
            File.AppendAllText(@"..\..\Data\Users.txt", $"({user.GetUsername()}, {user.GetEmail()}, {user.GetPassword()}, {user.GetBirthdate()})\n");
            currentIndex++;
        }

        public void DeleteUser(User user)
        {
            int userIndex = Array.IndexOf(users, user, 0, currentIndex);
            if (userIndex != -1)
            {
                for (int i = userIndex; i < currentIndex - 1; i++)
                {
                    users[i] = users[i + 1];
                }

                users[currentIndex - 1] = null;
                currentIndex--;
            }
        }

        public User GetUserByName(string name)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (users[i].GetUsername() == name)
                {
                    return users[i];
                }
            }

            return null;
        }

        public override string ToString()
        {
            string result = "User Collection:\n";
            for (int i = 0; i < currentIndex; i++)
            {
                result += users[i].ToString() + "\n";
            }
            return result;
        }
    }

}
