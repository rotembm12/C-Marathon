using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp
{
    public class UsersFileGenerator
    {

        public static void CreateUsersFile()
        {
            string[] lines = new string[80];
            for (int i = 0; i < lines.Length; i++)
            {
                string name = GetRandomName();
                string gender =GetRandomGender();
                int age = GetRandomNumber(18, 60);
                string password = GetRandomNumber(100000, 999999).ToString();

                string line = $"{name},{gender},{age}|{name},{password}";
                lines[i] = line;    
            }
            File.WriteAllLines("./users.txt", lines);
        }

        public static string GetRandomName()
        {
            string[] names = new string[]
            {
                "Abbey", "Abbigail", "Aaliyah", "Addisyn", "Adilene", "Abdul", "Algie", "Blake",
                "Carli", "Abbigail", "Aaliyah", "Addisyn", "Burrell", "Burrell", "Algie", "Clell",
                "Abbey", "Abbigail", "Blaise", "Addisyn", "Adilene", "Burrell", "Algie", "Alice",
                "Blanche", "Abbigail", "Aaliyah", "Addisyn", "Adilene", "Blair", "Algie", "Clementine",
                "Abbey", "Corine", "Aaliyah", "Addisyn", "Adilene", "Abdul", "Algie", "Alice",
                "Carlota", "Blanche", "Cheyanne", "Addisyn", "Adilene", "Carli", "Cecily", "Briley", "Abbey", "Abbigail", "Aaliyah", "Addisyn", "Adilene", "Abdul", "Algie", "Blake",
                "Carli", "Abbigail", "Dakoda", "Addisyn", "Burrell", "Dalia", "Algie", "Clell",
                "Abbey", "Abbigail", "Darwin", "Addisyn", "Adilene", "Burrell", "Algie", "Alice",
                "Blanche", "Abbigail", "Aaliyah", "Addisyn", "Adilene", "Blair", "Algie", "Clementine",
                "Abbey", "Abbigail", "Aaliyah", "Addisyn", "Adilene", "Abdul", "Algie", "Alice",
                "Cordelia", "Daisha", "Cheyanne", "Addisyn", "Adilene", "Carli", "Dagmar", "Coral"
            };


            int index = GetRandomNumber(0, names.Length - 1);
            return names[index];
        }

        public static string GetRandomGender()
        {
            string[] genders = new string[]
            {"Female", "Male"};


            int index = GetRandomNumber(0, 1);
            return genders[index];
        }

        public static int GetRandomNumber(int min, int max) {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
