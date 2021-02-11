using System;
using System.Collections.Generic;
using System.IO;

namespace usingSets
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            Dictionary<string, int> votes = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(",");
                        if (!votes.ContainsKey(line[0]))
                        {
                            votes[line[0]] = int.Parse(line[1]);
                        }
                        else
                        {
                            votes[line[0]] += int.Parse(line[1]);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("All votes:");
            foreach (var cadidate in votes)
            {
                Console.WriteLine(cadidate.Key + ": " + cadidate.Value);
            }
        }
    }
}
