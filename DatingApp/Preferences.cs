using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp
{
     public class Preferences
    {
        int[] ageRange;
        string gender;

        public Preferences(int[] ageRange, string gender)
        {
            AgeRange = ageRange;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"Age Between {ageRange[0]} - {ageRange[1]}, prefered gender: {Gender}";
        }

        public static bool IsValidSuggestion(User user, Preferences pref)
        {
            return (
                user.Age > pref.ageRange[0] 
                && user.Age < pref.ageRange[1] 
                && user.Gender.ToLower() == pref.Gender.ToLower()
            );
        }
        public int[] AgeRange { get => ageRange; set => ageRange = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
