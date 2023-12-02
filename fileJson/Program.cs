using System;
using System.Text.Json;
using System.IO;
using System.Text;



class Program
{
    static void Main(){
    

        var now  = DateTime.Now.TimeOfDay;

        var NameJson = "{\"Name\":\"Nabhan\"";
        var Time = $"{NameJson},\"Time\":\"{now.Hours}\"";
        var finalJson = $"{Time}"+"}";

       

        JsonDocument jsonDocument = JsonDocument.Parse(finalJson);

          JsonElement root =  jsonDocument.RootElement;
          
           Console.WriteLine("Enter name of file");
            var NameFile = Console.ReadLine();


           //string path = @"/home/kali/Desktop/fileJson/myText.txt";
          var lac = NameFile+".json";

           File.WriteAllText(lac,finalJson);
            Console.WriteLine($"{lac} is created");
    }
     
       
        
   
}