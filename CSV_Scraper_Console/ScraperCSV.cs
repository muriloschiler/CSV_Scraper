using System;
using System.IO;

namespace CSV_Scraper_Console
{
    public class ScraperCSV
    {
        public void ReadFile()
        {
            // Open the file to read from.
            using (StreamReader sr = new StreamReader("exemplo.csv"))
            {
                    try
                    {    
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }catch (Exception e)
                    {
                        Console.WriteLine("The file could not be read:");
                        Console.WriteLine(e.Message);
                    }   
            }
        }
    }
}