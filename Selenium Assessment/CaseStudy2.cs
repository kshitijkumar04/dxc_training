using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace SeleniumAssessment
{
    [TestClass]
    public class CaseStudy2
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver;
            driver = new ChromeDriver("C:\\Selenium Jar");
            String link = "http://www.youcandealwithit.com/"; //URL of the webisite
            driver.Url = link;
            Thread.Sleep(3000); //wait for the page to load
            driver.Manage().Window.Maximize();
            //Variables to store the values
            String homelink = "Calculators & Resources";
            String CalculatorLink = "Calculators";
            String BudgetCalcLink = "Budget Calculator";
            String monthlypay = "9000";
            String monthlyOther = "2000";
            String food = "200";
            String clothing = "600";
            String shelter = "1000";
            //Find the Borrowers link in the menu by hovering over it
            IWebElement borrowers = driver.FindElement(By.XPath("//*[@id='siteNav']/li[1]/a"));
            Actions action = new Actions(driver);
            action.MoveToElement(borrowers).Build().Perform();
            //Clicking the link
            driver.FindElement(By.LinkText(homelink)).Click();
            Thread.Sleep(3000);
            //Check if correct page opened
            String title=driver.Title;
            if (title.Contains(homelink))
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
            driver.FindElement(By.LinkText(CalculatorLink)).Click();
            Thread.Sleep(3000);
            //Check if correct page opened
            String title1 = driver.Title;
            if (title1.Contains(CalculatorLink))
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
            driver.FindElement(By.LinkText(BudgetCalcLink)).Click();
            Thread.Sleep(3000);
            //Check if correct page opened
            String title2 = driver.Title;
            if (title2.Contains(BudgetCalcLink))
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
            //Entering the values in the fields
            driver.FindElement(By.Id("food")).SendKeys(food);
            driver.FindElement(By.Id("clothing")).SendKeys(clothing);
            driver.FindElement(By.Id("shelter")).SendKeys(shelter);
            driver.FindElement(By.Id("monthlyPay")).SendKeys(monthlypay);
            driver.FindElement(By.Id("monthlyOther")).SendKeys(monthlyOther);
            String finalvalue = driver.FindElement(By.Id("totalMonthlyExpenses")).GetAttribute("value");
            Console.WriteLine(finalvalue);
            Double final = Double.Parse(finalvalue);
            string total=driver.FindElement(By.Id("totalMonthlyIncome")).GetAttribute("value");
            Double totalpay = Double.Parse(total);
            if (totalpay>=final)
            {
                Console.WriteLine("You are Warren Buffet");
            }
            else
            {
                Console.WriteLine("You are VM");
            }
            Thread.Sleep(5000);
            driver.Close();

        }
    }
}
