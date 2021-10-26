using System;
using System.IO;

namespace _26._10
{
    static public class Logger{
        static  string NameFile {get; set;}
        static Logger(){
            NameFile = DateTime.Now.ToLongDateString().Replace('.','_') + ".txt";
           // File.AppendAllText(NameFile, $"{DateTime.Now}   - Startt PO" );
            
        }
        static public void Push (string text){
            
             DateTime time = DateTime.Now;
           // File.AppendAllText(NameFile, $"{DateTime.Now}   - Startt PO" );
             File.AppendAllText(NameFile,  $"{time} - {text}\n");
            
            
        }
    }


}
 