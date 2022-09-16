using System;
using System.Collections.Generic;
using System.Text;

namespace Practic
{
    public  class User
    {
        List<User> userlist = new List<User>();

        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string country { get; set; }
        public User(string name,string surname,int age,string country)
        {
            this.name = name;
            this.age = age;
            this.surname = surname;
            this.country = country;
        }
    }
}
