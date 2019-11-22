using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
namespace SeleniumAssessment
{
    [TestClass]
    public class CaseStudy1
    {
        [TestMethod]
        public void TestMethod()
        {
            IWebDriver driver;
            driver = new ChromeDriver("C:\\Selenium Jar");
            String link = "https://www.google.com"; //URL of the webisite
            driver.Url =link;
            Thread.Sleep(3000); //wait for the page to load
	    driver.Manage().Window.Maximize();
            String query = "DXC Technology";  //Storing the search query
            driver.FindElement(By.Name("q")).SendKeys(query);  //entering the query in the search box
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("gNO89b")).Click(); //Clicking the search button
            Thread.Sleep(3000);
            string title = driver.Title; //Getting the title of the page
            Console.WriteLine(title);
            //Matching the title with query
            if (title.Contains(query))
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
            Thread.Sleep(3000);
            //Getting the result ststs
            String stats = driver.FindElement(By.Id("resultStats")).Text;
            Console.WriteLine(stats); //printing the stats
            driver.Close(); //Closing the browser
                                              
        }
    }
}
