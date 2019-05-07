using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharbitrager
{
    public partial class Form1 : Form
    {
        private List<string> pageurls = new List<string>();
        private List<string> foundpages = new List<string>();
        private double team1, team2, team3;
        private string team1odds, team2odds, team3odds;
        public Form1()
        {
            InitializeComponent();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Findurls();
            }).Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Findurls()
        {

            var sports = new List<string>() { "football", "tennis", "badminton", "baseball", "basketball", "boxing", "cricket", "darts", "e-sports", "futsal", "handball", "ice-hockey" };
            foreach (var uri in sports)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine(uri.ToUpper());
                Console.WriteLine("-----------------------------------");
                var url = "https://www.oddschecker.com";
                //append base url https://www.oddschecker.com/football
                pageurls.Add(url);
                //Console.WriteLine(url+uri);
                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(url + "/" + uri);
                foreach (HtmlNode link in htmlDoc.DocumentNode.SelectNodes("//a[@href]"))
                {
                    string hrefValue = link.GetAttributeValue("href", string.Empty);
                    if (hrefValue.Contains("http"))
                    {

                    }
                    else
                    {
                        if (hrefValue.Contains(uri))
                        {
                            string sportlink = url + "/" + hrefValue;
                            //Console.WriteLine("---------------------->  " + sportlink);
                            int found = foundpages.IndexOf(sportlink);
                            if (foundpages.Contains(sportlink))
                            {

                            }
                            else
                            {
                                //Console.WriteLine("------------" + sportlink);

                                Findbetpages(sportlink);

                            }
                        }
                        else
                        {

                        }
                    }

                }
            }
        }



        public void Findbetpages(object url)
        {
            List<string> urls = new List<string>();
            var link = url.ToString();
            HtmlWeb web = new HtmlWeb();
            //Get full contents of page
            var htmlDoc = web.Load(link);
            var htmlNodes = htmlDoc.DocumentNode.SelectNodes("//*/div/table/tbody/tr/td/a");

            if (htmlNodes == null)
            {
                //Console.WriteLine("No bet links found");
            }
            else
            {
                try
                {
                    foreach (var node in htmlNodes)
                    {
                        if (urls.Contains(node.Attributes["href"].Value))
                        {

                        }
                        else
                        {
                            if (node.Attributes["href"].Value.Contains("winner"))
                            {
                                Getodds("https://www.oddschecker.com/" + node.Attributes["href"].Value);
                            }
                            else
                            {

                            }
                        }
                    }
                }
                catch
                {

                }
            }
        }

        public void Getodds(string betpage)
        {

            var sporty = new List<string>() { "football", "tennis", };

            HtmlWeb web = new HtmlWeb();
            var oddsDoc = web.Load(betpage);
            //Team1
            var oddslNodes = oddsDoc.DocumentNode.SelectNodes("//*[@id='t1']/tr[1]/td");
            //Draw
            var oddslNodes2 = oddsDoc.DocumentNode.SelectNodes("//*[@id='t1']/tr[2]/td");
            //Team2
            var oddslNodes3 = oddsDoc.DocumentNode.SelectNodes("//*[@id='t1']/tr[3]/td");
            //Team1 Get Odds
            try
            {
                var foundodds = 0;

                foreach (var oddsnode in oddslNodes)
                {

                    var input = oddsnode.OuterHtml;
                    var searchTerm = "b";
                    var pattern = @"\b" + Regex.Escape(searchTerm) + @"\b";
                    var result = Regex.IsMatch(input, pattern); // returns false
                    if (result && foundodds == 0)
                    {

                        foundodds++;
                        if (oddsnode.InnerText.Contains("/"))
                        {
                            try
                            {
                                team1odds = oddsnode.InnerText;
                                string before = oddsnode.InnerText.Substring(0, oddsnode.InnerText.IndexOf('/') + 0);
                                string after = oddsnode.InnerText.Substring(oddsnode.InnerText.IndexOf('/') + 1);
                                int beforeint = 0;
                                Int32.TryParse(before, out beforeint);
                                int afterint = 0;
                                Int32.TryParse(after, out afterint);
                                team1 = (double)beforeint / (double)afterint + 1;


                            }

                            catch { }
                        }

                        else
                        {
                            team1odds = oddsnode.InnerText;
                            int single = 0;
                            Int32.TryParse(oddsnode.InnerText, out single);
                            team1 = (double)single / 1 + 1;

                        }

                    }
                }
            }
            catch
            {

            }
            //Team2 Get Odds
            try
            {
                team3odds = "0";
                team3 = 0;
                var foundodds = 0;
                var foundodds2 = 0;
                //2 Outcome Game
                if (oddslNodes3 == null)
                {

                    foreach (var oddsnode in oddslNodes2)
                    {
                        var input = oddsnode.OuterHtml;
                        var searchTerm = "b";
                        var pattern = @"\b" + Regex.Escape(searchTerm) + @"\b";
                        var result = Regex.IsMatch(input, pattern); // returns false
                        if (result && foundodds == 0)
                        {

                            foundodds++;
                            if (oddsnode.InnerText.Contains("/"))
                            {
                                try
                                {
                                    team2odds = oddsnode.InnerText;
                                    string before = oddsnode.InnerText.Substring(0, oddsnode.InnerText.IndexOf('/') + 0);
                                    string after = oddsnode.InnerText.Substring(oddsnode.InnerText.IndexOf('/') + 1);
                                    int beforeint = 0;
                                    Int32.TryParse(before, out beforeint);
                                    int afterint = 0;
                                    Int32.TryParse(after, out afterint);
                                    team2 = (double)beforeint / (double)afterint + 1;

                                }

                                catch { }
                            }

                            else
                            {
                                //Console.WriteLine(oddsnode.InnerText);
                                team2odds = oddsnode.InnerText;
                                int single = 0;
                                Int32.TryParse(oddsnode.InnerText, out single);
                                team2 = (double)single / 1 + 1;

                            }

                        }
                    }
                }
                //3 Outcome Game
                else
                {

                    foreach (var oddsnode in oddslNodes3)
                    {
                        var input = oddsnode.OuterHtml;
                        var searchTerm = "b";
                        var pattern = @"\b" + Regex.Escape(searchTerm) + @"\b";
                        var result = Regex.IsMatch(input, pattern); // returns false
                        if (result && foundodds == 0)
                        {


                            if (oddsnode.InnerText.Contains("/"))
                            {
                                try
                                {
                                    team2odds = oddsnode.InnerText;
                                    string before = oddsnode.InnerText.Substring(0, oddsnode.InnerText.IndexOf('/') + 0);
                                    string after = oddsnode.InnerText.Substring(oddsnode.InnerText.IndexOf('/') + 1);
                                    int beforeint = 0;
                                    Int32.TryParse(before, out beforeint);
                                    int afterint = 0;
                                    Int32.TryParse(after, out afterint);
                                    team2 = (double)beforeint / (double)afterint + 1;
                                    foundodds++;

                                }

                                catch { }
                            }

                            else
                            {
                                team2odds = oddsnode.InnerText;
                                //Console.WriteLine(oddsnode.InnerText);
                                int single = 0;
                                Int32.TryParse(oddsnode.InnerText, out single);
                                team2 = (double)single / 1 + 1;
                                foundodds++;

                            }

                        }
                    }

                    foreach (var oddsnode in oddslNodes2)
                    {
                        var input = oddsnode.OuterHtml;
                        var searchTerm = "b";
                        var pattern = @"\b" + Regex.Escape(searchTerm) + @"\b";
                        var result = Regex.IsMatch(input, pattern); // returns false
                        if (result && foundodds2 == 0)
                        {


                            if (oddsnode.InnerText.Contains("/"))
                            {
                                try
                                {
                                    team3odds = oddsnode.InnerText;
                                    string before = oddsnode.InnerText.Substring(0, oddsnode.InnerText.IndexOf('/') + 0);
                                    string after = oddsnode.InnerText.Substring(oddsnode.InnerText.IndexOf('/') + 1);
                                    int beforeint = 0;
                                    Int32.TryParse(before, out beforeint);
                                    int afterint = 0;
                                    Int32.TryParse(after, out afterint);
                                    team3 = (double)beforeint / (double)afterint + 1;
                                    foundodds2++;

                                }

                                catch { }
                            }

                            else
                            {
                                team3odds = oddsnode.InnerText;
                                //Console.WriteLine(oddsnode.InnerText);
                                int single = 0;
                                Int32.TryParse(oddsnode.InnerText, out single);
                                team3 = (double)single / 1 + 1;
                                foundodds2++;

                            }

                        }
                    }
                }
            }
            catch
            {

            }
            try
            {
                Console.WriteLine(betpage + "         " + team1odds + "---" + team2odds + "---" + team3odds);
                FindArb(team1, team2, team3, betpage);
            }
            catch
            {
                Console.WriteLine(betpage + "         " + team1odds + "---" + team2odds);
                team3 = 0;
                FindArb(team1, team2, team3, betpage);
            }

        }

        public void FindArb(double team1, double team2, double team3, string betpage)
        {
            int capital = 1000;
            double arb1, arb2, arb3;
            arb1 = 1 / team1 * 100;
            arb2 = 1 / team2 * 100;
            double final;
            if (team3 == 0)
            {
                final = arb1 + arb2;
                arb3 = 0;
                //Console.WriteLine(final);
                Winner(capital, arb1, arb2, arb3, final, betpage);

            }
            else
            {
                arb3 = 1 / team3 * 100;
                //Console.WriteLine(arb1 + "  " + arb2 + "  " + arb3);
                final = arb1 + arb2 + arb3;
                //Console.WriteLine(final);
                Winner(capital, arb1, arb2, arb3, final, betpage);
            }

        }

        public void Winner(int capital, double arb1, double arb2, double arb3, double final, string betpage)
        {

            if (final > 96 && final < 100)
            {

                double profit = (capital / (final / 100)) - capital;
                double team1input = (capital * (arb1 / 100) / (final / 100));
                double team2input = (capital * (arb2 / 100) / (final / 100));
                Console.WriteLine("ARBITRAGE FOUND | PROFIT: " + profit.ToString("C", new CultureInfo("en-GB")));
                Console.WriteLine(betpage);
                if (arb3 == 0)
                {
                    Console.WriteLine("Place bet of " + team1input.ToString("C", new CultureInfo("en-GB")) + " @ " + team1odds + " on Team 1");
                    Console.WriteLine("Place bet of " + team2input.ToString("C", new CultureInfo("en-GB")) + " @ " + team2odds + " on Team 2");
                    dataGridView1.Invoke((MethodInvoker)delegate {
                        dataGridView1.Rows.Add(betpage.ToString(), profit.ToString("C", new CultureInfo("en-GB")), team1input.ToString("C", new CultureInfo("en-GB")), team2input.ToString("C", new CultureInfo("en-GB")), " ");
                    });

                        
                        

                }
                else
                {
                    double team3input = (capital * (arb3 / 100) / (final / 100));
                    Console.WriteLine("Place bet of " + team1input.ToString("C", new CultureInfo("en-GB")) + " on Outcome 1");
                    Console.WriteLine("Place bet of " + team2input.ToString("C", new CultureInfo("en-GB")) + " on Outcome 2");
                    Console.WriteLine("Place bet of " + team3input.ToString("C", new CultureInfo("en-GB")) + " on Outcome 3");
                    dataGridView1.Rows.Add(betpage.ToString(), profit.ToString("C", new CultureInfo("en-GB")), team1input.ToString("C", new CultureInfo("en-GB")), team2input.ToString("C", new CultureInfo("en-GB")), team3input.ToString("C", new CultureInfo("en-GB")));

                }
            }
        }
    }
}
