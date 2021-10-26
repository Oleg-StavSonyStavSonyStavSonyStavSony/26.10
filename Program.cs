using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;


namespace _26._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //File.Delete("text.txt");
            Logger.Push("start");
            DateTime tStart = DateTime.Now;
            DateTime tEnd ;
            Console.WriteLine($"Start - {tStart}");
            int cool = 10;
            string truee = (GC.GetTotalMemory(true)).ToString();
            //Console.WriteLine(GC.GetTotalMemory(true));
            /*using( Listt listUser = new Listt()){
            for (var i = 0; i < cool; i++){
                listUser.ADD(new User ("FirstName"+i.ToString(),"LastName"+i.ToString(),18));
                 }
            }
            // listUser.ForEach(Console.WriteLine);*/
            Listt listUser = new Listt();
            for (var i = 0; i < cool; i++){
                listUser.ADD(new User ("FirstName"+i.ToString(),"LastName"+i.ToString(),18));
                }
             Logger.Push("lisst 10 create");
            string falsse = (GC.GetTotalMemory(false)).ToString();
            //Console.WriteLine(DateTime.Now);
            for (var i = 0; i < listUser.Count; i++)
            {
                GC.GetGeneration(listUser[i]);
            }
             Logger.Push("lisst 10 clir");

            tEnd = DateTime.Now;
            Console.WriteLine($"End - {tEnd}");
            File.AppendAllText("text.txt", $"Time Start : {tStart}\nTime End : {tEnd}\ndifference - {(tEnd.Subtract(tStart)).ToString()}\nGetTotalMemory - {truee}\nGetTotalMemory - {falsse}\n------------------------\n");
            //File.Delete("text.txt");
            
            //      write
            Xmll xmll = new Xmll();
           // Classs classs = new Classs(new User{"vase", })
           


            xmll.SaveXml(listUser);
            
            //      read
            Listt listUserLoad = new Listt();
            listUserLoad = xmll.LoadXml();
           foreach (var item in listUserLoad)
           {
               Console.WriteLine(item);
           }

                

        }
    }
}
