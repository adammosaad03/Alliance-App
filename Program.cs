using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile will = new Profile("will sentance", 30, "New York", "USA", "he/him");
      string[] willsHobbies =  new string[]{"coding", "coding", "coding"};
      will.SetHobbies(willsHobbies);
      Console.WriteLine(will.ViewProfile());
    }
  }
}
