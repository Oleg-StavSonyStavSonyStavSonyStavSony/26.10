using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace _26._10
{
     [Serializable]
     public  class Classs{
         public User User { get; set; }
         
         public string Name { get; set; }
         public int Id { get; private set; }
         public Classs()
         {
             User = new User(); 
             Name = null;
             Id = 0;
         }
          public Classs(User user,string name, int id) 
         {
             User = user; 
             Name = name;
             Id =id;
         }
         
         
         
         




     }




}