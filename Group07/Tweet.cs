using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Group07
{
    class Tweet
    {
        private static int recentId = 1;

        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Message { get; set; }
        public string Category { get; set; }

        public Tweet(string from, string to, string message, string category)
        {
            From = from;
            To = to;
            Message = message;
            Category = category;
            Id = recentId;
            ++recentId;

        }

        public override string ToString()
        {
            return $"From: {From}, To:{To}\n" +
                $"Message: {Message.Substring(0,Message.Length-5)}...\n" +
                $"Category: {Category}, ID: {Id}\n";
        }

        public static Tweet Process(string line)
        {
            Tweet t;
            string[] tweetProperties;
            try
            {
               tweetProperties = line.Split(new char[] { '\t' });
               t = new Tweet(tweetProperties[0], tweetProperties[1], tweetProperties[2], tweetProperties[3]);
               
            }
            catch(IndexOutOfRangeException)
            {
                t = new Tweet("Invalid", "Invalid", "Invalid", "Invalid");
                
            }

            return t;                 
        }
    }
}
