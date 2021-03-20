using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using static System.Console;

namespace Group07
{
    class TweetManager
    {
        private static Tweet[] tweets;
        private static string fileName;


        static TweetManager()
        {
            fileName = "C:\\Bruno_Morgado\\Centennial_College\\Second_Semester\\Programming2\\Assignments\\Assignment3\\tweets.txt";
            int count = File.ReadAllLines($"{fileName}").Length;
            tweets = new Tweet[count];
                        
            TextReader reader = new StreamReader(fileName);
            
            for (int i = 0; i < tweets.Length; ++i)
            {
                string line = reader.ReadLine();
                while(line!= null)
                {
                    tweets[i] = Tweet.Process(line);
                    break;
                }
                               
            }
            reader.Close();

        }
        public static void ShowAll()
        
        {
            foreach(Tweet t in tweets)
            {
                WriteLine(t.ToString());
            }
        }

        public static void ShowAll(string category)
        {
            foreach(Tweet t in tweets)
            {
                if (t.Category.ToLower() == category.ToLower())
                {
                    WriteLine(t.ToString());
                }
            }
        }

        public static void ConvertToJason()
        {
            TextWriter writer = new StreamWriter("../../../..tweets.jason");

            foreach(Tweet t in tweets)
            {
                string jsongString = JsonSerializer.Serialize(t);
                writer.WriteLine(jsongString);
            }

            writer.Close();

        }

    }
}
