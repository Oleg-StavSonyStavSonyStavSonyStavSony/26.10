using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace _26._10
{

 [Serializable]
 public class User : IDisposable{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public User (){
            FirstName = null;   
            LastName = null;    
            Age = 0;
        }

        public User (string first, string last, int age){
            FirstName = first;
            LastName = last;
            Age = age;
        }
        public override string ToString() =>  $"{FirstName}\n{LastName}-\n{Age}\n------------------------";

        public  void Dispose(){
            GC.Collect(GC.GetGeneration(this));
        }

         /*public List<User> LoadListUser (List<User> list){
            // File.ReadAllLines("text.txt").ToList().ForEach(Console.WriteLine);
            string[] arr = File.ReadAllLines("text.txt");
            int y = 0;
            User user1 = new User();
            for (int i = 0; i < arr.Length; i+=4, y++)
            {
                user1.FirstName = arr[i].Split(":")[1];
                user1.LastName = arr[i+1].Split(":")[1];
                user1.Age = int.Parse(arr[i+2].Split(":")[1]);
                //Console.WriteLine(user1);
                list.Add(user1);
            }
             return list;
            }         public void SeveListUser (List<User> list){
            for (int i = 0; i < list.Count; i++)
            {
            File.AppendAllText("text.txt", $"Name : {list[i].FirstName}\nLName : {list[i].LastName}\nAge : {list[i].Age}\n");
            File.AppendAllText("text.txt",  "--------------------------------------------------------\n");
            }
         }*/
    }
}