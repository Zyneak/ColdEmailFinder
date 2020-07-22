using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Email_Checker
{
    class Contact
    {
        string m_Name;
        string m_ProfileURL;
        string m_Position;
        string m_CompanyURL;
        string m_Email;
        string[] patterns = {"finitiallast", "finitial.last", "firstlast", "first.last", "first", "last","firstlinitial", "first.linitial", "first_linitial", "finitial_last", "last_first","first_last","lastfinitiallstinitialf"};
        int where = 1;
        public static string PositionName;
        public static string Company;

        public Contact(string name,string profileUrl, string position,string companyURL)
        {
            m_Name = name;
            m_ProfileURL = profileUrl;
            m_Position = position;
            m_CompanyURL = companyURL;
        }

        public string Name { get => m_Name; set => m_Name = value; }
        public string ProfileURL { get => m_ProfileURL; set => m_ProfileURL = value; }
        public string Position { get => m_Position; set => m_Position = value; }


        public string FindEmail(System.Windows.Forms.CheckBox captcha)
        {
            m_Name = m_Name.ToLower();
            IWebDriver driver = Form1.driver;
            driver.Navigate().GoToUrl("https://tools.verifyemailaddress.io/");
            List<string> emails = new List<string>();
            string companyEmail = m_CompanyURL.Replace("https://www.", "@")
                .Replace("http://www.", "@")
                .Replace("http:", "@")
                .Replace("http:", "@")
                .Replace("https:", "@")
                .Replace("jobs.", "")
                .Replace("/", "");
            string a = "bob";
            char b = a[1];
            bool first = true;
            int i = 0;
            foreach (string pattern in patterns)
            {
                if(where < i)
                {
                    continue;
                }
                
                string[] sName = Name.Split();
                string email = pattern.Replace("first", Name.Split()[0])
                    .Replace("last", Name.Split()[sName.Length - 1])
                    .Replace("finitial", (Name.Split()[0])[0].ToString())
                    .Replace("linitial", (Name.Split()[sName.Length-1])[0].ToString())
                    .Replace("lstinitialf", (Name.Split()[0])[1].ToString());
                Debug.WriteLine("Checking email " + email);
                driver.FindElement(By.XPath("//input[@id='input-email-address']")).SendKeys(email + companyEmail);
                Random r = new Random();
                Thread.Sleep(r.Next(500, 1200));
                driver.FindElement(By.XPath("//button[@class='btn btn-secondary']")).Click();
                Thread.Sleep(r.Next(500, 1200));
                string status = "";
                if(!first)
                    status = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[2]/div/table/tbody/tr/td[2]")).Text;

               
                

                if(status == "Ok")
                {
                    m_Email = email + companyEmail;
                    return email + companyEmail;
                }
                Debug.WriteLine(status);
                first = false;
                i++;
                where++;
            }
            return null;
        }
        
    }
}
