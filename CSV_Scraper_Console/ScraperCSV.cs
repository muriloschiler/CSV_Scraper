using System;
using System.IO;
using System.Text.RegularExpressions;

namespace CSV_Scraper_Console
{
    public class ScraperCSV
    {
        public string[] columns { get; set; }
        public void ReadFile()
        {
            // Open the file to read from.
            using (StreamReader sr = new StreamReader("exemplo.csv"))
            {
                    try
                    {    
                        columns = convertToColumns(sr.ReadLine());

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

        private string[] convertToColumns(string line)
        {
            //Todo : Reconhecer , atraves de regex , se o delimitador eh virgula 
            //       ou ponto e virgula
            Regex regex = new Regex(@"^[a-z]+[,]");

            if(regex.IsMatch(line))
            {
                String[] columns = line.Split(",");
                return columns; 
            }

            regex = new Regex(@"^[a-z]+[;]");
            if(regex.IsMatch(line))
            {
                String[] columns = line.Split(";");
                return columns; 
            }
            return null;
        }
    }
}