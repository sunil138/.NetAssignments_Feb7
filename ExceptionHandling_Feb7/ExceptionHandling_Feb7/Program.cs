using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Feb7
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //ISavingAccount savingaccount = new Program();
            //savingaccount.DisplayBalance();
            //savingaccount.AddNewAccount();

            //ICurrentAccount currentAccount = new Program();
            //currentAccount.WithDrawBalance();
            //currentAccount.ChequeBalance(); 

            //syntax of exceptional handling
            try
            {
                //different functionalities
                //var students = new List<string>() {"vishal", "sumanth", "rohith", "farooq", "shirly" };
                //students.Add("vishal"); 
                //students.Add("sumanth");
                //students.Add("rohith");
                //students.Add("farooq");
                //students.Add("shirly"); 
                //foreach(var student in students) 
                //{
                //    Console.WriteLine(student+" ");   

                //}

                //for(int i=0;i<students.Count;i++)
                //{
                //    Console.WriteLine(students[i]);
                //}

                var studentlist = new List<Student>(); 

                studentlist.Add(new Student { studentId = 1, studentName = "Rohith", city = "Bangalore", age = 15, course = "AI" });
                studentlist.Add(new Student{studentId=2,studentName="Ravi",city="Mumbai",age=22,course="ML"});
                studentlist.Add(new Student { studentId = 3, studentName = "Akash", city = "Hyderabad", age = 21, course = "Python" });
                studentlist.Add(new Student { studentId = 4, studentName = "Lokesh", city = "Chennai", age = 20, course = "Data Science" });
                studentlist.Add(new Student { studentId = 5, studentName = "Mohan", city = "Delhi", age = 23, course = ".net" });
                foreach(Student student in studentlist) 
                {
                    Console.WriteLine(student.studentId + " " + student.studentName + " " + student.city + " " + student.age + " " + student.course);

                }

            }
            catch(ArgumentException argex)
            {
                Console.WriteLine(argex.Message);
            }
            catch(IndexOutOfRangeException index)
            {
                Console.WriteLine(index.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }

        //public void AddNewAccount()
        //{
        //    Console.WriteLine("New account created");
        //}

        //public void ChequeBalance()
        //{
        //    Console.WriteLine("Cheque Balance");
        //}

        //public void DisplayBalance()
        //{
        //    Console.WriteLine("Balance is displayed");
        //}

        //public void WithDrawBalance()
        //{
        //    Console.WriteLine("Balance Withdrawl");
        //}

        public class Student
        {
            public int studentId { get; set; }
            public string studentName { get; set; }
            public string city { get; set; } 
            public int age { get; set; }
            public string course { get; set; } 
        }


    }
}
