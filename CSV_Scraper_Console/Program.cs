using System;
using System.IO;

namespace CSV_Scraper_Console
{
    class Program
    {
        //todo Ler e separar os dados contidos em um arquivo csv
        static void Main(string[] args)
        {
            ScraperCSV scraperCSV = new ScraperCSV();
            scraperCSV.ReadFile();            
        }
    }
}
