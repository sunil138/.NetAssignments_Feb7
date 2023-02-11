using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling_Feb8
{
    class Program
    {
        class FileWrite
        {
            public void WriteData()
            {
                FileStream fs = new FileStream("C:\\Files\\test.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                Console.WriteLine("Enter the text which you want to write to the file");
                string str = Console.ReadLine();
                sw.WriteLine(str);
                sw.Flush();
                sw.Close();
                sw.Close();

            }
        }

        class FileRead
        {
            public void ReadData()
            {
                FileStream fs = new FileStream("C:\\Files\\test.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine("Program to show content of test file");
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                string str = sr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
                Console.ReadLine();
                sr.Close();
                fs.Close();

            }
        }
        class ReadFromCurrent
        {
            public void readDataCurrent() 
            {
                FileStream fs = new FileStream("C:\\Files\\test.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine("Program to show content of test file");
                sr.BaseStream.Seek(0, SeekOrigin.Current);
                string str = sr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
                Console.ReadLine();
                sr.Close();
                fs.Close();
            }
        }

        public class ReadFromEnd
            {
               public void readDataEnd()
               {
                FileStream fs = new FileStream("C:\\Files\\test.txt", FileMode.Open, FileAccess.Read);  
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine("Program to show content of test file");
                sr.BaseStream.Seek(-1,SeekOrigin.End);   
                string str = sr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
                Console.ReadLine();
                sr.Close();
                fs.Close();
               } 
            }
        static void Main(string[] args)
        {
            FileWrite wr = new FileWrite();
            FileRead fr = new FileRead();
            ReadFromCurrent rc = new ReadFromCurrent();
            ReadFromEnd re = new ReadFromEnd(); 
            Console.WriteLine("Choose the option to Read or Write:");
            Console.WriteLine("1. Read data from beginning  2. Write the data to file 3. Read from current  4.Read from end");
            string str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    fr.ReadData();
                    break; 
                case "2":
                    wr.WriteData();
                    break;
                case "3":
                    rc.readDataCurrent();
                    break;

                case "4":
                    re.readDataEnd(); 
                    break;
                default:
                    Console.WriteLine("Nothing to perform");
                    break; 
            }

        }
    }
 } 

