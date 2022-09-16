using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Practic
{
    public class Program
    {
        #region task1
        //static void Main(string[] args)
        //{
        //    List<User> users = new List<User>();
        //    users.Add(new User("Ruslan", "Ibrahimov", 22, "Canada"));
        //    users.Add(new User("Kamran", "Agayev", 25, "Rossiya"));
        //    users.Add(new User("Aqil", "Qarayev", 34, "Turkey"));
        //    users.Add(new User("Zahid", "Nureliyev", 8, "Turkey"));
        //    users.Add(new User("Zeyneb", "Qasimova", 5, "Rossiya"));
        //    users.Add(new User("Vidadi", "Salmanov", 10, "Turkey"));
        //    users.Add(new User("Akif", "Qedirov", 15, "Canada"));
        //    users.Add(new User("Riyad", "Ehmedov", 9, "Turkey"));
        //    users.Add(new User("Sona", "Ibrahimova", 21, "Canada"));
        //    users.Add(new User("Revan", "Abbasov", 19, "Rossiya"));

        //    Console.WriteLine("Yaşi 20-den yuxari olan butun istifadeçileri tapin ve onlari Ad Soyadi Yaş olkesi olaraq cap edin: ");

        //    List<User> list = users.Where(u => u.age > 20).ToList();
        //    foreach (User user in list)
        //    {
        //        Console.WriteLine(user.name + " " + user.surname + " " + " " + user.age + " " + user.country);
        //    }

        //    Console.WriteLine(" ");
        //    Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
        //    Console.WriteLine("===================================Qarabag Azerbaycandir=================================");
        //    Console.ResetColor();
        //    Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
        //    Console.WriteLine("===================================Qarabag Azerbaycandir=================================");
        //    Console.ResetColor();
        //    Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
        //    Console.WriteLine("===================================Qarabag Azerbaycandir=================================");
        //    Console.ResetColor();
        //    Console.WriteLine(" ");



        //    Console.WriteLine("Turkiyeye aid olan ve Yaşi 10-dan yuxari olan butun istifadəcileri silin: ");

        //    users.RemoveAll(u => u.country == "Turkey");

        //    List<User> AGE = users.Where(a => a.age > 10).ToList();
        //    foreach (User user in AGE)
        //    {
        //        Console.WriteLine(user.name + " " + user.surname + " " + " " + user.age + " " + user.country);
        //    }
        //}
        #endregion

        #region task2
        public class DelegateExercises
        {
            public delegate int MyDelegate(int intValue);

            public int Method1(int intMethod1)
            {
                return intMethod1 * 2;
            }

            public int Method2(int intMethod2)
            {
                return intMethod2 * 10;
            }

            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                int result1 = myDelegate(10);
                Console.WriteLine(result1);
                myDelegate = new MyDelegate(Method2);
                int result2 = myDelegate(10);
                Console.WriteLine(result2);
            }
        }
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises(); delegateExercises.Method3();
        }


        #endregion
    }
}
