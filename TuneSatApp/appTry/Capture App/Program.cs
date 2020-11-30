using System;
using System.Linq;

namespace appTry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Capture App");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Input number of ID's!");
            int n = int.Parse(Console.ReadLine());

            string[] arrId = new string[n];
            string[] arrURL = new string[n];
            string[] arrName = new string[n];
            Console.WriteLine("Input ID's!");
            for (int i = 0; i < n; i++)
            {
                arrId[i] = Console.ReadLine();
            }
            Console.WriteLine("Input URL's!");
            for (int i = 0; i < n; i++)
            {
                string url = Console.ReadLine();
                string urlToUse = string.Empty;
                string secLast = string.Empty;
                if (url.Contains("www.youtube.com"))
                {

                    string[] urlArr = url.Split("watch?v=").ToArray();
                    urlToUse = urlArr.Last();
                    if (urlToUse.Contains('/'))
                    {
                       urlToUse = urlToUse.Remove(urlToUse.Length - 1);
                    }
                }
                else if (url.Contains("www.facebook.com"))
                {
                    string[] urlArr = url.Split("videos", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string[] deleteChar = urlArr[1].Split('/').ToArray();
                    urlToUse = deleteChar[1];
                }
                else if (url.Contains("www.instagram.com"))
                {
                    string[] urlArr = url.Split("http://www.instagram.com/p/").ToArray();
                    urlToUse = urlArr[1];
                    if (urlToUse.Contains('/'))
                    {
                        urlToUse = urlToUse.Remove(urlToUse.Length - 1);
                    }
                }
                else if (url.Contains("www.tiktok.com"))
                {
                    string[] urlArr = url.Split("video", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string[] deleteChar = urlArr[1].Split('/').ToArray();
                    urlToUse = deleteChar[1];
                }
                arrURL[i] = urlToUse;
            }
            Console.WriteLine("Input Names!");
            for (int i = 0; i < n; i++)
            {
                arrName[i] = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Picture Titles are:");
            for (int i = 0; i < arrId.Length; i++)
            {
                Console.WriteLine($"{arrId[i]}_{arrURL[i]}");
            }
            Console.WriteLine("OBS Titles are:");
            for (int i = 0; i < arrId.Length; i++)
            {
                Console.WriteLine($"{arrId[i]}_{arrURL[i]}_");
            }
            Console.WriteLine("Video Titles are:");
            for (int i = 0; i < arrId.Length; i++)
            {
                Console.WriteLine($"{arrId[i]}_{arrURL[i]}_{arrName[i]}");
            }
            string input = Console.ReadLine();
        }
    }
}
