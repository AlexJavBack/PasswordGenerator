using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ 
    class Getpass { 
        public string getPassword(int n)
        {
            int[] passwordArray = new int[n];
            Random rnd = new Random();
            String rezult = "";

            for(int i = 0; i < passwordArray.Length; i++)
            {
                passwordArray[i] = rnd.Next(50, 100);
                rezult += (char)passwordArray[i];

            }
            return rezult;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program progtam = new Program();
            progtam.selectPass();
        }
        public void selectPass()
        {
            Getpass pass = new Getpass();
            Console.WriteLine("input password");
            String inputString = Console.ReadLine();
            int passwordInt = Convert.ToInt32(inputString);
            String newPassword = pass.getPassword(passwordInt);
            Console.Clear();
            Console.WriteLine("Your password is " + newPassword + "have a good day");
            Console.WriteLine("You Accept this password yes/no");
            String choseuser = Console.ReadLine();
            if (choseuser.Equals("yes"))
            {
                Console.WriteLine("OK");
                String fileName = "Password.txt";
                using (StreamWriter writer = new StreamWriter(fileName, false))
                {
                     writer.WriteLineAsync(newPassword);
                }
            }
            else
            {
                selectPass();
            }

        }
    }
   
}
