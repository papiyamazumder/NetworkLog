using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NetworkLog
{
    public class Table
    {
        public void GetTable()
        {
            FileStream fs = new FileStream("networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            Console.WriteLine("ID \t\t" + "Source \t\t\t" + "Destination \t\t\t" + "Date \t\t\t" + "Status \t\t" + "Network");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            while (sr.Peek() > -1)
            {
                string line = sr.ReadLine();
                //Console.WriteLine(line);

                if (line != "")
                {
                    if (line.StartsWith("Date"))
                    {
                        string[] date1 = line.Split(' ');
                        string[] date2 = date1[0].Split(':');

                        Console.Write(date2[1] + "\t");
                        Console.Write(date1[1] + " " + date1[2] + "\t");
                    }
                    else
                    {
                        string[] data = line.Split(':');
                        Console.Write(data[1] + "\t\t");
                    }
                    
                }
                else
                {
                    Console.WriteLine("");
                }
                
                



                //foreach (string Data in data)
                //{
                //    Console.WriteLine(Data);
                //}
            }

        }
    }
}
