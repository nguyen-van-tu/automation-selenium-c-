using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var webDriver = new ChromeDriver();
            webDriver.Url = ("http://www.demoqa.com/automation-practice-form/");
            webDriver.Navigate();
            Actions builder = new Actions(webDriver);

            var FirstName = webDriver.FindElement(By.XPath("//input[@id= 'firstName']"));
            FirstName.SendKeys("Nguyễn Văn ");
            var LastName = webDriver.FindElement(By.XPath("//input[@id= 'lastName']"));
            LastName.SendKeys("Tú");
            var Email = webDriver.FindElement(By.XPath("//input[@id= 'userEmail']"));
            Email.SendKeys("Nguyenvantu2972002@gmail.com");

            var gender1 = webDriver.FindElement(By.XPath("//input[@id= 'gender-radio-1']"));
            Boolean check = gender1.Selected;
            if (check == false)
            {

                builder.MoveToElement(gender1).Click().Build().Perform();
                check = true;
            }
            var gender2 = webDriver.FindElement(By.XPath("//input[@id= 'gender-radio-2']"));
            if (check == false)
            {

                builder.MoveToElement(gender2).Click().Build().Perform();
                check = gender1.Selected;
            }
            var gender3 = webDriver.FindElement(By.XPath("//input[@id= 'gender-radio-3']"));
            if (check == false)
            {

                builder.MoveToElement(gender3).Click().Build().Perform();
                check = gender1.Selected;
            }

            var PhoneNumber = webDriver.FindElement(By.XPath("//input[@id= 'userNumber']"));
            PhoneNumber.SendKeys("0368919738");

            var DateOfBirth = webDriver.FindElement(By.XPath("//input[@id='dateOfBirthInput']"));
            DateOfBirth.Clear();
            DateOfBirth.SendKeys("29 Jul 2002");
            //builder.MoveToElement(SelectMonth).Click().Build().Perform();




            //var clickForms = webDriver.FindElements(By.XPath("//h5[text() = 'Forms']"));
            //var clickForm = clickForms.FirstOrDefault(x => x.Text == "Forms");
            //Actions builder = new Actions(webDriver); 
            //builder.MoveToElement(clickForm).Click().Build().Perform();



            //string a = webDriver.Title;
            //Console.WriteLine(a);
            //var clickPracticeForms = webDriver.FindElement(By.XPath("//div[@class = 'element-list collapse show']//li[@class = 'btn btn-light ']"));
            //Actions actions2 = new Actions(webDriver);
            //actions2.MoveToElement(clickForm).Click().Build().Perform();

        }
    }
}
