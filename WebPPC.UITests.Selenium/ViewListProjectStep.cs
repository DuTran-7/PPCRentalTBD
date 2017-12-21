using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebPPC.UITests.Selenium.Support;

namespace WebPPC.UITests.Selenium
{
    [Binding]
    public class ViewListProjectStep: SeleniumStepsBase
    {
        [Given(@"the following projects")]
        public void GivenTheFollowingProjects(Table table)
        {
            //IWebDriver _driver = new FirefoxDriver();
            //_driver.Navigate().GoToUrl("http://localhost:50775/Project");
        }

        [Given(@"Toi dang o trang chu")]
        public void GivenToiDangOTrangChu()
        {
            //Browsers.NavigateTo();
            IWebDriver _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl("http://localhost:50775/Project");
        }

        [Given(@"Toi di den dang nhap")]
        public void GivenToiDiDenDangNhap()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Toi dang nhap email '(.*)' va '(.*)'")]
        public void WhenToiDangNhapEmailVa(string email, string password)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Toi se thay duoc danh sach cac du an cua toi")]
        public void ThenToiSeThayDuocDanhSachCacDuAnCuaToi(Table shownProject)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
