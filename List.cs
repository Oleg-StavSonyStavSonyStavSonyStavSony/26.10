using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace _26._10
{
     [Serializable]
    public class Listt : List<User>,IDisposable{
        public Listt(){
           // base = new List<User>();
        }
        public void ADD(User user){
            base.Add(user);
        }
         public  void Dispose(){
            GC.Collect(GC.GetGeneration(this));
        }
    }

}
