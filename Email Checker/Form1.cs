using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using AngleSharp.Html.Parser;
using AngleSharp.Html.Dom;
using AngleSharp.Dom;
using System.Threading;
using System.IO;

namespace Email_Checker
{
    
    public partial class Form1 : Form
    {
        List<Contact> m_Contacts = new List<Contact>();
        List<Contact> m_ChosenConacts = new List<Contact>();
        public static IWebDriver driver;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            
            
        }

        string createEmailTemplate(Contact c)
        {
            string job_title = c.Position;
            string company = Contact.Company;
            string title = c.Position;
            string o = $"I hope this email finds you well.  I just recently saw a posting for a {job_title} position at {company} + and would love to learn more.  My experience with React.js, C#, and Java feels like a great fit for the role\n\nCould you tell me more about the software development team and what it's like to work for the company?I believe you would have great insight as a {title} for {company}.\nI appreciate any information you could provide, looking forward to hearing from you!\n";
            return o;
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if(driver != null)
            {
                driver.Close();
            }
        }

        public void initDriver()
        {
            ChromeOptions co = new ChromeOptions();
            if (!showBrowser.Checked)
            {
                co.AddArgument("--headless");
            }

            driver = new ChromeDriver(@"C:\Users\actja\source\repos\Email Checker\Email Checker\", co);
        }

        private void GatherContacts(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            try
            {
                if(driver == null)
                {
                    initDriver();
                }


                driver.Navigate().GoToUrl(@"https://www.linkedin.com/login");


                driver.FindElement(By.XPath("//input[@id='username']")).SendKeys("actjay1898@gmail.com");
                driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("loldude81");
                driver.FindElement(By.XPath("//button[@class='btn__primary--large from__button--floating']")).Click();

                driver.Navigate().GoToUrl(textBox1.Text);
                string positionName = driver.FindElement(By.XPath("//h1[@class='jobs-top-card__job-title t-24']")).Text;
                Contact.PositionName = positionName;
                string company = driver.FindElement(By.XPath("//a[@class='jobs-top-card__company-url ember-view']")).GetAttribute("href");
                company = company.Replace("/life/", "/people/");
                company += "/?facetGeoRegion=us%3A628&keywords=recruiter%20OR%20acquisitions%20OR%20developer%20OR%20hiring";
                string companyName = driver.FindElement(By.XPath("//a[@class='jobs-top-card__company-url ember-view']")).Text;
                Contact.Company = companyName;
                ProgressLabel.Text = "Loading " + companyName + "'s LinkedIn page";
                driver.Navigate().GoToUrl(company);
                progressBar1.Value = 40;
                Thread.Sleep(1000);
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                var lastHeight = js.ExecuteScript("return document.body.scrollHeight;");
                int wait = 0;
                while (true)
                {
                    wait++;
                    js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");

                    Thread.Sleep(500);

                    var newHeight = js.ExecuteScript("return document.body.scrollHeight;");
                    if (newHeight == lastHeight || wait == 3)
                        break;
                    lastHeight = newHeight;
                }
                progressBar1.Value = 50;
                string companyURL = driver.FindElement(By.XPath("//a[@class='org-top-card-primary-actions__action ember-view']")).GetAttribute("href");
                IReadOnlyCollection<IWebElement> people = driver.FindElements(By.XPath("//li[@class='org-people-profiles-module__profile-item']"));
                int i = 0;
                if(people.Count == 0)
                {
                    ProgressLabel.Text = "No contacts found, sorry!";
                    return;
                }
                foreach (IWebElement profile in people)
                {
                    ProgressLabel.Text = "Gathering " + i + " out of " + people.Count + " contacts";
                    i++;
                    string name = profile.FindElement(By.XPath(".//div[@class='artdeco-entity-lockup__title ember-view']")).Text;
                    string url = "";
                    string position = "";
                    if (name != "LinkedIn Member" && name != "") //Not seen by us
                    {
                        url = profile.FindElement(By.XPath(".//a[@class='link-without-visited-state ember-view']")).GetAttribute("href");
                        position = profile.FindElement(By.XPath(".//div[@class='lt-line-clamp lt-line-clamp--multi-line ember-view']")).Text;
                        m_Contacts.Add(new Contact(name,url,position, companyURL));
                    }

                    
                }

                foreach(Contact contact in m_Contacts)
                {
                    chosenContacts.Items.Add(contact.Name + " " + contact.Position);
                }

                progressBar1.Value = 100;
                ProgressLabel.Text = "Choose the contacts you wish to find the email for.";


            } catch(Exception eee)
            {
                Debug.WriteLine(false, "Fatal error: " + eee.Message);
            }

            

        }

        private void FindEmailForContact(object sender, EventArgs e)
        {
            if(driver == null)
            {
                initDriver();
            }
            Contact badEmailContact = null;
            foreach (int i in chosenContacts.CheckedIndices)
            {
                Contact contact = m_Contacts[i];
                string email = null;
                try
                {
                    email = contact.FindEmail(captcha);
                    if (email == "bad")
                    {
                        badEmailContact = contact;
                    }
                    if (email != null && email != "bad")
                    {

                        m_ChosenConacts.Add(contact);

                        listBox1.Items.Add(contact.Name + ": " + email);
                    }
                }
                catch (Exception eee)
                {
                   
                }
                
            }

            if(badEmailContact != null)
            {
                string email = badEmailContact.FindEmail(captcha);
                if (email != null && email != "bad")
                {

                    m_ChosenConacts.Add(badEmailContact);

                    listBox1.Items.Add(badEmailContact.Name + ": " + email);
                }
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void showBrowser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listbox = (ListBox)sender;
            Contact c = m_ChosenConacts[listbox.SelectedIndex];
            textBox2.Text = createEmailTemplate(c);
        }
    }
}
