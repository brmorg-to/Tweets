using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Group07
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //TweetManager.ShowAll();

            //User Input
            Write("Please enter the category: ");
            string category = ReadLine();
            TweetManager.ShowAll(category);
            

            
        }
    }
}
