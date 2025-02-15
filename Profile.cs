using System;

namespace DatingProfile
{ 
  class Profile{
private string name;
private int age;
private string city;
private string country;
private string pronouns;
private string[] hobbies;
    public Profile(string name, int age, string city, string country, string pronouns){
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;

    }
    public string ViewProfile(){

      string bio = $"{this.name} {this.age} \n{this.city} {this.country} \n{this.pronouns} \nMy Hobbies";
      int i = 1;
     
      foreach(string hobby in this.hobbies){
        bio +=  $"\n{i}: {hobby}";
        i++;
      }
      return bio;
    }
    public void SetHobbies(string[] hobbies){
      this.hobbies = hobbies;

    }
  }
}
