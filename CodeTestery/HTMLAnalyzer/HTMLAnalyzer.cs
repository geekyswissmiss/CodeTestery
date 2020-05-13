using HtmlAgilityPack;
using System;
using System.Linq;

namespace HTMLAnalyzer
{
    class HTMLAnalyzer
    {
        public HtmlDocument htmlDocument = new HtmlDocument();

        HTMLAnalyzer(string html)
        {
            htmlDocument.LoadHtml(html);
        }

        public int CountCells()
        {
            int cellCount = 0;
            try
            {
                HtmlNodeCollection tables = htmlDocument.DocumentNode.SelectNodes("//table");
                HtmlNodeCollection cells = htmlDocument.DocumentNode.SelectNodes("//td");
                Console.WriteLine(cells.Count.ToString() + " cells.");                
            }
            catch(Exception ex)
            {

            }

            return cellCount;
        }

        public int CountRows()
        {
            int cellCount = 0;
            try
            {
                HtmlNodeCollection tables = htmlDocument.DocumentNode.SelectNodes("//table");

                foreach (HtmlNode table in tables)
                {
                    var tmp = table.ParentNode;
                    var tableRows = table.SelectNodes("//tr").Count;
                    //Console.WriteLine("Table " + table.ToString() + " has " + tableRows.ToString() + " rows.");
                    Console.WriteLine("Table " + table.ToString() + " has " + tmp.ParentNode.ParentNode.Elements("tr").Count().ToString() + " rows.");
                }
            }
            catch (Exception ex)
            {

            }

            return cellCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            String htmlFile = "C:\\Users\\sylvia\\Documents\\codetests\\examplefiles\\Test.html";
            HtmlDocument doc = new HtmlDocument();
            doc.Load(htmlFile);
            //doc.LoadHtml(string html);
            //doc.Text = "";

            HTMLAnalyzer htmlAnalyzer = new HTMLAnalyzer(doc.Text);
            Console.WriteLine(htmlAnalyzer.CountCells().ToString());
            Console.WriteLine(htmlAnalyzer.CountRows().ToString());
        }
    }
}
