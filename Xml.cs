using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace _26._10
{
    public class Xmll{


        public void SaveXml(Listt listUser){
             // write
             XmlSerializer formatter = new XmlSerializer(typeof(Listt));
             using(FileStream stream = new FileStream("user.xml", FileMode.OpenOrCreate)){
                 formatter.Serialize(stream, listUser);
             }
        }
        public Listt LoadXml(){
             //      read
            Listt listUserLoad = new Listt();
            XmlSerializer formatter = new XmlSerializer(typeof(Listt));
            using(FileStream stream = new FileStream("user.xml", FileMode.OpenOrCreate)){
               return  listUserLoad = (Listt)formatter.Deserialize(stream);
            }
        }
    }




}